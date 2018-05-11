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
    public partial class Exemplo04 : Form
    {
        public Exemplo04()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSim.Checked)
            {
                rbSim.ForeColor = Color.Green;
                rbNao.ForeColor = Color.Black;
                gbNomeDoJogo.Visible = true;
            }
            else
            {
                rbSim.ForeColor = Color.Black;
                rbNao.ForeColor = Color.Red;
                gbNomeDoJogo.Visible = false;
            }
        }
    }
}