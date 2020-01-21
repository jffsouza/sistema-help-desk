using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelo;

namespace help_desk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Botão Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // Instânciando os dados no objeto Funcionário.
            mdlFuncionario _funcionario = new mdlFuncionario();

            // Entrada do Email
            _funcionario.Email = txtEmail.Text;
            if (txtEmail.Text == "")
            {
                lblAvisoEmail.Visible = true;
                lblAviso2.Visible = true;
            }
            else
            {
                lblAvisoEmail.Visible = false;
                lblAviso2.Visible = false;
            }

            // Entrada da Senha
            _funcionario.Senha = txtSenha.Text;
            if (txtSenha.Text == "")
            {
                lblAvisoSenha.Visible = true;
                lblAviso2.Visible = true;
            }
            else
            {
                lblAvisoSenha.Visible = false;
                lblAviso2.Visible = false;
            }

            ctlFuncionario _ctlfuncionario = new ctlFuncionario();

            _funcionario.Status = true;

            // Tratamento do retorno da pesquisa realizada no banco de dados.
            OleDbDataReader retornoAcesso = _ctlfuncionario.IniciarSessao(_funcionario);
            if (retornoAcesso.Read() == true)
            {
                this.Hide();
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                Program.Nome = retornoAcesso["Nome"].ToString();
                Program.Email = retornoAcesso["Email"].ToString();
                Program.Departamento = retornoAcesso["Departamento"].ToString();
               
                menuPrincipal.Show();
            }
            else
            {
                lblAviso.Visible = true;
            }
        }

        // Entrar ao pressionar a tecla enter.
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
