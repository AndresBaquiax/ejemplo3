using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo3
{
    public partial class Form2 : Form
    {
        Cuenta cuenta = new Cuenta();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuenta.Dpi = textBoxDpi.Text;
            cuenta.NoCuenta = textBoxNoCuenta.Text;
            cuenta.Saldo = Convert.ToDouble(textBoxSaldo.Text);
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelNoCuenta.Text = cuenta.NoCuenta;
            labelDPI.Text = cuenta.Dpi;
            labelSaldo.Text = cuenta.Saldo.ToString();
        }
    }
}
