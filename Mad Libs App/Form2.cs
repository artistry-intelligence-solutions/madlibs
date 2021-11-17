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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            label1.Text = "Your matric vacation has been so " + Globals.one;
            label2.Text = "with your  " + Globals.two + " friends.";
            label3.Text = "Go to a place near a " + Globals.three;
            label4.Text = "or if that doesn't work, go to " + Globals.four;
            label5.Text = "and see if you can ride " + Globals.five;
        }
    }
}
