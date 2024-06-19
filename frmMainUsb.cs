using ADRcpLib;
using ADSioLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace RFIDsetting_test
{
    public partial class frmMainUsb : Form
    {
        public static SioBase SioBase = new SioUsb();
        public static RcpBase RcpBase = new RcpBase();
        public bool IsConnectedSio
        {
            get
            {
                if (SioBase == null) return false;
                if (!SioBase.bConnected) return false;
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="protocolPacket"></param>
        public void SendSio(ProtocolPacket protocolPacket)
        {
            if (IsConnectedSio)
            {
                RcpBase.ShowBytePack(protocolPacket);
                SioBase.Send(protocolPacket.ToArray());
            }
        }

        private void BaseInit()
        {
            SioBase.onStatus += SioBase_onStatus;
            SioBase.onReceived += SioBase_onReceived;

            RcpBase.RxRspParsed += RcpBase_RxRspParsed;
            RcpBase.TxRspParsed += RcpBase_TxRspParsed;
        }

        private void SioBase_onStatus(object sender, StatusEventArgs e)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    btnConnect.Enabled = true;
                    Application.DoEvents();

                    switch ((StatusType)e.Status)
                    {
                        case StatusType.CONNECT_OK:
                            try
                            {
                                int intVer = Convert.ToInt32(e.Msg);
                            }
                            catch { }
                            btnDisconnect.Enabled = true;
                            btnConnect.Enabled = false;
                            AppendTrace("CONNECTED OK> " + e.Msg + "(" + SioBase.ToString() + ")", ref rtxtRes);
                            break;
                        case StatusType.CONNECT_FAIL:
                            AppendTrace("ERROR> " + e.Msg + "(" + SioBase.ToString() + ")", ref rtxtRes);
                            break;
                        case StatusType.DISCONNECT_OK:
                            btnDisconnect.Enabled = false;
                            AppendTrace("DISCONNECT OK> " + e.Msg + "(" + SioBase.ToString() + ")", ref rtxtRes);
                            break;
                        case StatusType.DISCONNECT_EXCEPT:
                            AppendTrace("ERROR> " + e.Msg + "(" + SioBase.ToString() + ")", ref rtxtRes);
                            break;
                        default:
                            break;
                    }
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SioBase_onReceived(object sender, ReceivedEventArgs e)
        {
            RcpBase.ReciveBytePkt(e.Data);
        }

        private void RcpBase_TxRspParsed(object sender, ProtocolEventArgs e)
        {
            AppendTrace("Tx> " + TagInfo.ByteArrayToHexString(e.Data), ref rtxtRes);
        }

        private void RcpBase_RxRspParsed(object sender, ProtocolEventArgs e)
        {
            if (this.IsDisposed)
                return;

            if (!this.InvokeRequired)
            {
                AppendTrace("Rx> " + TagInfo.ByteArrayToHexString(e.Data), ref rtxtRes);
                __ParseRsp(e.Protocol);
                return;
            }

            this.Invoke(new MethodInvoker(delegate ()
            {
                try
                {
                    AppendTrace("Rx> " + TagInfo.ByteArrayToHexString(e.Data), ref rtxtRes);
                    __ParseRsp(e.Protocol);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }));
        }

        private int GetCodelen(byte iData)
        {
            return (((iData >> 3) + 1) * 2);
        }

        private string GetRssi(byte rssi)
        {
            int rssidBm = (sbyte)rssi; // rssidBm is negative && in bytes
            rssidBm -= Convert.ToInt32("-20", 10);
            rssidBm -= Convert.ToInt32("3", 10);
            return rssidBm.ToString();
        }

        private void __ParseRsp(ProtocolPacket protocolPacket)
        {
            switch (protocolPacket.Code)
            {
                case RcpBase.RCP_CMD_INFO:
                    if (protocolPacket.Length > 30 && (protocolPacket.Type & 0x7f) == 0)
                    {
                        #region ---Parameter---
                        string strInfo = Encoding.ASCII.GetString(protocolPacket.Payload, 0, protocolPacket.Length);

                        AppendTrace("Type:" + RcpBase.Mode + RcpBase.Type + " - Version:" + RcpBase.Version + " - Address: " + RcpBase.Address, ref rtxtRes);
                        #endregion
                    }
                    break;

                case RcpBase.RCP_MM_READ_C_UII:
                    if (protocolPacket.Type == 2 || protocolPacket.Type == 5)
                    {
                        int pcepclen = GetCodelen(protocolPacket.Payload[1]);
                        int datalen = protocolPacket.Length - 2;//去掉天线号去掉rssi
                        TagInfo cp = new TagInfo
                        {
                            TagType = TagType.TYPE_6C,
                            Length = datalen,//去掉天线号去掉RSSI
                            Antenna = protocolPacket.Payload[0],
                            PCData = TagInfo.GetData(protocolPacket.Payload, 1, 2),
                            EPCData = TagInfo.GetData(protocolPacket.Payload, 3, pcepclen - 2),
                            Rssi = GetRssi(protocolPacket.Payload[protocolPacket.Length - 1]) + "dBm"
                        };
                        if ((datalen - pcepclen) > 0) cp.DataBytes = TagInfo.GetData(protocolPacket.Payload, 1 + pcepclen, datalen - pcepclen);
                        txtCard.Text = cp.EPCString;
                    }

                    break;
                case RcpBase.RCP_MM_READ_C_DT:
                    if (protocolPacket.Type == 0)
                    {
                        int pcepclen = GetCodelen(protocolPacket.Payload[1]);
                        int datalen = protocolPacket.Length - pcepclen - 1;//去掉天线号去掉PC+EPc
                        TagInfo cp = new TagInfo
                        {
                            TagType = TagType.TYPE_6C,
                            Length = datalen,
                            Antenna = protocolPacket.Payload[0],
                            PCData = TagInfo.GetData(protocolPacket.Payload, 1, 2),
                            EPCData = TagInfo.GetData(protocolPacket.Payload, 3, pcepclen - 2),
                            DataBytes = TagInfo.GetData(protocolPacket.Payload, 1 + pcepclen, datalen)
                        };
                        txtDataHex.Text = cp.DataString;
                        //txtDataAscii.Text = Encoding.GetEncoding("gb2312").GetString(cp.DataBytes, 0, cp.DataBytes.Length);


                        Application.DoEvents();

                    }
                    break;
                case RcpBase.RCP_MM_WRITE_C_DT:
                    if (protocolPacket.Type == 0)
                    {
                        int pcepclen = GetCodelen(protocolPacket.Payload[1]);
                        int datalen = protocolPacket.Length - pcepclen - 1;//去掉天线号去掉PC+EPc
                        TagInfo cp = new TagInfo
                        {
                            TagType = TagType.TYPE_6C,
                            Length = datalen,
                            Antenna = protocolPacket.Payload[0],
                            PCData = TagInfo.GetData(protocolPacket.Payload, 1, 2),
                            EPCData = TagInfo.GetData(protocolPacket.Payload, 3, pcepclen - 2)
                        };
                    }
                    break;
                case RcpBase.RCP_MM_GET_ACCESS_EPC_MATCH:
                    break;
                case RcpBase.RCP_MM_SET_ACCESS_EPC_MATCH:
                    break;
                default:
                    break;
            }
        }

        public static void AppendTrace(string text, ref RichTextBox richTextBox)
        {
            try
            {
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.SelectionLength = 0;
                richTextBox.AppendText(text + Environment.NewLine);

                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.SelectionLength = 0;
                richTextBox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public frmMainUsb()
        {
            InitializeComponent();
        }

        private void LoadUsbDevice()
        {
            List<DictionaryEntry> deviceList = new List<DictionaryEntry>();
            if (SioUsb.GetHidDeviceList(ref deviceList))
            {
                cmbUsbDeviceList.DataSource = deviceList;
                cmbUsbDeviceList.DisplayMember = "key";
                cmbUsbDeviceList.ValueMember = "value";

                cmbUsbDeviceList.SelectedIndex = 0;

                rtxtRes.AppendText("发现USB设备!\r\n");
            }
        }

        private void cmbUsbDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsbDevicePath.Text = ((DictionaryEntry)cmbUsbDeviceList.SelectedItem).Value.ToString();
        }

        public void InterfaceInit()
        {
            LoadUsbDevice();
            cmbMem.SelectedIndex = 2;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InterfaceInit();
            BaseInit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SioBase.Connect(txtUsbDevicePath.Text, 2);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            SioBase.DisConnect();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_READ_C_UII, RcpBase.RCP_MSG_CMD));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            byte mode = (byte)2;
            byte epclen = (byte)(txtCard.Text.Length / 2);
            byte[] epc = TagInfo.HexStringToByteArray(txtCard.Text);

            List<byte> param = new List<byte>();
            param.Add(mode);
            param.Add(epclen);
            param.AddRange(epc);
            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_SET_ACCESS_EPC_MATCH, RcpBase.RCP_MSG_CMD, param.ToArray()));
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            List<byte> param = new List<byte>();
            param.Add(0);
            param.Add(0);
            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_SET_ACCESS_EPC_MATCH, RcpBase.RCP_MSG_CMD, param.ToArray()));
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            byte[] ap = TagInfo.HexStringToByteArray(ftxtAccessPwd.Text);
            byte mb = (byte)cmbMem.SelectedIndex;
            byte sa = (byte)Convert.ToInt32(txtStart.Text);
            byte dl = (byte)Convert.ToInt32(txtLength.Text);

            List<byte> param = new List<byte>();
            param.AddRange(ap);
            param.Add(mb);
            param.Add(sa);
            param.Add(dl);

            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_READ_C_DT, RcpBase.RCP_MSG_CMD, param.ToArray()));
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            byte[] ap = TagInfo.HexStringToByteArray(ftxtAccessPwd.Text);
            byte mb = (byte)cmbMem.SelectedIndex;
            byte sa = (byte)Convert.ToInt32(txtStart.Text);
            byte dl = (byte)Convert.ToInt32(txtLength.Text);
            byte[] dt = TagInfo.HexStringToByteArray(txtDataHex.Text);
            dl = (byte)(dt.Length / 2);
            txtLength.Text = dl.ToString();

            List<byte> param = new List<byte>();
            param.AddRange(ap);
            param.Add(mb);
            param.Add(sa);
            param.Add(dl);
            param.AddRange(dt);

            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_WRITE_C_DT, RcpBase.RCP_MSG_CMD, param.ToArray()));
        }


        private void btnTempSwitchCommand_Click(object sender, EventArgs e)
        {
            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_CTRL_AUTO_READ, RcpBase.RCP_MSG_CMD, new byte[] { 0 }));
        }

        private void btnTempSwitchActive_Click(object sender, EventArgs e)
        {
            SendSio(new ProtocolPacket(RcpBase.Address, RcpBase.RCP_MM_CTRL_AUTO_READ, RcpBase.RCP_MSG_CMD, new byte[] { 1 }));
        }
    }
}
