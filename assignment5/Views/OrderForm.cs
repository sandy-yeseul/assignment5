using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }
        /// <summary>
        /// This is event handler to creat printing message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is printing!");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is event hadler to close the form
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this is event handler to close the form when cancel button is clicked or the exit tool is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            string ThanksMessage = $"Thank you for purchasing our product. " +
                $"\n\nYour order will be processed in 7-10 business days";
            MessageBox.Show(ThanksMessage, "Thank You!",
                       MessageBoxButtons.OK, MessageBoxIcon.None);
            Application.Exit();
        }
        public void FillBlank()
        {
            ModelTextBox.Text = Program.dataList[3];
            ManufacTextBox.Text = Program.dataList[2];
            PlatformTextBox.Text = Program.dataList[16];
            CondtionTextBox.Text = Program.dataList[14];

            PriceTextBox.Text = Program.dataList[1];

            string Specs = Program.dataList[7]
                + $"\n" + Program.dataList[15]
                + $"\n" + Program.dataList[6]
                + $"\n" + Program.dataList[9]
                + $"\n" + Program.dataList[10]
                + $"\n" + Program.dataList[11]
                + $"\n" + Program.dataList[12]
                + $"\n" + Program.dataList[13]
                + $"\n" + Program.dataList[4]
                + $"\n" + Program.dataList[5]
                + $"\n" + Program.dataList[17]
                + $"\n" + Program.dataList[18];

            SpecsTextBox.Text = Specs;
        }
    }
}
