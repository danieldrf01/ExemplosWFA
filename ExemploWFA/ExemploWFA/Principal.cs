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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnExempl01_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnExemplo02_Click(object sender, EventArgs e)
        {
            Exemplo02 exemplo02 = new Exemplo02();
            exemplo02.Show();
        }

        private void btnExemplo03_Click(object sender, EventArgs e)
        {
            Exemplo03 exemplo03 = new Exemplo03();
            exemplo03.Show();
        }

        private void btnExemplo05_Click(object sender, EventArgs e)
        {
            Exemplo05 exemplo05 = new Exemplo05();
            exemplo05.Show();
        }

       

    }
}
