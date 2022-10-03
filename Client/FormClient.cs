using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (CultureInfo.CurrentUICulture.Name == "fr-FR")
                StatusStripFeedback.Text = "Inactive";
            else if (CultureInfo.CurrentUICulture.Name == "de-DE")
                StatusStripFeedback.Text = "Leerlauf";
            else
                StatusStripFeedback.Text = "Idle";
        }
        private void PromptForConnection()
        {
            StatusStripFeedback.Text = "Disconnected";
        }
        // 7.2. Create a form with suitable components for UI,
        // a. Series of textboxes for large numeric data,
        // b. A listview/datagrid for display of processed information from the server,
        // c. Button(s) to initiate an event and send/receive data.
        #region CalcButtonMethods
        private void ButtonCalcVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                double obs = double.Parse(textBoxObserved.Text);
                double rest = double.Parse(textBoxRest.Text);
                double velocity = pipeProxy.StarVelocity(obs, rest);
                string[] row = new string[] { "Star Velocity", velocity.ToString("E2", CultureInfo.CurrentUICulture), "m/s" };
                if (CultureInfo.CurrentUICulture.Name == "fr-FR")
                {
                    row[0] = "Vitesse des Étoiles";
                    StatusStripFeedback.Text = "Calculé la vitesse de l'étoile";
                }
                else if (CultureInfo.CurrentUICulture.Name == "de-DE")
                {
                    row[0] = "Sterngeschwindigkeit";
                    StatusStripFeedback.Text = "Berechnete die Sterngeschwindigkeit";
                }
                else
                    StatusStripFeedback.Text = "Calculated the star velocity";
                dataGridViewDisplay.Rows.Add(row);
                textBoxObserved.Clear();
                textBoxRest.Clear();
            }
            catch (EndpointNotFoundException)
            {
                PromptForConnection();
            }
        }
        private void ButtonCalcDistance_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBoxAngle.Text);
            double distance = pipeProxy.StarDistance(angle);
            string[] row = new string[] { "Star Distance", distance.ToString("G3", CultureInfo.CurrentUICulture), "parsecs" };
            if (CultureInfo.CurrentUICulture.Name == "fr-FR")
            {
                row[0] = "Distance Étoile";
                StatusStripFeedback.Text = "Calculé la distance des étoiles";
            }
            else if (CultureInfo.CurrentUICulture.Name == "de-DE")
            {
                row[0] = "Sternenentfernung";
                StatusStripFeedback.Text = "Berechnete die Sternentfernung";
            }
            else
                StatusStripFeedback.Text = "Calculated the star distance";
            dataGridViewDisplay.Rows.Add(row);
            textBoxAngle.Clear();
        }
        private void ButtonCalcKelvin_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textBoxCelsius.Text);
            double kelvin = pipeProxy.TempInKelvin(celsius);
            string[] row = new string[] { "Temp in Kelvin", kelvin.ToString(CultureInfo.CurrentUICulture), "K" };
            if (CultureInfo.CurrentUICulture.Name == "fr-FR")
            {
                row[0] = "Température en Kelvin";
                StatusStripFeedback.Text = "Calculer la température en Kelvin";
            }
            else if (CultureInfo.CurrentUICulture.Name == "de-DE")
            {
                row[0] = "Temperatur in Kelvin";
                StatusStripFeedback.Text = "Berechnete die Temperatur in Kelvin";
            }
            else
                StatusStripFeedback.Text = "Calculated the temperature in Kelvin";
            dataGridViewDisplay.Rows.Add(row);
            textBoxCelsius.Clear();
        }
        private void ButtonCalcEH_Click(object sender, EventArgs e)
        {
            double mass = double.Parse(textBoxMass.Text) * Math.Pow(10, (double)numericUpDownMass.Value);
            double radius = pipeProxy.EventHorizon(mass);
            string[] row = new string[] { "Event Horizon", radius.ToString("G2", CultureInfo.CurrentUICulture), "m" };
            if (CultureInfo.CurrentUICulture.Name == "fr-FR")
            {
                row[0] = "Horizon des événements";
                StatusStripFeedback.Text = "Calculé l'horizon des événements";
            }
            else if (CultureInfo.CurrentUICulture.Name == "de-DE")
            {
                row[0] = "Ereignishorizont";
                StatusStripFeedback.Text = "Berechnete den Ereignishorizont";
            }
            else
                StatusStripFeedback.Text = "Calculated the event horizon";
            dataGridViewDisplay.Rows.Add(row);
            textBoxMass.Clear();
        }
        #endregion
        // 7.3. Menu/Button option(s) to change the language and layout for the three different countries.
        #region LanguageChanging
        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
            EnglishToolStripMenuItem.Checked = true;
            FrenchToolStripMenuItem.Checked = false;
            GermanToolStripMenuItem.Checked = false;
        }
        private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
            FrenchToolStripMenuItem.Checked = true;
            EnglishToolStripMenuItem.Checked = false;
            GermanToolStripMenuItem.Checked = false;
        }
        private void GermanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
            GermanToolStripMenuItem.Checked = true;
            EnglishToolStripMenuItem.Checked = false;
            FrenchToolStripMenuItem.Checked = false;
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
            ChangeTheme("Light");
            LightToolStripMenuItem.Checked = true;
            DarkToolStripMenuItem.Checked = false;
            CustomToolStripMenuItem.Checked = false;
        }
        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("Dark");
            DarkToolStripMenuItem.Checked = true;
            LightToolStripMenuItem.Checked = false;
            CustomToolStripMenuItem.Checked = false;
        }
        private void ChangeTheme(string themeName)
        {
            switch (themeName)
            {
                case "Light":
                    BackColor = DefaultBackColor;
                    foreach (var label in Controls.OfType<Label>())
                    {
                        label.ForeColor = DefaultForeColor;
                    }
                    foreach (var button in Controls.OfType<Button>())
                    {
                        button.BackColor = SystemColors.ButtonFace;
                        button.ForeColor = SystemColors.ControlText;
                    }
                    foreach (var textBox in Controls.OfType<TextBox>())
                    {
                        textBox.BackColor = SystemColors.Window;
                        textBox.ForeColor = SystemColors.WindowText;
                    }
                    foreach (var upDown in Controls.OfType<NumericUpDown>())
                    {
                        upDown.BackColor = SystemColors.Window;
                        upDown.ForeColor = SystemColors.WindowText;
                    }
                    break;
                case "Dark":
                    BackColor = SystemColors.ControlDarkDark;
                    foreach (var label in Controls.OfType<Label>())
                    {
                        label.ForeColor = SystemColors.ControlLightLight;
                    }
                    foreach (var button in Controls.OfType<Button>())
                    {
                        button.BackColor = SystemColors.ControlDark;
                        button.ForeColor = SystemColors.ControlLightLight;
                    }
                    foreach (var textBox in Controls.OfType<TextBox>())
                    {
                        textBox.BackColor = SystemColors.WindowFrame;
                        textBox.ForeColor = SystemColors.HighlightText;
                    }
                    foreach (var upDown in Controls.OfType<NumericUpDown>())
                    {
                        upDown.BackColor = SystemColors.WindowFrame;
                        upDown.ForeColor = SystemColors.HighlightText;
                    }
                    break;
            }
        }
        // TODO: 7.5. Menu/Button option to select a custom colour from a colour palette (Color Dialogbox)
        private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDlg.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                foreach (var label in Controls.OfType<Label>())
                {
                    label.ForeColor = Color.FromArgb(r, g, b);
                }
                foreach (var button in Controls.OfType<Button>())
                {
                    button.BackColor = colorDlg.Color;
                    button.ForeColor = Color.FromArgb(r, g, b);
                }
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.BackColor = colorDlg.Color;
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }
                foreach (var upDown in Controls.OfType<NumericUpDown>())
                {
                    upDown.BackColor = colorDlg.Color;
                    upDown.ForeColor = Color.FromArgb(r, g, b);
                }
                CustomToolStripMenuItem.Checked = true;
                LightToolStripMenuItem.Checked = false;
                DarkToolStripMenuItem.Checked = false;
            }
        }
    }
}
