using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOsszeadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSzamolas_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBoxA.Text);
                var b = Convert.ToDouble(textBoxB.Text);
                var eredmeny = a + b;
                labelEredmeny.Text = Convert.ToString(eredmeny);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba, számot kell megadni", "Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
           
        }
    }
}
