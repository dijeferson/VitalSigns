using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace VitalSigns.Distributed
{
    class DistributedClient
    {
        private string _RemoteAddress;
        private int _RemotePort;
        private TcpClient _Client;
        private Stream _DataStream;
        private ASCIIEncoding _Encoding;
        private byte[] _ByteStream;

        /// <summary>
        /// 
        /// </summary>
        public string RemoteAddress
        {
            get { return _RemoteAddress; }
            set { _RemoteAddress = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int RemotePort
        {
            get { return _RemotePort; }
            set { _RemotePort = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private TcpClient Client
        {
            get { return _Client; }
            set { _Client = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Stream DataStream
        {
            get { return _DataStream; }
            set { _DataStream = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public ASCIIEncoding Encoding
        {
            get { return _Encoding; }
            set { _Encoding = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public byte [] ByteStream
        {
            get { return _ByteStream; }
            set { _ByteStream = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Connect()
        {
            try
            {
                Client.Connect(this.RemoteAddress, this.RemotePort);
                return 0;
            }
            catch (SocketException ex)
            {
                return 1;
            }
            catch (TimeoutException ex)
            {
                return 2;
            }
            catch (IOException ex)
            {
                return 4;
            }
            catch (System.Security.SecurityException ex)
            {
                return 8;
            }
            catch (Exception ex)
            {
                return 16;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Disconnect()
        {
            if (Client.Connected)
                Client.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sData"></param>
        /// <returns></returns>
        public int SendData(string sData)
        {
            DataStream = Client.GetStream();
            Encoding = new ASCIIEncoding();
            ByteStream = Encoding.GetBytes(sData);
            DataStream.Write(ByteStream, 0, ByteStream.Length);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        public string GetData(int bufferSize)
        {
            byte[] receivedData = new byte[bufferSize];
            int k = DataStream.Read(receivedData, 0, bufferSize);
            return receivedData.ToString();
        }
    }
}
