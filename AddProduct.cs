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
    public partial class AddProduct : Form
    {
        private BindingList<Part> availableParts = new BindingList<Part>();
        private BindingList<Part> chosenParts = new BindingList<Part>();
        public BindingList<Product> products = new BindingList<Product>();
        public AddProduct(BindingList<Part> parts, int last)
        {
            InitializeComponent();

            numericUpDown1.Value = last + 1;
            foreach (var part in parts)
            {
                availableParts.Add(part);
            }

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

                        chosenParts.Add(availableParts[i]);
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
                        chosenParts.Remove(chosenParts[i]);
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
                Product newProduct = new Product(
                    chosenParts,
                    (int)numericUpDown1.Value,
                    textBox1.Text,
                    (decimal)numericUpDown2.Value,
                    (int)numericUpDown3.Value,
                    (int)numericUpDown4.Value,
                    (int)numericUpDown5.Value
                    );
                products.Add(newProduct);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
