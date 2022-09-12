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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.StatusStripConnection = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusStripFeedback = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LangToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LangToolStripMenuItem
            // 
            this.LangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.LangToolStripMenuItem.Name = "LangToolStripMenuItem";
            this.LangToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.LangToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.frenchToolStripMenuItem.Text = "French";
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.germanToolStripMenuItem.Text = "German";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.customToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocity.Location = new System.Drawing.Point(107, 38);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(95, 16);
            this.labelVelocity.TabIndex = 1;
            this.labelVelocity.Text = "Star Velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Observed Wavelength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rest Wavelength";
            // 
            // textBoxObserved
            // 
            this.textBoxObserved.Location = new System.Drawing.Point(143, 65);
            this.textBoxObserved.Name = "textBoxObserved";
            this.textBoxObserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxObserved.TabIndex = 4;
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(143, 93);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(100, 20);
            this.textBoxRest.TabIndex = 5;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(403, 38);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(100, 16);
            this.labelDistance.TabIndex = 6;
            this.labelDistance.Text = "Star Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parallax Angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "nm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "nm";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(406, 68);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngle.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "arcseconds";
            // 
            // ButtonCalcVelocity
            // 
            this.ButtonCalcVelocity.Location = new System.Drawing.Point(110, 129);
            this.ButtonCalcVelocity.Name = "ButtonCalcVelocity";
            this.ButtonCalcVelocity.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalcVelocity.TabIndex = 12;
            this.ButtonCalcVelocity.Text = "Calculate";
            this.ButtonCalcVelocity.UseVisualStyleBackColor = true;
            this.ButtonCalcVelocity.Click += new System.EventHandler(this.ButtonCalcVelocity_Click);
            // 
            // ButtonCalcDistance
            // 
            this.ButtonCalcDistance.Location = new System.Drawing.Point(406, 129);
            this.ButtonCalcDistance.Name = "ButtonCalcDistance";
            this.ButtonCalcDistance.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalcDistance.TabIndex = 13;
            this.ButtonCalcDistance.Text = "Calculate";
            this.ButtonCalcDistance.UseVisualStyleBackColor = true;
            // 
            // labelKelvin
            // 
            this.labelKelvin.AutoSize = true;
            this.labelKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelvin.Location = new System.Drawing.Point(85, 174);
            this.labelKelvin.Name = "labelKelvin";
            this.labelKelvin.Size = new System.Drawing.Size(158, 16);
            this.labelKelvin.TabIndex = 14;
            this.labelKelvin.Text = "Temperature in Kelvin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Temperature (Celsius)";
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(143, 204);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(100, 20);
            this.textBoxCelsius.TabIndex = 16;
            // 
            // ButtonCalcKelvin
            // 
            this.ButtonCalcKelvin.Location = new System.Drawing.Point(110, 242);
            this.ButtonCalcKelvin.Name = "ButtonCalcKelvin";
            this.ButtonCalcKelvin.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalcKelvin.TabIndex = 17;
            this.ButtonCalcKelvin.Text = "Calculate";
            this.ButtonCalcKelvin.UseVisualStyleBackColor = true;
            // 
            // labelEventHorizon
            // 
            this.labelEventHorizon.AutoSize = true;
            this.labelEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventHorizon.Location = new System.Drawing.Point(400, 174);
            this.labelEventHorizon.Name = "labelEventHorizon";
            this.labelEventHorizon.Size = new System.Drawing.Size(103, 16);
            this.labelEventHorizon.TabIndex = 18;
            this.labelEventHorizon.Text = "Event Horizon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Blackhole Mass";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(414, 204);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(41, 20);
            this.textBoxMass.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(461, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "x 10";
            // 
            // numericUpDownMass
            // 
            this.numericUpDownMass.Location = new System.Drawing.Point(494, 200);
            this.numericUpDownMass.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMass.Name = "numericUpDownMass";
            this.numericUpDownMass.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownMass.TabIndex = 22;
            this.numericUpDownMass.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(539, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "kg";
            // 
            // ButtonCalcEH
            // 
            this.ButtonCalcEH.Location = new System.Drawing.Point(406, 242);
            this.ButtonCalcEH.Name = "ButtonCalcEH";
            this.ButtonCalcEH.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalcEH.TabIndex = 24;
            this.ButtonCalcEH.Text = "Calculate";
            this.ButtonCalcEH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewDisplay.Location = new System.Drawing.Point(44, 288);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.Size = new System.Drawing.Size(504, 150);
            this.dataGridViewDisplay.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Calculation Type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Result";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units";
            this.Column3.Name = "Column3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripConnection,
            this.toolStripSeparator1,
            this.StatusStripFeedback});
            this.toolStrip1.Location = new System.Drawing.Point(0, 443);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(599, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StatusStripConnection
            // 
            this.StatusStripConnection.Name = "StatusStripConnection";
            this.StatusStripConnection.Size = new System.Drawing.Size(12, 22);
            this.StatusStripConnection.Text = "-";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StatusStripFeedback
            // 
            this.StatusStripFeedback.Name = "StatusStripFeedback";
            this.StatusStripFeedback.Size = new System.Drawing.Size(12, 22);
            this.StatusStripFeedback.Text = "-";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 468);
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
            this.Text = "Astronomical Processing";
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
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel StatusStripConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel StatusStripFeedback;
    }
}

