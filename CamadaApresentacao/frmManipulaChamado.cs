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

namespace help_desk
{
    public partial class frmManipulaChamado : Form
    {
        // Inicialização dos componentes
        public frmManipulaChamado()
        {
            InitializeComponent();
        }

        // Botão Criar Chamado
        private void btnCriarChamado_Click(object sender, EventArgs e)
        {
            ctlChamado _ctlchamado = new ctlChamado();
            mdlChamado _chamado = new mdlChamado();

            // Tratamento dos campos
            _chamado.Assunto = txtAssunto.Text;
            if (txtAssunto.Text == "")
            {
                lblAviso.Visible = true;
                lblAvisoAssunto.Visible = true;
            }
            else
            {
                lblAviso.Visible = false;
                lblAvisoAssunto.Visible = false;
            }
            _chamado.Usuario = Program.Email;
            _chamado.Departamento = Program.Departamento;
            _chamado.Categoria = cbTipo.Text;
            if (cbTipo.Text == "")
            {
                lblAviso.Visible = true;
                lblAvisoTipo.Visible = true;
            }
            else
            {
                lblAviso.Visible = false;
                lblAvisoTipo.Visible = false;
            }
            _chamado.Texto = txtMensagem.Text;
            if (txtMensagem.Text == "")
            {
                lblAviso.Visible = true;
                lblAvisoMensagem.Visible = true;
            }
            else
            {
                lblAviso.Visible = false;
                lblAvisoMensagem.Visible = false;
            }
            _chamado.DataHora = DateTime.Now.ToShortDateString();
            _chamado.Status = true;


            // Condição para criação do chamado
            if (txtAssunto.Text != "" && txtMensagem.Text != "" && cbTipo.Text != "")
            {
                bool retornoChamado = _ctlchamado.CriarChamado(_chamado);

                if (retornoChamado)
                {
                    MessageBox.Show("Chamado criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Erro ao criar chamado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botão Cancelar - Sair
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Botão Finalizar Chamado
        private void btnFinalizarChamado_Click(object sender, EventArgs e)
        {
            ctlChamado _ctlchamado = new ctlChamado();
            mdlChamado _chamado = new mdlChamado();
     
            frmReplica frmreplica = new frmReplica();
            AddOwnedForm(frmreplica);
            frmreplica.ShowDialog();

            _chamado.Status = false;
            _chamado.Replica = frmreplica.replica;
            _chamado.Protocolo = txtProtocolo.Text;

   
            bool retorno = _ctlchamado.FinalizarChamado(_chamado);

            if (retorno)
            {
                MessageBox.Show(string.Format("Chamado Nº:{0} finalizado com sucesso!", _chamado.Protocolo), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Falha ao finalizar Chamado!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Dispose();
        }

        // Botão Sair da Visualização
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
