using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAtividade01_Posto
{
    public partial class frmPosto : Form
    {
        public frmPosto()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, total;

            a = Convert.ToDouble(txtLitros.Text);
            b = double.Parse(txtValLitros.Text);

            total = a * b;

            lblValorFinal.Text = "R$" + total.ToString();
        }
    }
}
