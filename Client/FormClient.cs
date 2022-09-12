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
using System.Threading;
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
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            ConnectToServer();
        }
        private void ConnectToServer()
        {
            ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/AstroServer"));
            pipeProxy = pipeFactory.CreateChannel();
            StatusStripConnection.Text = "Idle";
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
            dataGridViewDisplay.Rows.Add("Star Velocity", velocity.ToString("E2", CultureInfo.CurrentUICulture), "m/s");
            textBoxObserved.Clear();
            textBoxRest.Clear();
        }
        private void ButtonCalcDistance_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBoxAngle.Text);
            double distance = pipeProxy.StarDistance(angle);
            dataGridViewDisplay.Rows.Add("Star Distance", distance.ToString("G3", CultureInfo.CurrentUICulture), "parsecs");
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
            dataGridViewDisplay.Rows.Add("Event Horizon", radius.ToString("G2", CultureInfo.CurrentUICulture), "m");
            textBoxMass.Clear();
        }
        #endregion
        // 7.3. Menu/Button option(s) to change the language and layout for the three different countries.
        #region LanguageChanging
        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }
        private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
        }
        private void GermanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
        }
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            ConnectToServer();
        }
        #endregion
        // TODO: 7.4. Menu option to change the form’s style (colours and visual appearance).
        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // TODO: 7.5. Menu/Button option to select a custom colour from a colour palette (Color Dialogbox)
    }
}
