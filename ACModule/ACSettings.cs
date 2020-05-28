using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ACModule
{

    class ACSettings
    {
        #region Public Properties

        /// <summary>
        /// CPA input value
        /// </summary>
        public string CPAValue { get; set; }

        /// <summary>
        /// TCPA input value
        /// </summary>
        public string TCPAVAalue { get; set; }

        /// <summary>
        /// Velocity max limit value
        /// </summary>
        public string VelocityValue { get; set; }

        /// <summary>
        /// Turn max limit value
        /// </summary>
        public string TrunValue { get; set; }

        /// <summary>
        /// Udp Client
        /// </summary>
        public UdpClient client;

        /// <summary>
        /// CPA value limits in meters [0] = min  [1] = max
        /// </summary>
        public double[] CPALimit { get; } = { 0, 100 };
        /// <summary>
        /// TCPA value limits in minutes [0] = min  [1] = max
        /// </summary>
        public double[] TCPALimit { get; } = { 0, 10 };
        /// <summary>
        /// Speed value limits in m/s [0] = min  [1] = max
        /// </summary>
        public double[] VelLimit { get; } = { 0, 10 };
        /// <summary>
        /// Turn value limits [0] = min  [1] = max
        /// </summary>
        public double[] TurnLimit { get; } = { 0, 60 };


        #endregion

        #region Private Members

        /// <summary>
        /// Handshake command
        /// </summary>
        private const string Handshake = "Hello from SymArpa!";

        /// <summary>
        /// Log out command
        /// </summary>
        private const string LogOut = "Bye from SymArpa!";

        /// <summary>
        /// Resume service command
        /// </summary>
        private const string ResumeCommand = "01020201000000000000";

        /// <summary>
        /// Pause service command
        /// </summary>
        private const string PauseCommand = "01020200000000000000";
        #endregion


        #region Constructor
        public ACSettings()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// UDP connection helper method
        /// </summary>
        /// <returns></returns>
        public bool Connect(string hostName, string portNumber)
        {
            try
            {

                if (string.IsNullOrEmpty(hostName) || string.IsNullOrEmpty(portNumber))
                    throw new ArgumentNullException("Host Name or Port");

                int mPort;
                if (!int.TryParse(portNumber, out mPort))
                    throw new InvalidOperationException($"Port is not a number: {portNumber}");

                client?.Close();
                client?.Dispose(); 

                client = new UdpClient(mPort);
                client.Connect(hostName, mPort);
                Login(client);

                return true;
            }
            catch
            {
                if (!(client == null)) client.Close();
                throw;
            }

        }

        /// <summary>
        /// Login helper method
        /// </summary>
        private void Login(UdpClient Client)
        {
            if (!Client.Client.Connected)
            {
                MessageBox.Show("No UDP connection");
                return;
            }
            Byte[] sendBytes = Encoding.ASCII.GetBytes(Handshake);
            Client.Send(sendBytes, sendBytes.Length);
        }

        /// <summary>
        /// Log out helper method
        /// </summary>
        public void Logout()
        {
            if (!client.Client.Connected)
            {
                MessageBox.Show("No UDP connection");
                return;
            }
            Byte[] sendBytes = Encoding.ASCII.GetBytes(LogOut);
            client.Send(sendBytes, sendBytes.Length);
        }

        /// <summary>
        /// Send UDP message to set CPA and TCPA limits
        /// </summary>
        /// <param name="CPAValue"></param>
        /// CPA value
        /// <param name="TCPAValue"></param>
        /// TCPA value
        public bool Set_CPA_TCPA(string CPAValue,string TCPAValue)
        {
            if (!client.Client.Connected)
            {
                MessageBox.Show("No UDP connection");
                return false;
            }
            var msg = $"010203{CPAValue}{TCPAValue}0000000000";
            Byte[] sendBytes = Encoding.ASCII.GetBytes(msg);
            client.Send(sendBytes, sendBytes.Length);
            return true;
        }

        /// <summary>
        /// Send UDP message to set Velocity and Turn limits
        /// </summary>
        /// <param name="VelValue"></param>
        /// Velocity value
        /// <param name="TurnValue"></param>
        /// Turn value
        public bool Set_Vel_Turn(string VelValue, string TurnValue)
        {
            if (!client.Client.Connected)
            {
                MessageBox.Show("No UDP connection");
                return false;
            }
            var msg = $"010205{VelValue}{TurnValue}0000000000";
            try
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(msg);
                client.Send(sendBytes, sendBytes.Length);
                return true;
            }
            catch
            {
                throw;
            }
            
        }

        public void Resume()
        {
            if (!client.Client.Connected)
            {
                throw new InvalidOperationException("No UDP connection");
            }
            Byte[] sendBytes = Encoding.ASCII.GetBytes(ResumeCommand);
            client.Send(sendBytes, sendBytes.Length);
            return;
        }
        public void Pause()
        {
            if (!client.Client.Connected)
            {
                throw new InvalidOperationException("NO UDP connection");
            }
            Byte[] sendBytes = Encoding.ASCII.GetBytes(PauseCommand);
            client.Send(sendBytes, sendBytes.Length);
            return;
        }

        /// <summary>
        /// Check input correctness
        /// </summary>
        /// <param name="userText"></param>
        /// User input text
        /// <param name="SettingName"></param>
        ///  Type of value "CPA","TCPA","Velocity" or "Turn"
        /// <returns></returns>
        public string ValueCheck(string userText, string SettingName)
        {
            var input = userText.Replace(" ", "");
            input = input.Replace(",", ".");
            try
            {
                //foreach (char c in input)
                //    if (!"1234567890".Any(n => c == n))
                //        throw new InvalidOperationException($"Input is not a valid number\n     Input: {input}");

                if (!Regex.IsMatch(input, @"^\d{0,}(\.\d{1,4})?$"))
                    throw new ArgumentException($"{SettingName} is not a valid number\n     Input: {input}");
                if (input.First() == '.') input = input.PadLeft(input.Length + 1, '0');

                if (!LimitCheck(input, SettingName)) throw new ArgumentException($"{SettingName} is out of range \n     Input: {input}");
                return input;
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// Checking if setting between limits
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <param name="VariableName">Type of value "CPA","TCPA","Velocity" or "Turn"</param>
        /// <returns></returns>
        public bool LimitCheck(string value, string VariableName)
        {
            double parsed;  
            if (!double.TryParse(value, out parsed)) return false;       
            switch (VariableName)
            {
                case "CPA":
                    if (parsed < CPALimit[0] || parsed > CPALimit[1]) return false;
                    else break;
                case "TCPA":
                    if (parsed < TCPALimit[0] || parsed > TCPALimit[1]) return false;
                    else break;
                case "Velocity":
                    if (parsed < VelLimit[0] || parsed > VelLimit[1]) return false;
                    else break;
                case "Turn":
                    if (parsed < TurnLimit[0] || parsed > TurnLimit[1]) return false;
                    else break;
                default: 
                    return false;
            }
            return true;
        }

        #endregion
    }
}
