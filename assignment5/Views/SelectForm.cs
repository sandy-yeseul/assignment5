using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
/*
 * Yeseul Kang #301029474
 * Created on August 13
 * Select Form
 */
namespace assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            NextButton.Enabled = false;
            
        }

        

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentCell = ProductDataGridView.CurrentCell;
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var columnCOunt = ProductDataGridView.ColumnCount;
            var cells = currentRow.Cells;

            currentRow.Selected = true;
            string outputStirng = string.Empty;

            outputStirng = cells[2].Value + " " + cells[3].Value + " $" + cells[1].Value;
            SelectComputerTextBox.Text = outputStirng;
            NextButton.Enabled = true;

            Program.FormState.PreviousPage = this;
            for(int i = 0; i < columnCOunt; i++)
            {
                Program.dataList.Add(cells[i].Value.ToString());
            }
        }
        
    }
}
