namespace Client
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GermanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObserved = new System.Windows.Forms.TextBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonCalcVelocity = new System.Windows.Forms.Button();
            this.ButtonCalcDistance = new System.Windows.Forms.Button();
            this.labelKelvin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.ButtonCalcKelvin = new System.Windows.Forms.Button();
            this.labelEventHorizon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownMass = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonCalcEH = new System.Windows.Forms.Button();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StatusStripFeedback = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LangToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // LangToolStripMenuItem
            // 
            resources.ApplyResources(this.LangToolStripMenuItem, "LangToolStripMenuItem");
            this.LangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnglishToolStripMenuItem,
            this.FrenchToolStripMenuItem,
            this.GermanToolStripMenuItem});
            this.LangToolStripMenuItem.Name = "LangToolStripMenuItem";
            // 
            // EnglishToolStripMenuItem
            // 
            resources.ApplyResources(this.EnglishToolStripMenuItem, "EnglishToolStripMenuItem");
            this.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem";
            this.EnglishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // FrenchToolStripMenuItem
            // 
            resources.ApplyResources(this.FrenchToolStripMenuItem, "FrenchToolStripMenuItem");
            this.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem";
            this.FrenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
            // 
            // GermanToolStripMenuItem
            // 
            resources.ApplyResources(this.GermanToolStripMenuItem, "GermanToolStripMenuItem");
            this.GermanToolStripMenuItem.Name = "GermanToolStripMenuItem";
            this.GermanToolStripMenuItem.Click += new System.EventHandler(this.GermanToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightToolStripMenuItem,
            this.DarkToolStripMenuItem,
            this.CustomToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            // 
            // LightToolStripMenuItem
            // 
            resources.ApplyResources(this.LightToolStripMenuItem, "LightToolStripMenuItem");
            this.LightToolStripMenuItem.Name = "LightToolStripMenuItem";
            this.LightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItem_Click);
            // 
            // DarkToolStripMenuItem
            // 
            resources.ApplyResources(this.DarkToolStripMenuItem, "DarkToolStripMenuItem");
            this.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem";
            this.DarkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItem_Click);
            // 
            // CustomToolStripMenuItem
            // 
            resources.ApplyResources(this.CustomToolStripMenuItem, "CustomToolStripMenuItem");
            this.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem";
            this.CustomToolStripMenuItem.Click += new System.EventHandler(this.CustomToolStripMenuItem_Click);
            // 
            // labelVelocity
            // 
            resources.ApplyResources(this.labelVelocity, "labelVelocity");
            this.labelVelocity.Name = "labelVelocity";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxObserved
            // 
            resources.ApplyResources(this.textBoxObserved, "textBoxObserved");
            this.textBoxObserved.Name = "textBoxObserved";
            // 
            // textBoxRest
            // 
            resources.ApplyResources(this.textBoxRest, "textBoxRest");
            this.textBoxRest.Name = "textBoxRest";
            // 
            // labelDistance
            // 
            resources.ApplyResources(this.labelDistance, "labelDistance");
            this.labelDistance.Name = "labelDistance";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxAngle
            // 
            resources.ApplyResources(this.textBoxAngle, "textBoxAngle");
            this.textBoxAngle.Name = "textBoxAngle";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // ButtonCalcVelocity
            // 
            resources.ApplyResources(this.ButtonCalcVelocity, "ButtonCalcVelocity");
            this.ButtonCalcVelocity.Name = "ButtonCalcVelocity";
            this.ButtonCalcVelocity.UseVisualStyleBackColor = true;
            this.ButtonCalcVelocity.Click += new System.EventHandler(this.ButtonCalcVelocity_Click);
            // 
            // ButtonCalcDistance
            // 
            resources.ApplyResources(this.ButtonCalcDistance, "ButtonCalcDistance");
            this.ButtonCalcDistance.Name = "ButtonCalcDistance";
            this.ButtonCalcDistance.UseVisualStyleBackColor = true;
            this.ButtonCalcDistance.Click += new System.EventHandler(this.ButtonCalcDistance_Click);
            // 
            // labelKelvin
            // 
            resources.ApplyResources(this.labelKelvin, "labelKelvin");
            this.labelKelvin.Name = "labelKelvin";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBoxCelsius
            // 
            resources.ApplyResources(this.textBoxCelsius, "textBoxCelsius");
            this.textBoxCelsius.Name = "textBoxCelsius";
            // 
            // ButtonCalcKelvin
            // 
            resources.ApplyResources(this.ButtonCalcKelvin, "ButtonCalcKelvin");
            this.ButtonCalcKelvin.Name = "ButtonCalcKelvin";
            this.ButtonCalcKelvin.UseVisualStyleBackColor = true;
            this.ButtonCalcKelvin.Click += new System.EventHandler(this.ButtonCalcKelvin_Click);
            // 
            // labelEventHorizon
            // 
            resources.ApplyResources(this.labelEventHorizon, "labelEventHorizon");
            this.labelEventHorizon.Name = "labelEventHorizon";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textBoxMass
            // 
            resources.ApplyResources(this.textBoxMass, "textBoxMass");
            this.textBoxMass.Name = "textBoxMass";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // numericUpDownMass
            // 
            resources.ApplyResources(this.numericUpDownMass, "numericUpDownMass");
            this.numericUpDownMass.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMass.Name = "numericUpDownMass";
            this.numericUpDownMass.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // ButtonCalcEH
            // 
            resources.ApplyResources(this.ButtonCalcEH, "ButtonCalcEH");
            this.ButtonCalcEH.Name = "ButtonCalcEH";
            this.ButtonCalcEH.UseVisualStyleBackColor = true;
            this.ButtonCalcEH.Click += new System.EventHandler(this.ButtonCalcEH_Click);
            // 
            // dataGridViewDisplay
            // 
            resources.ApplyResources(this.dataGridViewDisplay, "dataGridViewDisplay");
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripFeedback});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // StatusStripFeedback
            // 
            resources.ApplyResources(this.StatusStripFeedback, "StatusStripFeedback");
            this.StatusStripFeedback.Name = "StatusStripFeedback";
            // 
            // FormClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.ButtonCalcEH);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDownMass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelEventHorizon);
            this.Controls.Add(this.ButtonCalcKelvin);
            this.Controls.Add(this.textBoxCelsius);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelKelvin);
            this.Controls.Add(this.ButtonCalcDistance);
            this.Controls.Add(this.ButtonCalcVelocity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.textBoxRest);
            this.Controls.Add(this.textBoxObserved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FrenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GermanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomToolStripMenuItem;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxObserved;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonCalcVelocity;
        private System.Windows.Forms.Button ButtonCalcDistance;
        private System.Windows.Forms.Label labelKelvin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Button ButtonCalcKelvin;
        private System.Windows.Forms.Label labelEventHorizon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownMass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ButtonCalcEH;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel StatusStripFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

