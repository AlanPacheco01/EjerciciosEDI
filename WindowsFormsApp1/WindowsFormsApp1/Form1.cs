using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form 
    {
        Valores numeros = new Valores();
        Metodos operaciones = new Metodos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Siete_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaCalculadora.Text = "7";
            
        }

        private void Suma_Click(object receiver, EventArgs e)
        {
            
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            Output.Text = "7";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PantallaCalculadora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
