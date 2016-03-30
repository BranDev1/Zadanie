using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public int poc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToLower() == "arpanet")
            {
                poc++;
            }

            if (radioButton1.Checked)
            {
                poc++;
            }

            if (checkBox2.Checked && checkBox3.Checked)
            {
                poc++;
            }

            if (radioButton5.Checked)
            {
                poc++;
            }

            if(comboBox1.SelectedIndex==0)
            {
                poc++;
            }

            //if(dateTimePicker1.ToString())
            if(dateTimePicker1.Value.Day==1 && dateTimePicker1.Value.Month== 1 && dateTimePicker1.Value.Year == 1970)
            {
                poc++;
            }
            Console.Write(poc);
        }

    }
}
