using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcular_nota
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciando um objeto 
            frmCadastrarPessoa _frmcadastrapessoa = new frmCadastrarPessoa();
            // chama tela
            _frmcadastrapessoa.MdiParent = this;
            // Mostra tela
            _frmcadastrapessoa.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre _frmsobre = new frmSobre();
            _frmsobre.MdiParent = this;
            _frmsobre.Show();

        }

        private void consultarPessoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarPessoas _frmconsultarpessoas = new frmConsultarPessoas();
            _frmconsultarpessoas.MdiParent = this;
            _frmconsultarpessoas.Show();
        }
    }
}
