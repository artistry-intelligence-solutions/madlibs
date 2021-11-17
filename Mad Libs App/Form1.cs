using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad_Libs_App
{
    public partial class MadLibs : Form
    {
        public MadLibs()
        {
            InitializeComponent(); 
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "add your adjective...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "add your adjective...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "add your adjective...")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "add your noun...";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "add your noun...")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "add your noun...";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "add your noun...")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "add your noun...";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "add your plural noun...")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "add your plural noun...";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.one = textBox1.Text;
            Globals.two = textBox2.Text;
            Globals.three = textBox3.Text;
            Globals.four = textBox4.Text;
            Globals.five = textBox5.Text;

            if (Globals.one != "add your adjective..." 
                && Globals.two != "add your adjective..." 
                && Globals.three != "add your noun..." 
                && Globals.four != "add your noun..." 
                && Globals.five != "add your plural noun...")
            {
                Form form2 = new Form2();
                form2.Show();
            } else
            {
                label1.Text = "nuh uh! naughty, naughty, naughty!";
            }
        }
    }

    public static class Globals
    {
        public static string one, two, three, four, five;
    }
}
