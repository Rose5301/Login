using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastraSe_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.CadastreSe(txbLogin.Text, txbTelefone.Text, txbSenha.Text, txbConfirmar.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        
            BemVindo Irpratela = new BemVindo();
            Irpratela.ShowDialog();
        }

        private void txbConfirmar_TextChanged(object sender, EventArgs e)
        {

       
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.CadastreSe(txbLogin.Text, txbTelefone.Text, txbSenha.Text, txbConfirmar.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
