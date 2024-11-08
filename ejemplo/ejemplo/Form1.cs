using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Hello world");
            HelloWorld.Text = Uno();
        }
        private string Uno()
        {
            int uno = 1;
            string unoS = Convert.ToString(uno);
            return unoS;
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
