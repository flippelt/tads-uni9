using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAtividade01
{
    public partial class frmAtividade01 : Form
    {
        public frmAtividade01()
        {
            InitializeComponent();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Int32.Parse(txtValor1.Text);
            b = Int32.Parse(txtValor2.Text);

            soma = a + b;

            MessageBox.Show("Total Somado: " + soma);

            lblValorFinal.Text = soma.ToString();
        }

        private void BtnDobro_Click(object sender, EventArgs e)
        {
            int a, dobro;

            a = Int32.Parse(txtValor1.Text);

            dobro = a * 2;

            MessageBox.Show("Dobro do Primeiro Valor: " + dobro);

            lblValorFinal.Text = dobro.ToString();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            int a, b, multi;

            a = Int32.Parse(txtValor1.Text);
            b = Int32.Parse(txtValor2.Text);

            multi = a * b;

            lblValorFinal.Text = multi.ToString();
        }

    }
}
