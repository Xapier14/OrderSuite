using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace TSuite
{
    public class POSException : Exception
    {
        public POSException() { }
        public POSException(string message)
            :base(message)
        {

        }
        public POSException(string message, Exception inner)
            :base(message, inner)
        {

        }
    }
    public class POSTools
    {
        private readonly byte[] TimeoutPacket = new byte[3] { 127, 1, 1 };
        private int _PacketSize = 128;
        private TcpClient _Client;
        private string ip = "";
        private int port = 0;

        public POSTools(TcpClient cli, string host, int port_)
        {
            _Client = cli;
            ip = host;
            port = port_;
        }
        public POSTools(TcpClient cli, int PacketSize)
        {
            _Client = cli;
            _PacketSize = PacketSize;
            var localEndPoint = cli.Client.LocalEndPoint as IPEndPoint;
            ip = localEndPoint.Address.ToString();
            port = localEndPoint.Port;
        }
        public string GetHostIP()
        {
            return ip;
        }
        public void Reconnect(uint maxTry)
        {
            _Client = new TcpClient();
            bool Connect = false;
            for (int i = 0; i < maxTry; i++)
            {
                try
                {
                    _Client.Connect(ip, port);
                    Connect = true;
                }
                catch (SocketException)
                {
                    Console.WriteLine("Connection Failed. Tries: {0}.", i + 1);
                }
            }
            if (!Connect) throw new POSException("Could not reconnect.");
        }
        /// <summary>
        /// Changes the packet size used by the client and informs the server to do so as well if specified.
        /// </summary>
        /// <param name="PacketSize">The new packet size.</param>
        /// <param name="InformServer">Specify whether to inform the server to change.</param>
        public void ChangePacketSize(int PacketSize, bool InformServer)
        {
            if (InformServer)
            {
                byte[] netsend = Toolbox.JoinArray(new byte[3] { 127, 1, 2 }, BitConverter.GetBytes(PacketSize));
                _Client.GetStream().Write(Toolbox.FormatToPacketSize(netsend, _PacketSize), 0, (int)_PacketSize);
            }
            _PacketSize = PacketSize;
        }
        public void SendTimeoutResetPacket()
        {
            _Client.GetStream().Write(Toolbox.FormatToPacketSize(TimeoutPacket, _PacketSize), 0, _PacketSize);
        }
        public int[] GetProductPrices()
        {
            int getproducts_timeout1 = 10000, getproducts_timeout2 = 10000;
            _Client.GetStream().Write(Toolbox.FormatToPacketSize(new byte[3] { 127, 2, 3 }, _PacketSize), 0, _PacketSize);
            while (true)
            {
                if (getproducts_timeout1 < 0)
                {
                    throw new POSException("Initial request for product prices timed out.");
                }
                else
                {
                    if (_Client.GetStream().DataAvailable)
                    {
                        byte[] buffer4 = new byte[4];
                        _Client.GetStream().Read(buffer4, 0, 4);
                        Console.WriteLine("Length Data Received ({0}). Waiting for list data...", BitConverter.ToInt32(buffer4, 0));
                        while (true)
                        {
                            if (getproducts_timeout2 < 0)
                            {
                                throw new POSException("Data request for product prices timed out.");
                            }
                            else
                            {
                                if (_Client.GetStream().DataAvailable)
                                {
                                    byte[] bufferlist = new byte[BitConverter.ToInt32(buffer4, 0)];
                                    _Client.GetStream().Read(bufferlist, 0, BitConverter.ToInt32(buffer4, 0));
                                    //Console.WriteLine("Product list received from server:\n{0}", Encoding.ASCII.GetString(bufferlist));
                                    return Toolbox.ByteArrayToInt32Array(bufferlist);
                                }
                                else
                                {
                                    Thread.Sleep(1);
                                    --getproducts_timeout2;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(1);
                        --getproducts_timeout1;
                    }
                }
            }
        }
        public string[] GetProductList()
        {
            int getproducts_timeout1 = 10000, getproducts_timeout2 = 10000;
            _Client.GetStream().Write(Toolbox.FormatToPacketSize(new byte[3] { 127, 2, 2 }, _PacketSize), 0, _PacketSize);
            while (true)
            {
                if (getproducts_timeout1 < 0)
                {
                    throw new POSException("Initial request for product list timed out.");
                }
                else
                {
                    if (_Client.Available >= 4)
                    {
                        byte[] buffer4 = new byte[4];
                        _Client.GetStream().Read(buffer4, 0, 4);
                        Console.WriteLine("Length Data Received ({0}). Waiting for list data...", BitConverter.ToInt32(buffer4, 0));
                        while (true)
                        {
                            if (getproducts_timeout2 < 0)
                            {
                                throw new POSException("Data request for product list timed out.");
                            }
                            else
                            {
                                if (_Client.Available >= BitConverter.ToInt32(buffer4,0))
                                {
                                    byte[] bufferlist = new byte[BitConverter.ToInt32(buffer4, 0)];
                                    _Client.GetStream().Read(bufferlist, 0, BitConverter.ToInt32(buffer4, 0));
                                    //Console.WriteLine("Product list received from server:\n{0}", Encoding.ASCII.GetString(bufferlist));
                                    return Encoding.ASCII.GetString(bufferlist).Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                                }
                                else
                                {
                                    Thread.Sleep(1);
                                    --getproducts_timeout2;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(1);
                        --getproducts_timeout1;
                    }
                }
            }
        }
        public string[] GetTypeList()
        {
            int gettype_timeout1 = 10000, gettype_timeout2 = 10000;
            _Client.GetStream().Write(Toolbox.FormatToPacketSize(new byte[3] { 127, 2, 4 }, _PacketSize), 0, _PacketSize);
            while (true)
            {
                if (gettype_timeout1 < 0)
                {
                    throw new POSException("Initial request for product types timed out.");
                }
                else
                {
                    if (_Client.GetStream().DataAvailable)
                    {
                        byte[] buffer4 = new byte[4];
                        _Client.GetStream().Read(buffer4, 0, 4);
                        Console.WriteLine("Length Data Received ({0}). Waiting for list data...", BitConverter.ToInt32(buffer4, 0));
                        while (true)
                        {
                            if (gettype_timeout2 < 0)
                            {
                                throw new POSException("Data request for product types timed out.");
                            }
                            else
                            {
                                if (_Client.GetStream().DataAvailable)
                                {
                                    byte[] bufferlist = new byte[BitConverter.ToInt32(buffer4, 0)];
                                    _Client.GetStream().Read(bufferlist, 0, BitConverter.ToInt32(buffer4, 0));
                                    //Console.WriteLine("Product list received from server:\n{0}", Encoding.ASCII.GetString(bufferlist));
                                    return Encoding.ASCII.GetString(bufferlist).Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                                }
                                else
                                {
                                    Thread.Sleep(1);
                                    --gettype_timeout2;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(1);
                        --gettype_timeout1;
                    }
                }
            }
        }
        public void SendOrder(int ProductID, int OrderGroup, int Amount)
        {
            byte[] packetheader = new byte[3] { 127, 2, 1 };
            byte[] pID = BitConverter.GetBytes(ProductID);
            byte[] OG = BitConverter.GetBytes(OrderGroup);
            byte[] amt = BitConverter.GetBytes(Amount);
            byte[] Packet = Toolbox.JoinArray(Toolbox.JoinArray(packetheader, pID), Toolbox.JoinArray(amt, OG));
            if (!_Client.Connected)
            {
                throw new Exception("Client not connected.");
            }
            SendPacket(Packet);
        }
        public void SendPacket(byte[] Packet)
        {
            if (Packet.Length > _PacketSize)
            {
                throw new POSException("Packet length is larger than packet size.");
            }
            if (!_Client.Connected) throw new POSException("Client not connected.");
            _Client.GetStream().Write(Toolbox.FormatToPacketSize(Packet, _PacketSize), 0, _PacketSize);
        }
        public int AskRecommendationForOrderGroup()
        {
            int ret = 0;
            byte[] ret_buffer = new byte[4];
            if (!_Client.Connected)
            {
                throw new POSException("Client not connected.");
            }
            SendPacket(new byte[3] { 127, 2, 5 }); //send request packet
            while (_Client.Available < 4)
            {
                Thread.Sleep(100);
            }
            _Client.GetStream().Read(ret_buffer, 0, ret_buffer.Length); //receive data
            ret = BitConverter.ToInt32(ret_buffer, 0);
            return ret;
        }
    }
    class Toolbox
    {
        #region Misc Functions
        public enum MapType : uint
        {
            MAPVK_VK_TO_VSC = 0x0,
            MAPVK_VSC_TO_VK = 0x1,
            MAPVK_VK_TO_CHAR = 0x2,
            MAPVK_VSC_TO_VK_EX = 0x3,
        }

        public static Bitmap GetBitmapFromURL(string url)
        {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                return new Bitmap(responseStream);
        }

        [DllImport("user32.dll")]
        public static extern int ToUnicode(
            uint wVirtKey,
            uint wScanCode,
            byte[] lpKeyState,
            [Out, MarshalAs(UnmanagedType.LPWStr, SizeParamIndex = 4)]
            StringBuilder pwszBuff,
            int cchBuff,
            uint wFlags);

        [DllImport("user32.dll")]
        public static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(uint uCode, MapType uMapType);

        public static char GetCharFromKey(Key key)
        {
            char ch = ' ';

            int virtualKey = KeyInterop.VirtualKeyFromKey(key);
            byte[] keyboardState = new byte[256];
            GetKeyboardState(keyboardState);

            uint scanCode = MapVirtualKey((uint)virtualKey, MapType.MAPVK_VK_TO_VSC);
            StringBuilder stringBuilder = new StringBuilder(2);

            int result = ToUnicode((uint)virtualKey, scanCode, keyboardState, stringBuilder, stringBuilder.Capacity, 0);
            switch (result)
            {
                case -1:
                    break;
                case 0:
                    break;
                case 1:
                    {
                        ch = stringBuilder[0];
                        break;
                    }
                default:
                    {
                        ch = stringBuilder[0];
                        break;
                    }
            }
            return ch;
        }
        public static int Clamp(int min, int val, int max)
        {
            if (val < min) return min;
            if (val > max) return max;
            return val;
        }
        public static int[] ByteArrayToInt32Array(byte[] Array)
        {
            int[] ret = new int[Array.Length / 4];
            for (int i = 0; i < (Array.Length - 3); i += 4)
            {
                ret[i / 4] = BitConverter.ToInt32(Array, i);
            }
            return ret;
        }

        /// <summary>
        /// Formats the byte[] data for packet sending.
        /// </summary>
        /// <param name="Data">The data to be formated.</param>
        /// <param name="PacketSize">The size of the Packet</param>
        /// <returns>The formatted data.</returns>
        public static byte[] FormatToPacketSize(byte[] Data, int PacketSize)
        {
            return OverlayArray(Data, NewInitArray(0, PacketSize));
        }
        /// <summary>
        /// Joins two arrays.
        /// </summary>
        /// <param name="Array1">The first array.</param>
        /// <param name="Array2">The second array.</param>
        /// <returns>The joined array. (Array1 + Array2)</returns>
        public static byte[] JoinArray(byte[] Array1, byte[] Array2)
        {
            byte[] ret = new byte[Array1.Length + Array2.Length];
            int i = 0;
            foreach (byte b in Array1)
            {
                ret[i] = b;
                ++i;
            }
            foreach (byte b in Array2)
            {
                ret[i] = b;
                ++i;
            }
            return ret;
        }
        /// <summary>
        /// Converts and sanitizes a string to int32.
        /// </summary>
        /// <param name="Value">The string to be converted.</param>
        /// <returns>The converted string.</returns>
        public static int ConvertToInt32(string Value)
        {
            int ret = 0;
            if (!String.IsNullOrWhiteSpace(Value))
            {
                string v = Regex.Replace(Value, @"[^\d ]", "");
                if (v == String.Empty) return 0;
                ret = Convert.ToInt32(v);
            }
            return ret;
        }
        /// <summary>
        /// Removes all characters except digits.
        /// </summary>
        /// <param name="Value">The input string.</param>
        /// <returns>The result string.</returns>
        public static string PassDigits(string Value)
        {
            return Regex.Replace(Value, @"[^\d ]", "");
        }
        /// <summary>
        /// Overlays Array1 over Array2.
        /// </summary>
        /// <param name="Array1">The array to overlay. Must be smaller than or equal to Array2.</param>
        /// <param name="Array2">The array to be overlayed on. Must Be larger than or equal to Array1.</param>
        /// <returns>Resulting array.</returns>
        public static byte[] OverlayArray(byte[] Array1, byte[] Array2)
        {
            byte[] ret = new byte[0];
            if (Array1.Length <= Array2.Length)
            {
                ret = Array2;
                for (ushort i = 0; i < Array1.Length; ++i)
                {
                    ret[i] = Array1[i];
                }
            }
            else
            {
                Exception ex = new Exception("Array1 cannot be larger than Array2.");
                throw ex;
            }
            return ret;
        }
        /// <summary>
        /// Creates an array initialized with the specified default value.
        /// </summary>
        /// <param name="DefaultValue">The default value for all of the members.</param>
        /// <param name="Length">The length of the array.</param>
        /// <returns>The initialized array.</returns>
        public static byte[] NewInitArray(byte DefaultValue, int Length)
        {
            byte[] ret = new byte[Length];
            for (uint i = 0; i < Length; ++i)
            {
                ret[i] = DefaultValue;
            }
            return ret;
        }
    }
    #endregion
}
