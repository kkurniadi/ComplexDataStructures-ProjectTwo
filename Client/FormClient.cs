using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// Kirsten Kurniadi, ID: 30045816
// Date: 5/09/2022
// Windows .NET Framework Forms application client
// Sends raw data to the server and receives processed information
namespace Client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }
        IAstroContract pipeProxy = null;
        private void FormClient_Load(object sender, EventArgs e)
        {
            ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/AstroServer"));
            pipeProxy = pipeFactory.CreateChannel();
            StatusStripConnection.Text = "Connected to server";
        }
        // 7.2. Create a form with suitable components for UI,
        // a. Series of textboxes for large numeric data,
        // b. A listview/datagrid for display of processed information from the server,
        // c. Button(s) to initiate an event and send/receive data.
        #region CalcButtonMethods
        private void ButtonCalcVelocity_Click(object sender, EventArgs e)
        {
            double obs = double.Parse(textBoxObserved.Text);
            double rest = double.Parse(textBoxRest.Text);
            double velocity = pipeProxy.StarVelocity(obs, rest);
            dataGridViewDisplay.Rows.Add("Star Velocity", velocity.ToString("E2", CultureInfo.CurrentCulture), "m/s");
            textBoxObserved.Clear();
            textBoxRest.Clear();
        }
        private void ButtonCalcDistance_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBoxAngle.Text);
            double distance = pipeProxy.StarDistance(angle);
            dataGridViewDisplay.Rows.Add("Star Distance", distance.ToString("G3", CultureInfo.CurrentCulture), "parsecs");
            textBoxAngle.Clear();
        }
        private void ButtonCalcKelvin_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textBoxCelsius.Text);
            dataGridViewDisplay.Rows.Add("Temp in Kelvin", pipeProxy.TempInKelvin(celsius), "K");
            textBoxCelsius.Clear();
        }
        private void ButtonCalcEH_Click(object sender, EventArgs e)
        {
            double mass = double.Parse(textBoxMass.Text) * Math.Pow(10, (double)numericUpDownMass.Value);
            double radius = pipeProxy.EventHorizon(mass);
            dataGridViewDisplay.Rows.Add("Event Horizon", radius.ToString("G2", CultureInfo.CurrentCulture), "m");
            textBoxMass.Clear();
        }
        #endregion
        // TODO: 7.3. Menu/Button option(s) to change the language and layout for the three different countries.

        // TODO: 7.4. Menu option to change the form’s style (colours and visual appearance).

        // TODO: 7.5. Menu/Button option to select a custom colour from a colour palette (Color Dialogbox)
    }
}
