using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
      

    
        private void btnAddItem_Click_2(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Show();
        }

        private void btnAddAgent_Click_1(object sender, EventArgs e)
        {
            AddAgentForm addAgentForm = new AddAgentForm();
            addAgentForm.Show();
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.Show();
        }

        private void btnFilterData_Click_1(object sender, EventArgs e)
        {
            FilterItemsForm filterItemsForm = new FilterItemsForm();
            filterItemsForm.Show();
        }

        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            OrderReportForm orderReportForm = new OrderReportForm();
            orderReportForm.Show();
        }
    }
}
