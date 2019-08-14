namespace assignment5.Views
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.AnotherProductButon = new System.Windows.Forms.Button();
            this.ProductMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAnotherProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductIdDataTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionDataTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostDataTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacTextBox = new System.Windows.Forms.TextBox();
            this.ManufacLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.CpuBrandLabel = new System.Windows.Forms.Label();
            this.CpuTypeTextLabel = new System.Windows.Forms.TextBox();
            this.CpuTypeLabel = new System.Windows.Forms.Label();
            this.CpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CpuSpeedLabel = new System.Windows.Forms.Label();
            this.CpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.CpuNumberLabel = new System.Windows.Forms.Label();
            this.LCDTextBox = new System.Windows.Forms.TextBox();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.HddTextBox = new System.Windows.Forms.TextBox();
            this.HddLabel = new System.Windows.Forms.Label();
            this.GpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.GpuTypeLabel = new System.Windows.Forms.Label();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.ProductMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.textBox4);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(16, 117);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(756, 128);
            this.ProductInfoGroupBox.TabIndex = 1;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GpuTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GpuTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HddLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HddTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CpuNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CpuNumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CpuSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CpuSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CpuTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CpuTypeTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CpuBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CpuBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 276);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(760, 220);
            this.TechSpecsGroupBox.TabIndex = 1;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // AnotherProductButon
            // 
            this.AnotherProductButon.Location = new System.Drawing.Point(365, 514);
            this.AnotherProductButon.Name = "AnotherProductButon";
            this.AnotherProductButon.Size = new System.Drawing.Size(241, 35);
            this.AnotherProductButon.TabIndex = 0;
            this.AnotherProductButon.Text = "Select Another Product";
            this.AnotherProductButon.UseVisualStyleBackColor = true;
            // 
            // ProductMenuStrip
            // 
            this.ProductMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductMenuStrip.Name = "ProductMenuStrip";
            this.ProductMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.ProductMenuStrip.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAnotherProjectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // SelectAnotherProjectToolStripMenuItem
            // 
            this.SelectAnotherProjectToolStripMenuItem.Name = "SelectAnotherProjectToolStripMenuItem";
            this.SelectAnotherProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.SelectAnotherProjectToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.SelectAnotherProjectToolStripMenuItem.Text = "Select Another Project";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(40, 59);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(97, 24);
            this.ProductIdLabel.TabIndex = 1;
            this.ProductIdLabel.Text = "Product ID";
            // 
            // ProductIdDataTextBox
            // 
            this.ProductIdDataTextBox.Location = new System.Drawing.Point(143, 56);
            this.ProductIdDataTextBox.Name = "ProductIdDataTextBox";
            this.ProductIdDataTextBox.ReadOnly = true;
            this.ProductIdDataTextBox.Size = new System.Drawing.Size(86, 29);
            this.ProductIdDataTextBox.TabIndex = 3;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(266, 59);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(90, 24);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            // 
            // ConditionDataTextBox
            // 
            this.ConditionDataTextBox.Location = new System.Drawing.Point(362, 56);
            this.ConditionDataTextBox.Name = "ConditionDataTextBox";
            this.ConditionDataTextBox.ReadOnly = true;
            this.ConditionDataTextBox.Size = new System.Drawing.Size(86, 29);
            this.ConditionDataTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(515, 59);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(47, 24);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            // 
            // CostDataTextBox
            // 
            this.CostDataTextBox.Location = new System.Drawing.Point(568, 56);
            this.CostDataTextBox.Name = "CostDataTextBox";
            this.CostDataTextBox.ReadOnly = true;
            this.CostDataTextBox.Size = new System.Drawing.Size(198, 29);
            this.CostDataTextBox.TabIndex = 3;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(44, 37);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(77, 24);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(127, 34);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(86, 29);
            this.PlatformTextBox.TabIndex = 3;
            // 
            // ManufacTextBox
            // 
            this.ManufacTextBox.Location = new System.Drawing.Point(127, 83);
            this.ManufacTextBox.Name = "ManufacTextBox";
            this.ManufacTextBox.ReadOnly = true;
            this.ManufacTextBox.Size = new System.Drawing.Size(86, 29);
            this.ManufacTextBox.TabIndex = 3;
            // 
            // ManufacLabel
            // 
            this.ManufacLabel.AutoSize = true;
            this.ManufacLabel.Location = new System.Drawing.Point(1, 86);
            this.ManufacLabel.Name = "ManufacLabel";
            this.ManufacLabel.Size = new System.Drawing.Size(120, 24);
            this.ManufacLabel.TabIndex = 1;
            this.ManufacLabel.Text = "Manufacturer";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(346, 37);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(404, 29);
            this.OSTextBox.TabIndex = 3;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(303, 40);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(37, 24);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(346, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(404, 29);
            this.textBox4.TabIndex = 3;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(277, 86);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 24);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(131, 41);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(86, 29);
            this.MemoryTextBox.TabIndex = 3;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(46, 44);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(79, 24);
            this.MemoryLabel.TabIndex = 1;
            this.MemoryLabel.Text = "Memory";
            // 
            // CpuBrandTextBox
            // 
            this.CpuBrandTextBox.Location = new System.Drawing.Point(131, 105);
            this.CpuBrandTextBox.Name = "CpuBrandTextBox";
            this.CpuBrandTextBox.ReadOnly = true;
            this.CpuBrandTextBox.Size = new System.Drawing.Size(86, 29);
            this.CpuBrandTextBox.TabIndex = 3;
            // 
            // CpuBrandLabel
            // 
            this.CpuBrandLabel.AutoSize = true;
            this.CpuBrandLabel.Location = new System.Drawing.Point(22, 108);
            this.CpuBrandLabel.Name = "CpuBrandLabel";
            this.CpuBrandLabel.Size = new System.Drawing.Size(103, 24);
            this.CpuBrandLabel.TabIndex = 1;
            this.CpuBrandLabel.Text = "CPU Brand";
            // 
            // CpuTypeTextLabel
            // 
            this.CpuTypeTextLabel.Location = new System.Drawing.Point(131, 172);
            this.CpuTypeTextLabel.Name = "CpuTypeTextLabel";
            this.CpuTypeTextLabel.ReadOnly = true;
            this.CpuTypeTextLabel.Size = new System.Drawing.Size(86, 29);
            this.CpuTypeTextLabel.TabIndex = 3;
            // 
            // CpuTypeLabel
            // 
            this.CpuTypeLabel.AutoSize = true;
            this.CpuTypeLabel.Location = new System.Drawing.Point(29, 175);
            this.CpuTypeLabel.Name = "CpuTypeLabel";
            this.CpuTypeLabel.Size = new System.Drawing.Size(96, 24);
            this.CpuTypeLabel.TabIndex = 1;
            this.CpuTypeLabel.Text = "CPU Type";
            // 
            // CpuSpeedTextBox
            // 
            this.CpuSpeedTextBox.Location = new System.Drawing.Point(350, 172);
            this.CpuSpeedTextBox.Name = "CpuSpeedTextBox";
            this.CpuSpeedTextBox.ReadOnly = true;
            this.CpuSpeedTextBox.Size = new System.Drawing.Size(86, 29);
            this.CpuSpeedTextBox.TabIndex = 3;
            // 
            // CpuSpeedLabel
            // 
            this.CpuSpeedLabel.AutoSize = true;
            this.CpuSpeedLabel.Location = new System.Drawing.Point(235, 175);
            this.CpuSpeedLabel.Name = "CpuSpeedLabel";
            this.CpuSpeedLabel.Size = new System.Drawing.Size(109, 24);
            this.CpuSpeedLabel.TabIndex = 1;
            this.CpuSpeedLabel.Text = "CPU Speed";
            // 
            // CpuNumberTextBox
            // 
            this.CpuNumberTextBox.Location = new System.Drawing.Point(350, 105);
            this.CpuNumberTextBox.Name = "CpuNumberTextBox";
            this.CpuNumberTextBox.ReadOnly = true;
            this.CpuNumberTextBox.Size = new System.Drawing.Size(86, 29);
            this.CpuNumberTextBox.TabIndex = 3;
            // 
            // CpuNumberLabel
            // 
            this.CpuNumberLabel.AutoSize = true;
            this.CpuNumberLabel.Location = new System.Drawing.Point(222, 108);
            this.CpuNumberLabel.Name = "CpuNumberLabel";
            this.CpuNumberLabel.Size = new System.Drawing.Size(122, 24);
            this.CpuNumberLabel.TabIndex = 1;
            this.CpuNumberLabel.Text = "CPU Number";
            // 
            // LCDTextBox
            // 
            this.LCDTextBox.Location = new System.Drawing.Point(350, 41);
            this.LCDTextBox.Name = "LCDTextBox";
            this.LCDTextBox.ReadOnly = true;
            this.LCDTextBox.Size = new System.Drawing.Size(86, 29);
            this.LCDTextBox.TabIndex = 3;
            // 
            // LCDLabel
            // 
            this.LCDLabel.AutoSize = true;
            this.LCDLabel.Location = new System.Drawing.Point(260, 44);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(84, 24);
            this.LCDLabel.TabIndex = 1;
            this.LCDLabel.Text = "LCD size";
            // 
            // HddTextBox
            // 
            this.HddTextBox.Location = new System.Drawing.Point(556, 41);
            this.HddTextBox.Name = "HddTextBox";
            this.HddTextBox.ReadOnly = true;
            this.HddTextBox.Size = new System.Drawing.Size(198, 29);
            this.HddTextBox.TabIndex = 3;
            // 
            // HddLabel
            // 
            this.HddLabel.AutoSize = true;
            this.HddLabel.Location = new System.Drawing.Point(500, 44);
            this.HddLabel.Name = "HddLabel";
            this.HddLabel.Size = new System.Drawing.Size(50, 24);
            this.HddLabel.TabIndex = 1;
            this.HddLabel.Text = "HDD";
            // 
            // GpuTypeTextBox
            // 
            this.GpuTypeTextBox.Location = new System.Drawing.Point(556, 105);
            this.GpuTypeTextBox.Name = "GpuTypeTextBox";
            this.GpuTypeTextBox.ReadOnly = true;
            this.GpuTypeTextBox.Size = new System.Drawing.Size(198, 29);
            this.GpuTypeTextBox.TabIndex = 3;
            // 
            // GpuTypeLabel
            // 
            this.GpuTypeLabel.AutoSize = true;
            this.GpuTypeLabel.Location = new System.Drawing.Point(453, 108);
            this.GpuTypeLabel.Name = "GpuTypeLabel";
            this.GpuTypeLabel.Size = new System.Drawing.Size(97, 24);
            this.GpuTypeLabel.TabIndex = 1;
            this.GpuTypeLabel.Text = "GPU Type";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(556, 172);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(198, 29);
            this.WebCamTextBox.TabIndex = 3;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(461, 175);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(89, 24);
            this.WebCamLabel.TabIndex = 1;
            this.WebCamLabel.Text = "WebCam";
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(12, 514);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(303, 24);
            this.ConfirmLabel.TabIndex = 1;
            this.ConfirmLabel.Text = "Click Next to confirm your selection";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(612, 514);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 35);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(695, 514);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(77, 35);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CostDataTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AnotherProductButon);
            this.Controls.Add(this.ConditionDataTextBox);
            this.Controls.Add(this.ProductIdDataTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductMenuStrip);
            this.Controls.Add(this.ConfirmLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ProductMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ProductMenuStrip.ResumeLayout(false);
            this.ProductMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Button AnotherProductButon;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.MenuStrip ProductMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAnotherProjectToolStripMenuItem;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.TextBox ProductIdDataTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ConditionDataTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostDataTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label ManufacLabel;
        private System.Windows.Forms.TextBox ManufacTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label GpuTypeLabel;
        private System.Windows.Forms.TextBox GpuTypeTextBox;
        private System.Windows.Forms.Label HddLabel;
        private System.Windows.Forms.TextBox HddTextBox;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.TextBox LCDTextBox;
        private System.Windows.Forms.Label CpuNumberLabel;
        private System.Windows.Forms.TextBox CpuNumberTextBox;
        private System.Windows.Forms.Label CpuSpeedLabel;
        private System.Windows.Forms.TextBox CpuSpeedTextBox;
        private System.Windows.Forms.Label CpuTypeLabel;
        private System.Windows.Forms.TextBox CpuTypeTextLabel;
        private System.Windows.Forms.Label CpuBrandLabel;
        private System.Windows.Forms.TextBox CpuBrandTextBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}