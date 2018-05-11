using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Exemplo03 : Form
    {
        private void rbSomar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSomar.Checked)
            {
                Somar();
            }
        }
        public void Somar()
        {
            int quantidade1 = Convert.ToInt32(nudQuantidade1.Value);
            double valor1 = Convert.ToDouble(mtbValor1.Text);

            int quantidade2 = Convert.ToInt32(nudQuantidade2.Text);
            double valor2 = Convert.ToDouble(mtbValor2.Text);

            int quantidade3 = Convert.ToInt32(nudQuantidade3.Text);
            double valor3 = Convert.ToDouble(mtbValor3.Text);

            double total = (quantidade1 * valor1) + (quantidade2 * valor2) + (quantidade3 * valor3);

            MessageBox.Show("Somar: +" + total);


        }
    }
}


