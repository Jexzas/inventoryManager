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
    public partial class ModifyPart : Form
    {
        public List<Part> newParts = new List<Part>();
        public List<Part> modifying = new List<Part>();

        public ModifyPart(Part supplied)
        {
            InitializeComponent();
            this.modifying.Add(supplied);
            numericUpDown1.Value = supplied.PartID;
            textBox2.Text = supplied.PartName;
            numericUpDown2.Value = supplied.InStock;
            numericUpDown3.Value = supplied.Price;
            numericUpDown4.Value = supplied.Min;
            numericUpDown5.Value = supplied.Max;
            textBox5.Text = supplied.where;
            if (supplied.Source == "inhouse")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
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
            // save
            if (numericUpDown4.Value >= numericUpDown5.Value)
            {
                MessageBox.Show("You cannot have a min value greater than your max value.");
            }
            if (radioButton1.Checked)
            {
                newParts.Add(new InHouse(
                    (int)numericUpDown1.Value,
                    textBox2.Text,
                    numericUpDown2.Value,
                    (int)numericUpDown3.Value,
                    (int)numericUpDown4.Value,
                    (int)numericUpDown5.Value,
                    textBox5.Text
                    ));
            } else
            {
                newParts.Add(new Outsourced(
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
