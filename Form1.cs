using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_zad2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "Nike" && (radioButton1.Checked == true))
            {
                textBox1.Text = "Wybrałeś buty: Nike lifestyle";
            }
            else if (listBox1.SelectedItem == "Nike" && (radioButton2.Checked == true))
            {
                textBox1.Text = "Wybrałeś buty: Nike Running";
            }
            else if (listBox1.SelectedItem == "Adidas" && (radioButton2.Checked == true))
            {
                textBox1.Text = "Wybrałeś buty: Adidas Running";
            }
            else if (listBox1.SelectedItem == "Adidas" && (radioButton1.Checked == true))
            {
                textBox1.Text = "Wybrałeś buty: Adidas Lifestyle";
            }
            if (checkBox1.Checked == true)
                {
                textBox1.ForeColor = Color.Green;
            }else
            {
                textBox1.ForeColor = Color.Black;
            }

        }

        private void wybierz_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
