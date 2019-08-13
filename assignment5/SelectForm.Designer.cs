namespace assignment5
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.HardwareSelectionLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectComputerLabel = new System.Windows.Forms.Label();
            this.SelectComputerTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HardwareSelectionLabel
            // 
            this.HardwareSelectionLabel.AutoSize = true;
            this.HardwareSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwareSelectionLabel.Location = new System.Drawing.Point(12, 9);
            this.HardwareSelectionLabel.Name = "HardwareSelectionLabel";
            this.HardwareSelectionLabel.Size = new System.Drawing.Size(265, 24);
            this.HardwareSelectionLabel.TabIndex = 0;
            this.HardwareSelectionLabel.Text = "Dollar Computer Hardware LIst";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(756, 472);
            this.dataGridView1.TabIndex = 1;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(691, 514);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(81, 35);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectComputerLabel
            // 
            this.SelectComputerLabel.AutoSize = true;
            this.SelectComputerLabel.Location = new System.Drawing.Point(12, 517);
            this.SelectComputerLabel.Name = "SelectComputerLabel";
            this.SelectComputerLabel.Size = new System.Drawing.Size(117, 24);
            this.SelectComputerLabel.TabIndex = 3;
            this.SelectComputerLabel.Text = "Your choice:";
            // 
            // SelectComputerTextBox
            // 
            this.SelectComputerTextBox.Location = new System.Drawing.Point(135, 514);
            this.SelectComputerTextBox.Name = "SelectComputerTextBox";
            this.SelectComputerTextBox.ReadOnly = true;
            this.SelectComputerTextBox.Size = new System.Drawing.Size(354, 29);
            this.SelectComputerTextBox.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(604, 514);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(81, 35);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.SelectComputerTextBox);
            this.Controls.Add(this.SelectComputerLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HardwareSelectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HardwareSelectionLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label SelectComputerLabel;
        private System.Windows.Forms.TextBox SelectComputerTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}