using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfm2
{
    public partial class AddPart : Form
    {
        public List<Part> parts = new List<Part>();
        public AddPart(int id)
        {
            InitializeComponent();
            numericUpDown1.Value = id + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save the part
            if (numericUpDown4.Value >= numericUpDown5.Value)
            {
                MessageBox.Show("You cannot have a min value greater than your max value.");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    parts.Add(new InHouse(
                        (int)numericUpDown1.Value,
                        textBox2.Text,
                        numericUpDown2.Value,
                        (int)numericUpDown3.Value,
                        (int)numericUpDown4.Value,
                        (int)numericUpDown5.Value,
                        textBox5.Text
                        ));
                }
                else
                {
                    parts.Add(new Outsourced(
                        (int)numericUpDown1.Value,
                        textBox2.Text,
                        numericUpDown2.Value,
                        (int)numericUpDown3.Value,
                        (int)numericUpDown4.Value,
                        (int)numericUpDown5.Value,
                        textBox5.Text
                        ));

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }


    }
}
