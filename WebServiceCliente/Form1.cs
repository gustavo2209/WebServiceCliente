using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServiceCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PalmaWs.WebServicePalma ws = new PalmaWs.WebServicePalma();

            string n = textBox1.Text.Trim();

            if (n.Length > 0)
            {
                string msg = ws.Saludo(n);
                textBox2.Text = msg;
            }
            else
            {
                MessageBox.Show("Ingrese su nombre");
            }
        }
    }
}
