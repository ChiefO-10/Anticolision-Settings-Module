using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ACModule
{
    public partial class AC : Form
    {
        #region Fields
        private static ACSettings ACsettings;
        #endregion

        #region Constructor
        public AC()
        {
            InitializeComponent();
            ACsettings = new ACSettings();
            //Disabling set buttons until service started
            SetCPA.Enabled = false;
            SetVelTurn.Enabled = false;
            //Disabling start/stop buttons until connected
            Start.Enabled = false;
            Stop.Enabled = false;
            //Seting limits information in labels
            CPALimTxt.Text = $"[{ACsettings.CPALimit[0]},{ACsettings.CPALimit[1]}]";
            TCPALimTxt.Text = $"[{ACsettings.TCPALimit[0]},{ACsettings.TCPALimit[1]}]";
            VelLimTxt.Text = $"[{ACsettings.VelLimit[0]},{ACsettings.VelLimit[1]}]";
            TurnLimTxt.Text = $"[{ACsettings.TurnLimit[0]},{ACsettings.TurnLimit[1]}]";
        }
        #endregion

        #region Event Handlers

        /// <summary>
        /// Handling click on "Start" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                //Sending via UDP pause service command and enabling set buttons
                ACsettings.Resume();
                SetCPA.Enabled = true;
                SetVelTurn.Enabled = true;
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"{ex.Message}");
            }
        }

        /// <summary>
        /// Handling click on "Stop" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                //Sending via UDP pause service command and disabling set buttons
                ACsettings.Pause();
                SetCPA.Enabled = false;
                SetVelTurn.Enabled = false;
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"{ex.Message}");
            }
        }

        /// <summary>
        /// Handling click on CPA and TCPA "Set" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetCPA_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for empty set values
                if (string.IsNullOrEmpty(CPA.Text) || string.IsNullOrEmpty(TCPA.Text))
                    throw new ArgumentNullException($"CPA or TCPA is empty");
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"Wrong input: {ex.Message}");
                return;
            }

            try
            {
                //Value checking
                ACsettings.CPAValue = ACsettings.ValueCheck(CPA.Text,"CPA");
                ACsettings.TCPAVAalue = ACsettings.ValueCheck(TCPA.Text,"TCPA");
                //Sending setting values via UDP
                ACsettings.Set_CPA_TCPA(ACsettings.CPAValue, ACsettings.TCPAVAalue);
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"Wrong input: {ex.Message}");
                return;
            }
            //Display set value in message box
            MessageDisplay.Text = $"CPA set to {ACsettings.CPAValue}\nTCPA set to {ACsettings.TCPAVAalue}";
        }

        /// <summary>
        /// Handling click on Velocity and Turn "Set" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetVelTurn_Click(object sender, EventArgs e)
        {

            try
            {
                //Check for empty set values
                if (string.IsNullOrEmpty(Velocity.Text) || string.IsNullOrEmpty(Turn.Text))
                    throw new ArgumentNullException($"Velocity or Turn is empty");
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"Wrong input: {ex.Message}");
                return;
            }

            try
            {
                //Value checking
                ACsettings.VelocityValue = ACsettings.ValueCheck(Velocity.Text,"Velocity");
                ACsettings.TrunValue = ACsettings.ValueCheck(Turn.Text,"Turn");
                //Sending setting values via UDP
                ACsettings.Set_Vel_Turn(ACsettings.VelocityValue, ACsettings.TrunValue);
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"Wrong input: {ex.Message}");
                return;
            }

            MessageDisplay.Text = $"Velocity set to {ACsettings.VelocityValue}\nTurn set to {ACsettings.TrunValue}";
        }

        /// <summary>
        /// Handling click on "Connect" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //Disable set buttons
                SetCPA.Enabled = false;
                SetVelTurn.Enabled = false;
                //set up UDP connection if false disable start set buttons otherwise enable start / stop buttons
                if (!ACsettings.Connect(HostName.Text, Port.Text))
                {
                    Start.Enabled = false;
                    Stop.Enabled = false;
                    return;
                }
                Start.Enabled = true;
                Stop.Enabled = true;
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"Wrong input: {ex.Message}");
                return;
            }
        }

        /// <summary>
        /// Actions on closing form
        /// </summary>
        private void AC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ACsettings.client == null)
                return;

            ACsettings.client.Close();
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Display exception info to user
        /// </summary>
        /// <param name="message">Message to display</param>
        private void ExeptionInfoDisplay(string message)
        {
            MessageDisplay.Text = $"{message}";
            MessageBox.Show($"{message}");
        }
        #endregion
    }
}
