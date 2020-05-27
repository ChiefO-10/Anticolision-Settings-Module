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

            SetCPA.Enabled = false;
            SetVelTurn.Enabled = false;

            Start.Enabled = false;
            Stop.Enabled = false;

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
            SetCPA.Enabled = false;
            SetVelTurn.Enabled = false;

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
                ACsettings.CPAValue = ACsettings.ValueCheck(CPA.Text,"CPA");
                ACsettings.TCPAVAalue = ACsettings.ValueCheck(TCPA.Text,"TCPA");

                ACsettings.Set_CPA_TCPA(ACsettings.CPAValue, ACsettings.TCPAVAalue);
            }
            catch (Exception ex)
            {
                ExeptionInfoDisplay($"Wrong input: {ex.Message}");
                return;
            }

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
                ACsettings.VelocityValue = ACsettings.ValueCheck(Velocity.Text,"Velocity");
                ACsettings.TrunValue = ACsettings.ValueCheck(Turn.Text,"Turn");

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
                if (!ACsettings.Connect(HostName.Text, Port.Text)) return;
                
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
        private void ExeptionInfoDisplay(string message)
        {
            MessageDisplay.Text = $"{message}";
            MessageBox.Show($"{message}");
        }
        #endregion
    }
}
