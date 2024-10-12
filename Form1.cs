using System;
using System.Data;
namespace Inventory_Management_System
{
    public partial class Inventory : Form
    {
        DataTable inventory = new DataTable();
        public Inventory()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;

            categoryComboBox.SelectedIndex = -1;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string sku = skuTextBox.Text;
            string name = nameTextBox.Text;
            string price = priceTextBox.Text;
            string description = descriptionTextBox.Text;
            string quantity = QuantityTextBox.Text;

            string category = (string)categoryComboBox.SelectedItem;

            inventory.Rows.Add(sku, name, category, price, description, quantity);

            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[InventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void InventoryGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                QuantityTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                string itemLookFor = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryComboBox.SelectedIndex = categoryComboBox.Items.IndexOf(itemLookFor);
            }
            catch(Exception err) 
            {
                Console.WriteLine("There has been an error ; " + err);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            InventoryGridView.DataSource = inventory;
        }
    }
}
