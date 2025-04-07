using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfm2
{
    public partial class ModifyProduct : Form
    {
        private BindingList<Part> availableParts = new BindingList<Part>();
        private BindingList<Part> chosenParts = new BindingList<Part>();
        public Product ThisProduct;
        private Inventory ThisInventory { get; set; }
        public ModifyProduct(BindingList<Part> parts, Product product, Inventory inventory)
        {
            InitializeComponent();
            this.ThisProduct = product;
            this.chosenParts = product.AssociatedParts;
            this.ThisInventory = inventory;
            foreach (Part part in parts)
            {
                bool inChosed = false;
                foreach (Part chosed in chosenParts)
                {
                    if (part.PartID == chosed.PartID)
                    {
                        inChosed = true;
                    }
                }
                if (inChosed)
                {
                    continue;
                }
                else
                {
                    availableParts.Add(part);
                }
            }
            numericUpDown1.Value = product.ProductID;
            textBox1.Text = product.Name;
            numericUpDown2.Value = product.InStock;
            numericUpDown3.Value = product.Price;
            numericUpDown4.Value = product.Min;
            numericUpDown5.Value = product.Max;
        }

        private void AddProduct_Shown(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = availableParts;
            dataGridView2.DataSource = chosenParts;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add part to chosen
            if (availableParts.Count > 0)
            {
                for (int i = 0; i < availableParts.Count; i++)
                {
                    if (availableParts[i].PartID == Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                    {

                        ThisProduct.addAssociatedPart(availableParts[i]);
                        availableParts.Remove(availableParts[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("No parts to add.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete part from chosen
            if (chosenParts.Count > 0)
            {
                for (int i = 0; i < chosenParts.Count; i++)
                {
                    if (chosenParts[i].PartID == Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()))
                    {

                        availableParts.Add(chosenParts[i]);
                        ThisProduct.removeAssociatedPart(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("No parts to delete.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Save a product
            if (numericUpDown4.Value >= numericUpDown5.Value)
            {
                MessageBox.Show("You cannot have a min value greater than your max value.");
            }
            else
            {
                ThisProduct.Name = textBox1.Text;
                ThisProduct.Price = numericUpDown3.Value;
                ThisProduct.InStock = (int)numericUpDown2.Value;
                ThisProduct.Min = (int)numericUpDown4.Value;
                ThisProduct.Max = (int)numericUpDown5.Value;
                ThisInventory.updateProduct(ThisProduct.ProductID, ThisProduct);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// functionality to display search results for parts
            int searchTerm = (int)numericUpDown6.Value;
            void reset()
            {
                numericUpDown6.Value = 0;
                dataGridView2.DataSource = ThisProduct.AssociatedParts;
            };
            if (ThisProduct.AssociatedParts.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    row.Selected = false;
                }
            }
            bool found = false;
            try
            {
                ThisProduct.lookupAssociatedPart(searchTerm);
                if (ThisProduct.AssociatedParts.Count != 0)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        found = true;
                        if (row.Cells[0].Value.ToString() == searchTerm.ToString())
                        {
                            row.Selected = true;
                            found = true;
                            reset();
                        }
                        ;

                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("No associated parts!");
            }
            
            if (found == false)
            {
                MessageBox.Show("No parts found!");
            }
        }
    }
}
