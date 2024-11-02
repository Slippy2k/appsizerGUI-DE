namespace appsizerGUI
{
    partial class appsizerGUI
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
            this.menuWindowSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.useAboveTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.savedWindowSelector = new System.Windows.Forms.ComboBox();
            this.windowBottom = new System.Windows.Forms.Label();
            this.windowRight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.windowHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.windowWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.windowY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.windowX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.useCalibration = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSaveWindow = new System.Windows.Forms.Button();
            this.btnRemoveWindow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowX)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowSelect,
            this.menuOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuWindowSelect
            // 
            this.menuWindowSelect.Name = "menuWindowSelect";
            this.menuWindowSelect.Size = new System.Drawing.Size(95, 20);
            this.menuWindowSelect.Text = "Select window";
            this.menuWindowSelect.DropDownOpening += new System.EventHandler(this.ListWindows);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useAboveTaskbar});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(61, 20);
            this.menuOptions.Text = "Options";
            // 
            // useAboveTaskbar
            // 
            this.useAboveTaskbar.Checked = true;
            this.useAboveTaskbar.CheckOnClick = true;
            this.useAboveTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAboveTaskbar.Name = "useAboveTaskbar";
            this.useAboveTaskbar.Size = new System.Drawing.Size(230, 22);
            this.useAboveTaskbar.Text = "Center window above taskbar";
            // 
            // savedWindowSelector
            // 
            this.savedWindowSelector.FormattingEnabled = true;
            this.savedWindowSelector.Location = new System.Drawing.Point(12, 30);
            this.savedWindowSelector.Name = "savedWindowSelector";
            this.savedWindowSelector.Size = new System.Drawing.Size(256, 21);
            this.savedWindowSelector.TabIndex = 0;
            this.savedWindowSelector.Text = "Type or select a window by title...";
            this.savedWindowSelector.DropDown += new System.EventHandler(this.ListSavedWindows);
            this.savedWindowSelector.SelectedIndexChanged += new System.EventHandler(this.LoadSavedWindow);
            // 
            // windowBottom
            // 
            this.windowBottom.AutoSize = true;
            this.windowBottom.Location = new System.Drawing.Point(282, 90);
            this.windowBottom.Name = "windowBottom";
            this.windowBottom.Size = new System.Drawing.Size(13, 13);
            this.windowBottom.TabIndex = 25;
            this.windowBottom.Text = "0";
            // 
            // windowRight
            // 
            this.windowRight.AutoSize = true;
            this.windowRight.Location = new System.Drawing.Point(282, 64);
            this.windowRight.Name = "windowRight";
            this.windowRight.Size = new System.Drawing.Size(13, 13);
            this.windowRight.TabIndex = 26;
            this.windowRight.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bottom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Right:";
            // 
            // windowHeight
            // 
            this.windowHeight.Location = new System.Drawing.Point(163, 88);
            this.windowHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.windowHeight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(60, 20);
            this.windowHeight.TabIndex = 6;
            this.windowHeight.ValueChanged += new System.EventHandler(this.OnSetPosition);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Height:";
            // 
            // windowWidth
            // 
            this.windowWidth.Location = new System.Drawing.Point(163, 62);
            this.windowWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.windowWidth.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(60, 20);
            this.windowWidth.TabIndex = 5;
            this.windowWidth.ValueChanged += new System.EventHandler(this.OnSetPosition);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Width:";
            // 
            // windowY
            // 
            this.windowY.Location = new System.Drawing.Point(35, 88);
            this.windowY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.windowY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.windowY.Name = "windowY";
            this.windowY.Size = new System.Drawing.Size(60, 20);
            this.windowY.TabIndex = 4;
            this.windowY.ValueChanged += new System.EventHandler(this.OnSetPosition);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Y:";
            // 
            // windowX
            // 
            this.windowX.Location = new System.Drawing.Point(35, 62);
            this.windowX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.windowX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.windowX.Name = "windowX";
            this.windowX.Size = new System.Drawing.Size(60, 20);
            this.windowX.TabIndex = 3;
            this.windowX.ValueChanged += new System.EventHandler(this.OnSetPosition);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "X:";
            // 
            // useCalibration
            // 
            this.useCalibration.AutoSize = true;
            this.useCalibration.Checked = true;
            this.useCalibration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCalibration.Location = new System.Drawing.Point(12, 118);
            this.useCalibration.Name = "useCalibration";
            this.useCalibration.Size = new System.Drawing.Size(288, 17);
            this.useCalibration.TabIndex = 7;
            this.useCalibration.Text = "Use -7 pixel calibration (useful for native window border)";
            this.useCalibration.UseVisualStyleBackColor = true;
            this.useCalibration.CheckedChanged += new System.EventHandler(this.OnToggleCalibrate);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(54, 142);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.OnRefreshClicked);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(134, 142);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(60, 23);
            this.btnCenter.TabIndex = 9;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.OnCenterClicked);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(214, 142);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(60, 23);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnSetPosition);
            // 
            // btnSaveWindow
            // 
            this.btnSaveWindow.Location = new System.Drawing.Point(272, 29);
            this.btnSaveWindow.Name = "btnSaveWindow";
            this.btnSaveWindow.Size = new System.Drawing.Size(23, 23);
            this.btnSaveWindow.TabIndex = 1;
            this.btnSaveWindow.Text = "+";
            this.btnSaveWindow.UseVisualStyleBackColor = true;
            this.btnSaveWindow.Click += new System.EventHandler(this.SaveCurrentWindow);
            // 
            // btnRemoveWindow
            // 
            this.btnRemoveWindow.Location = new System.Drawing.Point(297, 29);
            this.btnRemoveWindow.Name = "btnRemoveWindow";
            this.btnRemoveWindow.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveWindow.TabIndex = 2;
            this.btnRemoveWindow.Text = "-";
            this.btnRemoveWindow.UseVisualStyleBackColor = true;
            this.btnRemoveWindow.Click += new System.EventHandler(this.RemoveCurrentWindow);
            // 
            // appsizerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 175);
            this.Controls.Add(this.btnRemoveWindow);
            this.Controls.Add(this.btnSaveWindow);
            this.Controls.Add(this.useCalibration);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.windowBottom);
            this.Controls.Add(this.windowRight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.windowHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.windowWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.windowY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.windowX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savedWindowSelector);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "appsizerGUI";
            this.Text = "appsizerGUI";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox savedWindowSelector;
        private System.Windows.Forms.Label windowBottom;
        private System.Windows.Forms.Label windowRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown windowHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown windowWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown windowY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown windowX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem useAboveTaskbar;
        private System.Windows.Forms.ToolStripMenuItem menuWindowSelect;
        private System.Windows.Forms.CheckBox useCalibration;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSaveWindow;
        private System.Windows.Forms.Button btnRemoveWindow;
    }
}
