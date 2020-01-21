using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelo;

namespace Calcular_nota
{
    public partial class frmCadastrarPessoa : Form
    {
        public frmCadastrarPessoa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ctlPessoa _ctlpessoa = new ctlPessoa();
            mdlPessoa _mdlpessoa = new mdlPessoa();
            _mdlpessoa.CPF = mskCPF.Text;
            _mdlpessoa.RG = mskRG.Text;
            _mdlpessoa.Nome = txtNome.Text;

            // bool retorno = _ctlpessoa.InserirPessoa(txtNome.Text, mskRG.Text, mskCPF.Text);
            
            bool retorno1 = _ctlpessoa.InserirPessoaMdl(_mdlpessoa);

            if (retorno1)
            {
                MessageBox.Show("Dados Gravados com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao gravar dados!");
            }
            

        }


     
        

    }
}
