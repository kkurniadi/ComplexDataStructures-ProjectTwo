﻿using System;
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
                    ForeColor = DefaultForeColor;
                    foreach (var button in Controls.OfType<Button>())
                    {
                        button.BackColor = SystemColors.Control;
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
                    foreach (var menuStrip in Controls.OfType<MenuStrip>())
                    {
                        menuStrip.BackColor = SystemColors.Control;
                    }
                    foreach (var menuItem in Controls.OfType<ToolStripMenuItem>())
                    {
                        menuItem.BackColor = SystemColors.Control;
                        menuItem.ForeColor = SystemColors.ControlText;
                    }
                    break;
                case "Dark":
                    BackColor = SystemColors.ControlDarkDark;
                    ForeColor = SystemColors.ControlLightLight;
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
                    foreach (var menuStrip in Controls.OfType<MenuStrip>())
                    {
                        menuStrip.BackColor = SystemColors.ControlDark;
                    }
                    foreach (var menuItem in Controls.OfType<ToolStripMenuItem>())
                    {
                        menuItem.BackColor = SystemColors.ControlDark;
                        menuItem.ForeColor = SystemColors.ControlLightLight;
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
                ForeColor = Color.FromArgb(r, g, b);
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }
                CustomToolStripMenuItem.Checked = true;
                LightToolStripMenuItem.Checked = false;
                DarkToolStripMenuItem.Checked = false;
            }
        }
    }
}
