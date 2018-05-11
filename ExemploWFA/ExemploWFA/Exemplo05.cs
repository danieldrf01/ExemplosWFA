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
    public partial class Exemplo05 : Form
    {
        public Exemplo05()
        {
            InitializeComponent();
        }
       
            private void button1_Click_1(object sender, EventArgs e)
         {
             string texto = "";
             if (!cbLeu.AutoCheck)
             {
                 texto += "Você foi verdadeiro\n";
             }
             else
             {
                 texto += "Você acaba de vender seu tempo\n";
             }

             if (cbComprou.Checked)
             {
                 texto += "Parabens tem o 7zip open source\n";
             }
             else
             {
                 texto += "Vai comprar o Winrar menino(a) malandrinho(a)\n";
             }
             MessageBox.Show(texto);
         }

    }
}
    

