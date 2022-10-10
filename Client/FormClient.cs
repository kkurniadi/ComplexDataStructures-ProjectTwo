using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
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
            KeyPress += new KeyPressEventHandler(TextBoxes_KeyPress); 
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
            string lang = CultureInfo.CurrentUICulture.Name;
            switch (lang)
            {
                case "fr-FR":
                    StatusStripFeedback.Text = "Inactive";
                    break;
                case "de-DE":
                    StatusStripFeedback.Text = "Leerlauf";
                    break;
                default:
                    StatusStripFeedback.Text = "Idle";
                    break;
            }
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
                if (!string.IsNullOrEmpty(textBoxObserved.Text) && !string.IsNullOrEmpty(textBoxRest.Text))
                {
                    CultureInfo culture = CultureInfo.CurrentUICulture;
                    double obs = double.Parse(textBoxObserved.Text);
                    double rest = double.Parse(textBoxRest.Text);
                    double velocity = pipeProxy.StarVelocity(obs, rest);
                    string[] row = new string[] { "Star Velocity", velocity.ToString("E2", culture), "m/s" };
                    switch (culture.Name)
                    {
                        case "fr-FR":
                            row[0] = "Vitesse des Étoiles";
                            StatusStripFeedback.Text = "Calculé la vitesse de l'étoile";
                            break;
                        case "de-DE":
                            row[0] = "Sterngeschwindigkeit";
                            StatusStripFeedback.Text = "Berechnete die Sterngeschwindigkeit";
                            break;
                        default:
                            StatusStripFeedback.Text = "Calculated the star velocity";
                            break;
                    }
                    dataGridViewDisplay.Rows.Add(row);
                    textBoxObserved.Clear();
                    textBoxRest.Clear();
                }
                else
                    PromptForInput();
            }
            catch (EndpointNotFoundException)
            {
                PromptForConnection();
            }
            catch (Exception)
            {
                PromptForReopen();
            }
        }
        private void ButtonCalcDistance_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxAngle.Text))
                {
                    CultureInfo culture = CultureInfo.CurrentUICulture;
                    double angle = double.Parse(textBoxAngle.Text);
                    double distance = pipeProxy.StarDistance(angle);
                    string[] row = new string[] { "Star Distance", distance.ToString("G3", culture), "parsecs" };
                    switch (culture.Name)
                    {
                        case "fr-FR":
                            row[0] = "Distance Étoile";
                            StatusStripFeedback.Text = "Calculé la distance des étoiles";
                            break;
                        case "de-DE":
                            row[0] = "Sternenentfernung";
                            StatusStripFeedback.Text = "Berechnete die Sternentfernung";
                            break;
                        default:
                            StatusStripFeedback.Text = "Calculated the star distance";
                            break;
                    }
                    dataGridViewDisplay.Rows.Add(row);
                    textBoxAngle.Clear();
                }
                else
                    PromptForInput();
            }
            catch (EndpointNotFoundException)
            {
                PromptForConnection();
            }
            catch (Exception)
            {
                PromptForReopen();
            }
        }
        private void ButtonCalcKelvin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxCelsius.Text))
                {
                    CultureInfo culture = CultureInfo.CurrentUICulture;
                    double celsius = double.Parse(textBoxCelsius.Text);
                    double kelvin = pipeProxy.TempInKelvin(celsius);
                    string[] row = new string[] { "Temp in Kelvin", kelvin.ToString(culture), "K" };
                    switch (culture.Name)
                    {
                        case "fr-FR":
                            row[0] = "Température en Kelvin";
                            StatusStripFeedback.Text = "Calculer la température en Kelvin";
                            break;
                        case "de-DE":
                            row[0] = "Temperatur in Kelvin";
                            StatusStripFeedback.Text = "Berechnete die Temperatur in Kelvin";
                            break;
                        default:
                            StatusStripFeedback.Text = "Calculated the temperature in Kelvin";
                            break;
                    }
                    dataGridViewDisplay.Rows.Add(row);
                    textBoxCelsius.Clear();
                }
                else
                    PromptForInput();
            }
            catch (EndpointNotFoundException)
            {
                PromptForConnection();
            }
            catch (Exception)
            {
                PromptForReopen();
            }
        }
        private void ButtonCalcEH_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxMass.Text))
                {
                    CultureInfo culture = CultureInfo.CurrentUICulture;
                    double mass = double.Parse(textBoxMass.Text) * Math.Pow(10, (double)numericUpDownMass.Value);
                    double radius = pipeProxy.EventHorizon(mass);
                    string[] row = new string[] { "Event Horizon", radius.ToString("G2", culture), "m" };
                    switch (culture.Name)
                    {
                        case "fr-FR":
                            row[0] = "Horizon des événements";
                            StatusStripFeedback.Text = "Calculé l'horizon des événements";
                            break;
                        case "de-DE":
                            row[0] = "Ereignishorizont";
                            StatusStripFeedback.Text = "Berechnete den Ereignishorizont";
                            break;
                        default:
                            StatusStripFeedback.Text = "Calculated the event horizon";
                            break;
                    }
                    dataGridViewDisplay.Rows.Add(row);
                    textBoxMass.Clear();
                }
                else
                    PromptForInput();
            }
            catch (EndpointNotFoundException)
            {
                PromptForConnection();
            }
            catch (Exception)
            {
                PromptForReopen();
            }
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
        // 7.4. Menu option to change the form’s style (colours and visual appearance).
        #region StyleChanging
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
                        button.BackColor = SystemColors.Control;
                        button.ForeColor = SystemColors.ControlText;
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
                    break;
            }
        }
        #endregion
        // 7.5. Menu/Button option to select a custom colour from a colour palette (Color Dialogbox)
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
                CustomToolStripMenuItem.Checked = true;
                LightToolStripMenuItem.Checked = false;
                DarkToolStripMenuItem.Checked = false;
            }
        }
        #region Utilities
        private void PromptForConnection()
        {
            switch (CultureInfo.CurrentUICulture.Name)
            {
                case "fr-FR":
                    MessageBox.Show("Veuillez ouvrir l'application serveur et réessayer", "Serveur déconnecté", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "de-DE":
                    MessageBox.Show("Bitte öffnen Sie die Serveranwendung und versuchen Sie es erneut", "Server getrennt",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Please open the server application and try again", "Server Disconnected",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void PromptForInput()
        {
            switch (CultureInfo.CurrentUICulture.Name)
            {
                case "fr-FR":
                    MessageBox.Show("Veuillez remplir les cases appropriées et réessayer", "Entrée de données",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "de-DE":
                    MessageBox.Show("Bitte füllen Sie die entsprechenden Felder aus und versuchen Sie es erneut", "Dateneingabe",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Please fill the appropriate boxes and try again", "Data Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void PromptForReopen()
        {
            switch (CultureInfo.CurrentUICulture.Name)
            {
                case "fr-FR":
                    MessageBox.Show("Une erreur s'est produite lors de la connexion au serveur\nVeuillez fermer et rouvrir le serveur et réessayer.",
                        "Erreur du Serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "de-DE":
                    MessageBox.Show("Beim Verbinden mit dem Server ist ein Fehler aufgetreten\nBitte schließen und öffnen Sie den Server erneut und versuchen Sie es erneut",
                        "Serverfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("There was an error connecting to the server\nPlease close and reopen the server and try again.",
                        "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != 46 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf((char)46) > -1 || (sender as TextBox).Text.IndexOf((char)44) > -1)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
    }
}
