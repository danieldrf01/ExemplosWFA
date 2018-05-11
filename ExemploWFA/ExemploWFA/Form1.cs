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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá mundo");
            MessageBox.Show("A soma é: " + (2 + 2));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txtNome.Text;
            string sobrenomeDoUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + "" + sobrenomeDoUsuario);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            MessageBox.Show(String.Format("A média é: {0:n} " , media));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nota1 = 0;

            try{

                nota1 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("Nota 1 deve conter somente números reais");
                return;
                txtNota1.Focus();
            }

            double nota2 = 0;
            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch
            {
                MessageBox.Show("Nota 2 deve conter somente números reais");
                return;
                txtNota2.Focus();
                
            }

            double nota3 = 0;
            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);
            }
            catch
            {
                MessageBox.Show("Nota 3 deve conter somente números reais");
                return;
                txtNota3.Focus();
            }

            double nota4 = 0;
            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);
            }
            catch
            {
                MessageBox.Show("Nota 4 deve conter somente números reais");
                txtNota4.Focus();
                return;
            }


            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            string textao = string.Format(
                "Nota 1: {0}\r\nNota 2: {1}\r\nNota 3: {2}\r\nNota 4: {3}\r\nMédia: {4}",
                nota1, nota2, nota3, nota4, media);

            txtResultado.Text = textao;
            //MessageBox.Show(String.Format("A média é: {0:n} ", media));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Concatenar_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txtNome.Text;
            string sobrenomeDoUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + " " + sobrenomeDoUsuario);
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
                if (idade < 0)
                {
                    MessageBox.Show("Idade não pode ser menor que 0");
                    txtIdade.Focus();
                    return;
                }

                if (idade > 150)
                {
                    MessageBox.Show("Idade não pode ser maior que 150");
                    txtIdade.Focus();
                    return;
                }
                
            }
            catch
            {
                MessageBox.Show("Idade deve conter somente números inteiros");
                txtIdade.Focus();
            }
        }
    }
}
