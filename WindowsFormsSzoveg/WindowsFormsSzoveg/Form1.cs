using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSzoveg
{
    public partial class SzovegForm : Form
    {
        public SzovegForm()
        {
            InitializeComponent();
            labelHossz.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelHossz.Text = textBox1.Text.Length.ToString();
        }
    }
}
