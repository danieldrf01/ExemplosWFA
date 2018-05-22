using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_guarda_roupa
{
    public partial class ListaPeca : Form
    {
        public ListaPeca()
        {
            InitializeComponent();

        }

        private void AtualizarLista()
        {
            dgvListaPeca.Rows.Clear();

            for (int i = 0; i < Program.pecas.Count; i++)
            {
                Peca peca = Program.pecas[i];
                dgvListaPeca.Rows.Add(new object[]{
                peca.Nome, peca.Cor, peca.Marca, peca.Valor });
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroPeca().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            
            if (linhaSelecionada == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada");
                return;
            }

            int linhaSelecionada1 = dgvListaPeca.CurrentRow.Index;
            Peca peca = Program.pecas[linhaSelecionada];
            CadastroPeca cadastroPeca = new CadastroPeca(peca);

        }


        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
