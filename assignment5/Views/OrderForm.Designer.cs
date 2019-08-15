namespace assignment5.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComputerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.CostGroupBox = new System.Windows.Forms.GroupBox();
            this.LaptopPictureBox = new System.Windows.Forms.PictureBox();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ManufacLabel = new System.Windows.Forms.Label();
            this.ManufacTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CondtionTextBox = new System.Windows.Forms.TextBox();
            this.SpecsTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.DisplayTypeLabel = new System.Windows.Forms.Label();
            this.CpuClassLabel = new System.Windows.Forms.Label();
            this.CpuBrandLabel = new System.Windows.Forms.Label();
            this.HddSpeedLabel = new System.Windows.Forms.Label();
            this.ScreenSizeLabel = new System.Windows.Forms.Label();
            this.CpuTypeLabel = new System.Windows.Forms.Label();
            this.CpuSpeedLabel = new System.Windows.Forms.Label();
            this.CpuNumber = new System.Windows.Forms.Label();
            this.LamTypeLabel = new System.Windows.Forms.Label();
            this.LamSizeLabel = new System.Windows.Forms.Label();
            this.HddSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderMenuStrip.SuspendLayout();
            this.ComputerInfoGroupBox.SuspendLayout();
            this.CostGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BackToolStripMenuItem.Text = "&Back";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ComputerInfoGroupBox
            // 
            this.ComputerInfoGroupBox.Controls.Add(this.CondtionTextBox);
            this.ComputerInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ComputerInfoGroupBox.Controls.Add(this.ManufacTextBox);
            this.ComputerInfoGroupBox.Controls.Add(this.ConditionLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.label1);
            this.ComputerInfoGroupBox.Controls.Add(this.SpecsTextBox);
            this.ComputerInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ComputerInfoGroupBox.Controls.Add(this.ScreenSizeLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.HddSpeedLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.HddSizeLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.LamSizeLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.LamTypeLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.CpuNumber);
            this.ComputerInfoGroupBox.Controls.Add(this.CpuSpeedLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.CpuTypeLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.CpuBrandLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.CpuClassLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.DisplayTypeLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.OSLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.ManufacLabel);
            this.ComputerInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ComputerInfoGroupBox.Location = new System.Drawing.Point(13, 28);
            this.ComputerInfoGroupBox.Name = "ComputerInfoGroupBox";
            this.ComputerInfoGroupBox.Size = new System.Drawing.Size(412, 521);
            this.ComputerInfoGroupBox.TabIndex = 1;
            this.ComputerInfoGroupBox.TabStop = false;
            this.ComputerInfoGroupBox.Text = "System Components";
            // 
            // CostGroupBox
            // 
            this.CostGroupBox.Controls.Add(this.TotalPriceLabel);
            this.CostGroupBox.Controls.Add(this.TaxLabel);
            this.CostGroupBox.Controls.Add(this.PriceLabel);
            this.CostGroupBox.Controls.Add(this.TotalPriceTextBox);
            this.CostGroupBox.Controls.Add(this.TaxTextBox);
            this.CostGroupBox.Controls.Add(this.PriceTextBox);
            this.CostGroupBox.Location = new System.Drawing.Point(431, 300);
            this.CostGroupBox.Name = "CostGroupBox";
            this.CostGroupBox.Size = new System.Drawing.Size(341, 200);
            this.CostGroupBox.TabIndex = 1;
            this.CostGroupBox.TabStop = false;
            this.CostGroupBox.Text = "Your Price";
            // 
            // LaptopPictureBox
            // 
            this.LaptopPictureBox.Image = global::assignment5.Properties.Resources.laptop;
            this.LaptopPictureBox.Location = new System.Drawing.Point(432, 28);
            this.LaptopPictureBox.Name = "LaptopPictureBox";
            this.LaptopPictureBox.Size = new System.Drawing.Size(340, 256);
            this.LaptopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LaptopPictureBox.TabIndex = 2;
            this.LaptopPictureBox.TabStop = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(7, 29);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 24);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(88, 26);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(100, 29);
            this.ModelTextBox.TabIndex = 1;
            // 
            // ManufacLabel
            // 
            this.ManufacLabel.AutoSize = true;
            this.ManufacLabel.Location = new System.Drawing.Point(194, 29);
            this.ManufacLabel.Name = "ManufacLabel";
            this.ManufacLabel.Size = new System.Drawing.Size(111, 24);
            this.ManufacLabel.TabIndex = 0;
            this.ManufacLabel.Text = "Manufactual";
            this.ManufacLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacTextBox
            // 
            this.ManufacTextBox.Location = new System.Drawing.Point(305, 26);
            this.ManufacTextBox.Name = "ManufacTextBox";
            this.ManufacTextBox.ReadOnly = true;
            this.ManufacTextBox.Size = new System.Drawing.Size(100, 29);
            this.ManufacTextBox.TabIndex = 1;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(7, 62);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(77, 24);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(88, 59);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 29);
            this.PlatformTextBox.TabIndex = 1;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(194, 62);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(90, 24);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CondtionTextBox
            // 
            this.CondtionTextBox.Location = new System.Drawing.Point(305, 59);
            this.CondtionTextBox.Name = "CondtionTextBox";
            this.CondtionTextBox.ReadOnly = true;
            this.CondtionTextBox.Size = new System.Drawing.Size(100, 29);
            this.CondtionTextBox.TabIndex = 1;
            // 
            // SpecsTextBox
            // 
            this.SpecsTextBox.Location = new System.Drawing.Point(122, 109);
            this.SpecsTextBox.Multiline = true;
            this.SpecsTextBox.Name = "SpecsTextBox";
            this.SpecsTextBox.ReadOnly = true;
            this.SpecsTextBox.Size = new System.Drawing.Size(283, 406);
            this.SpecsTextBox.TabIndex = 1;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(79, 145);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(37, 24);
            this.OSLabel.TabIndex = 0;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisplayTypeLabel
            // 
            this.DisplayTypeLabel.AutoSize = true;
            this.DisplayTypeLabel.Location = new System.Drawing.Point(44, 178);
            this.DisplayTypeLabel.Name = "DisplayTypeLabel";
            this.DisplayTypeLabel.Size = new System.Drawing.Size(70, 24);
            this.DisplayTypeLabel.TabIndex = 0;
            this.DisplayTypeLabel.Text = "Display";
            this.DisplayTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuClassLabel
            // 
            this.CpuClassLabel.AutoSize = true;
            this.CpuClassLabel.Location = new System.Drawing.Point(16, 211);
            this.CpuClassLabel.Name = "CpuClassLabel";
            this.CpuClassLabel.Size = new System.Drawing.Size(98, 24);
            this.CpuClassLabel.TabIndex = 0;
            this.CpuClassLabel.Text = "CPU Class";
            this.CpuClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuBrandLabel
            // 
            this.CpuBrandLabel.AutoSize = true;
            this.CpuBrandLabel.Location = new System.Drawing.Point(13, 245);
            this.CpuBrandLabel.Name = "CpuBrandLabel";
            this.CpuBrandLabel.Size = new System.Drawing.Size(103, 24);
            this.CpuBrandLabel.TabIndex = 0;
            this.CpuBrandLabel.Text = "CPU Brand";
            this.CpuBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HddSpeedLabel
            // 
            this.HddSpeedLabel.AutoSize = true;
            this.HddSpeedLabel.Location = new System.Drawing.Point(5, 482);
            this.HddSpeedLabel.Name = "HddSpeedLabel";
            this.HddSpeedLabel.Size = new System.Drawing.Size(111, 24);
            this.HddSpeedLabel.TabIndex = 0;
            this.HddSpeedLabel.Text = "HDD Speed";
            this.HddSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScreenSizeLabel
            // 
            this.ScreenSizeLabel.AutoSize = true;
            this.ScreenSizeLabel.Location = new System.Drawing.Point(43, 112);
            this.ScreenSizeLabel.Name = "ScreenSizeLabel";
            this.ScreenSizeLabel.Size = new System.Drawing.Size(71, 24);
            this.ScreenSizeLabel.TabIndex = 0;
            this.ScreenSizeLabel.Text = "Screen";
            this.ScreenSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuTypeLabel
            // 
            this.CpuTypeLabel.AutoSize = true;
            this.CpuTypeLabel.Location = new System.Drawing.Point(18, 283);
            this.CpuTypeLabel.Name = "CpuTypeLabel";
            this.CpuTypeLabel.Size = new System.Drawing.Size(96, 24);
            this.CpuTypeLabel.TabIndex = 0;
            this.CpuTypeLabel.Text = "CPU Type";
            this.CpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuSpeedLabel
            // 
            this.CpuSpeedLabel.AutoSize = true;
            this.CpuSpeedLabel.Location = new System.Drawing.Point(7, 312);
            this.CpuSpeedLabel.Name = "CpuSpeedLabel";
            this.CpuSpeedLabel.Size = new System.Drawing.Size(109, 24);
            this.CpuSpeedLabel.TabIndex = 0;
            this.CpuSpeedLabel.Text = "CPU Speed";
            this.CpuSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuNumber
            // 
            this.CpuNumber.AutoSize = true;
            this.CpuNumber.Location = new System.Drawing.Point(51, 346);
            this.CpuNumber.Name = "CpuNumber";
            this.CpuNumber.Size = new System.Drawing.Size(63, 24);
            this.CpuNumber.TabIndex = 0;
            this.CpuNumber.Text = "CPU #";
            this.CpuNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LamTypeLabel
            // 
            this.LamTypeLabel.AutoSize = true;
            this.LamTypeLabel.Location = new System.Drawing.Point(17, 381);
            this.LamTypeLabel.Name = "LamTypeLabel";
            this.LamTypeLabel.Size = new System.Drawing.Size(97, 24);
            this.LamTypeLabel.TabIndex = 0;
            this.LamTypeLabel.Text = "LAM Type";
            this.LamTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LamSizeLabel
            // 
            this.LamSizeLabel.AutoSize = true;
            this.LamSizeLabel.Location = new System.Drawing.Point(24, 414);
            this.LamSizeLabel.Name = "LamSizeLabel";
            this.LamSizeLabel.Size = new System.Drawing.Size(90, 24);
            this.LamSizeLabel.TabIndex = 0;
            this.LamSizeLabel.Text = "LAM Size";
            this.LamSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HddSizeLabel
            // 
            this.HddSizeLabel.AutoSize = true;
            this.HddSizeLabel.Location = new System.Drawing.Point(23, 448);
            this.HddSizeLabel.Name = "HddSizeLabel";
            this.HddSizeLabel.Size = new System.Drawing.Size(91, 24);
            this.HddSizeLabel.TabIndex = 0;
            this.HddSizeLabel.Text = "HDD Size";
            this.HddSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Few details has been displayed due to the area limitation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(19, 43);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(53, 24);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(19, 94);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(145, 24);
            this.TaxLabel.TabIndex = 0;
            this.TaxLabel.Text = "Sales Tax (13%)";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(18, 160);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(115, 26);
            this.TotalPriceLabel.TabIndex = 0;
            this.TotalPriceLabel.Text = "Total Price";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(235, 40);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(100, 29);
            this.PriceTextBox.TabIndex = 1;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(235, 91);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 29);
            this.TaxTextBox.TabIndex = 1;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(234, 159);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.ReadOnly = true;
            this.TotalPriceTextBox.Size = new System.Drawing.Size(100, 29);
            this.TotalPriceTextBox.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(432, 510);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 32);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(572, 510);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 32);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(689, 510);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(83, 33);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LaptopPictureBox);
            this.Controls.Add(this.CostGroupBox);
            this.Controls.Add(this.ComputerInfoGroupBox);
            this.Controls.Add(this.OrderMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.ComputerInfoGroupBox.ResumeLayout(false);
            this.ComputerInfoGroupBox.PerformLayout();
            this.CostGroupBox.ResumeLayout(false);
            this.CostGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox ComputerInfoGroupBox;
        private System.Windows.Forms.GroupBox CostGroupBox;
        private System.Windows.Forms.PictureBox LaptopPictureBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox CondtionTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ManufacTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox SpecsTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ScreenSizeLabel;
        private System.Windows.Forms.Label HddSpeedLabel;
        private System.Windows.Forms.Label HddSizeLabel;
        private System.Windows.Forms.Label LamSizeLabel;
        private System.Windows.Forms.Label LamTypeLabel;
        private System.Windows.Forms.Label CpuNumber;
        private System.Windows.Forms.Label CpuSpeedLabel;
        private System.Windows.Forms.Label CpuTypeLabel;
        private System.Windows.Forms.Label CpuBrandLabel;
        private System.Windows.Forms.Label CpuClassLabel;
        private System.Windows.Forms.Label DisplayTypeLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
    }
}