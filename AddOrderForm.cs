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
    public partial class AddOrderForm : Form
    {
        private readonly OrderRepository _orderRepository;
        private readonly OrderDetailRepository _orderDetailRepository;

        public AddOrderForm()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                OrderID = int.Parse(txtOrderID.Text),
                OrderDate = dtpOrderDate.Value,
                AgentID = int.Parse(txtAgentID.Text)
            };

            _orderRepository.AddOrder(order);

            OrderDetail orderDetail = new OrderDetail
            {
                ID = int.Parse(txtOrderDetailID.Text),
                OrderID = order.OrderID,
                ItemID = int.Parse(txtItemID.Text),
                Quantity = int.Parse(txtQuantity.Text),
                UnitAmount = decimal.Parse(txtUnitAmount.Text)
            };

            _orderDetailRepository.AddOrderDetail(orderDetail);

            MessageBox.Show("Order and Order Detail added successfully!");
            this.Close();
        }

        private void dtpOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
