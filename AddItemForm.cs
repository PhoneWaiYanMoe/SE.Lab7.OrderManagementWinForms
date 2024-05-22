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
    public partial class AddItemForm : Form
    {
        private readonly ItemRepository _itemRepository;

        public AddItemForm()
        {
            InitializeComponent();
            _itemRepository = new ItemRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                ItemID = int.Parse(txtItemID.Text),
                ItemName = txtItemName.Text,
                Size = txtSize.Text,
                Category = txtCategory.Text,
                Price = decimal.Parse(txtPrice.Text),
                StockQuantity = int.Parse(txtStockQuantity.Text),
                Supplier = txtSupplier.Text,
                Description = txtDescription.Text
            };

            _itemRepository.AddItem(item);
            MessageBox.Show("Item added successfully!");
            this.Close();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
