using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DISCPrinting.Application.UseCases;

internal class NexeedBatchIdGeneratorService
{
//    private bool Sent_PARTPROCESSED_single(ref string _error, string batchno, string partno, string beltqty)
//    {
//        //if (NexeedCancel)
//        //{
//        //    NexeedCancel = false;
//        //    EnableCancelNexeed = true;
//        //    return false;
//        //}
//        // create PartProcessed XML
//        var format = "yyyy-MM-ddTHH:mm:ssK";
//        string identifier = DateTime.Now.ToString("yyMMddhhmmss");
//        DateTime finishedtime = DateTime.Now;

//        for (int i = 1; i <= int.Parse(beltqty); i++)
//        {
//            string tempId = "100990_" + identifier + "_" + batchno.Replace(" ", "") + "_0" + i;
//            string timestamp = finishedtime.ToString(format);
//            finishedtime = finishedtime.AddSeconds(-20);

//            string _msg = $@"
//<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>
//<root>
//<header eventId=""0"" eventName=""partProcessed"" version=""1.0"" timeStamp=""{timestamp}"" contentType=""3"" eventSwitch=""-1"">
//<location lineNo=""1009"" statNo=""90"" statIdx=""1"" fuNo=""1"" workPos=""1"" toolPos=""0"" application=""PLC"" processName=""Packing"" processNo=""100990"">
//</location>
//</header>
//<event>
//<partProcessed identifier=""{tempId}"">
//</partProcessed>
//</event>
//<body>
//<structArrays>
//<array name=""parameter"">
//<structDef>
//<item name=""name"" dataType=""8"" />
//<item name=""value"" dataType=""8"" />
//</structDef>
//<values>
//<item name=""Pallet Number"" value=""{PalletNumber}"" />
//</values>
//</array>
//</structArrays>
//<structs>
//<resHead nioBits=""0"" result=""1"" workingCode=""0"" typeNo=""{partno.Replace(".", "")}"" typeVar=""{PalletNumber}"" batch=""{batchno.Replace(" ", "")}"" palletno=""{PalletNumber}"">
//</resHead>
//</structs>
//</body>
//</root>
//";

//            if (!SentTo_MES(ref _msg))
//            {
//                _error = "Sent_PARTPROCESSED: error sending telegram!";
//                //ErrorMsg(_error);
//                //MessageBox.Show("taho1: " + _error);
//                return false;
//            }
//        }

//        return true;
//    }
    private string mes_HOST, mes_PORT;
    private bool SentTo_MES(ref string _msg)
    {
        mes_HOST = "10.184.205.12";
        mes_PORT = "55065";
        try
        {
            Socket tcpclnt = null;

            if (tcpclnt != null)
            {
                if (tcpclnt.Connected)
                {
                    tcpclnt.Disconnect(false);
                }

                tcpclnt.Close();
                tcpclnt.Dispose();
                tcpclnt = null;
            }

            tcpclnt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpclnt.ReceiveBufferSize = 1048576;
            tcpclnt.SendBufferSize = 1048576;
            tcpclnt.Connect(IPAddress.Parse(mes_HOST), int.Parse(mes_PORT));
            ASCIIEncoding asen = new ASCIIEncoding();
            string aux = _msg;
            byte[] bMsg = asen.GetBytes(aux);
            int host = bMsg.Length + 4;
            int num2 = host;
            host = IPAddress.HostToNetworkOrder(host);
            byte[] bStart = BitConverter.GetBytes(host);
            byte[] bFinal = new byte[num2];
            Buffer.BlockCopy(bStart, 0, bFinal, 0, bStart.Length);
            Buffer.BlockCopy(bMsg, 0, bFinal, bStart.Length, bMsg.Length);
            tcpclnt.Send(bFinal, bFinal.Length, SocketFlags.None);
            tcpclnt.ReceiveTimeout = 2000;
            byte[] bResponse = new byte[4096];
            byte[] bResponseFinal = new byte[4092];
            tcpclnt.Receive(bResponse);
            Buffer.BlockCopy(bResponse, 4, bResponseFinal, 0, bResponseFinal.Length);
            string response = Encoding.Default.GetString(bResponseFinal).Replace("\0", "");
            _msg = response;
            return true;
        }
        catch (Exception exc)
        {
            //MessageBox.Show("Exception: " + exc.Message);
            return false;
        }
    }
}
