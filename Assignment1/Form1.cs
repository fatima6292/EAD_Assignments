using System.Collections;
using System.Diagnostics.SymbolStore;
using System.Net.NetworkInformation;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        ArrayList books;
        public Form1()
        {
            this.books = new ArrayList();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fName.Text == "" && lName.Text == "" && string.IsNullOrEmpty(comboBox1.Text))
            {
                label6.Text = "Fill All Field.";
                label6.Visible = true;
            }
            else
            {
                label5.Text = fName.Text + " " + lName.Text;
                label5.Visible = true;
                string sub = comboBox1.SelectedItem != null ? this.comboBox1.SelectedItem.ToString() : "";

                if (checkBox1.Checked)
                {
                    if (books.Contains(sub))
                    {
                        label6.Text = "${book} has already been added.";
                        label6.Visible = true;
                    }
                    else
                    {
                        books.Add(sub);
                        listBox1.Items.Add(sub);
                    }
                }
                else
                {
                    label6.Text = "Check the checkbox.";
                    label6.Visible = true;
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}