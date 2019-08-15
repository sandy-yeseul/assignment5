using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Yeseul Kang #301029474
 * Created on August 13
 * Splash page
 */
namespace assignment5.Views
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
            FillBlank();


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ProductFile = new OpenFileDialog();
            ProductFile.FileName = "Product.txt";
            ProductFile.InitialDirectory = Directory.GetCurrentDirectory();
            ProductFile.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductFile.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open the  streawm for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductFile.FileName, FileMode.Open)))
                    {
                        List<string> listOfData = new List<string>();
                        // read from the file
                        for (int i=0; i<31; i++)
                        {
                            listOfData.Add(inputStream.ReadLine());
                        }
                        Program.dataList = listOfData;
                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                    
                }
                catch (IOException exception)
                {

                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ProductFile = new SaveFileDialog();
            // configure the file dialog
            ProductFile.FileName = "Product.txt";
            ProductFile.InitialDirectory = Directory.GetCurrentDirectory();
            ProductFile.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductFile.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductFile.FileName, FileMode.Create)))
                {
                    List<string> ListOfData = Program.dataList;
                    // write content - string type - to the file
                    foreach (string item in ListOfData)
                    {
                        outputStream.WriteLine(item);
                    }

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void FillBlank()
        {
            if (Program.dataList != null)
            {
                ProductIdDataTextBox.Text = Program.dataList[0];
                ModelTextBox.Text = Program.dataList[3];
                ManufacTextBox.Text = Program.dataList[2];
                CostDataTextBox.Text = Program.dataList[1];
                PlatformTextBox.Text = Program.dataList[16];
                CondtionTextBox.Text = Program.dataList[14];
                OSTextBox.Text = Program.dataList[15];
                LCDTextBox.Text = Program.dataList[7];
                DisplayTypeTextBox.Text = Program.dataList[6];
                CpuClassTextBox.Text = Program.dataList[9];
                CpuBrandTextBox.Text = Program.dataList[10];
                CpuTypeTextLabel.Text = Program.dataList[11];
                CpuSpeedTextBox.Text = Program.dataList[12];
                CpuNumberTextBox.Text = Program.dataList[13];
                LamTypeTextBox.Text = Program.dataList[4];
                LamSizeTextBox.Text = Program.dataList[5];
                HddSizeTextBox.Text = Program.dataList[17];
                HddSpeedTextBox.Text = Program.dataList[18];
                GpuTypeTextBox.Text = Program.dataList[19];
                ResolutionTextBox.Text = Program.dataList[8];
                WebCamTextBox.Text = Program.dataList[30];
            }
        }
    }
}
