using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace bfm2;

public partial class Main : Form
{
    public Inventory inventory = new Inventory();

    public BindingList<Part> parts;
    public BindingList<Product> products;

    public Main()
    {
        InitializeComponent();

        this.parts = this.inventory.AllParts;
        this.products = this.inventory.Products;
    }

    private void Main_Shown(object sender, EventArgs e)
    {
        textBox1.Text = "Enter part name or ID";
        textBox2.Text = "Enter product name or ID";
        dataGridView1.AutoGenerateColumns = true;
        dataGridView2.AutoGenerateColumns = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.DataSource = parts;
        dataGridView2.DataSource = products;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //// functionality to display search results for parts
        string searchTerm = textBox1.Text;
        void reset()
        {
            textBox1.Text = "Please enter a part name or ID";
            dataGridView1.DataSource = parts;
        }
        ;
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        {
            row.Selected = false;
        }
        bool found = false;
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (Int32.TryParse(searchTerm, out _))
            {
                if (row.Cells[0].Value.ToString() == searchTerm.ToString())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
                ;
            }
            else
            {
                if (row.Cells[1].Value.ToString().ToLower() == searchTerm.ToString().ToLower())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
            }
        }
        if (found == false)
        {
            MessageBox.Show("No parts found!");
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        // set a variable equal to the text in the box
    }

    private void button2_Click(object sender, EventArgs e)
    {
        // Add a part
        AddPart addPart = new AddPart(inventory.AllParts.Last().PartID);
        if (addPart.ShowDialog() == DialogResult.OK)
        {
            inventory.addPart(addPart.parts[0]);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        // Modify a part
        for (int i = 0; i < inventory.AllParts.Count; i++)
        {
            if (inventory.AllParts[i].PartID == Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
            {
                ModifyPart modifyPart = new ModifyPart(inventory.AllParts[i]);
                if (modifyPart.ShowDialog() == DialogResult.OK)
                {
                    inventory.updatePart(inventory.AllParts[i].PartID, modifyPart.newParts[0]);
                }
            }
        }

    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            // Delete a part
            var chosenPartID = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString() ?? "0");
            bool deleted = false;
            for (int i = 0; i < inventory.AllParts.Count; i++)
            {
                Part? part = inventory.AllParts[i];
                if (part.PartID == chosenPartID)
                {
                    deleted = inventory.deletePart(inventory.AllParts.FirstOrDefault(p => p.PartID == chosenPartID));
                }
            }
            if (deleted)
            {
                MessageBox.Show("Part deleted!");
            }
            else
            {
                MessageBox.Show("Part not deleted.");
            }
        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        //// functionality to display search results for products
        string searchTerm = textBox2.Text;
        void reset()
        {
            textBox2.Text = "Please enter a product name or ID";
            dataGridView2.DataSource = products;
        }
        ;
        foreach (DataGridViewRow row in dataGridView2.SelectedRows)
        {
            row.Selected = false;
        }
        bool found = false;
        foreach (DataGridViewRow row in dataGridView2.Rows)
        {
            if (Int32.TryParse(searchTerm, out _))
            {
                if (row.Cells[0].Value.ToString() == searchTerm.ToString())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
                ;
            }
            else
            {
                if (row.Cells[1].Value.ToString().ToLower() == searchTerm.ToString().ToLower())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
            }
        }
        if (found == false)
        {
            MessageBox.Show("No products found!");
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        // Set variable equal to textbox for product
    }

    private void button7_Click(object sender, EventArgs e)
    {
        // Add a product
        AddProduct addProduct = new AddProduct(inventory.AllParts, inventory.Products.Last().ProductID);
        if (addProduct.ShowDialog() == DialogResult.OK)
        {
            inventory.addProduct(addProduct.products[0]);
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        int selectedID = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
        for (int i = 0; i < products.Count; i++)
        {
            if (inventory.Products[i].ProductID == selectedID)
            {
                ModifyProduct modifyProduct = new ModifyProduct(inventory.AllParts, inventory.Products[i], inventory);
                if (modifyProduct.ShowDialog() == DialogResult.OK)
                {
                    inventory.updateProduct(selectedID, modifyProduct.ThisProduct);
                }
            }
        }
        // Modify a product
    }

    private void button5_Click(object sender, EventArgs e)
    {
        // Delete a product
        if (dataGridView2.SelectedRows.Count > 0)
        {
            // Delete a part
            var chosenProductID = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString() ?? "0");
            bool deleted = false;
            for (int i = 0; i < inventory.Products.Count; i++)
            {
                Product product = inventory.Products[i];
                if (product.ProductID == chosenProductID)
                {
                    deleted = inventory.removeProduct(i);
                }
            }
            if (deleted)
            {
                MessageBox.Show("Product deleted!");
            }
            else
            {
                MessageBox.Show("Product not deleted.");
            }
        }
    }

    private void button9_Click(object sender, EventArgs e)
    {
        this.Close();
        System.Windows.Forms.Application.Exit();
    }
}
