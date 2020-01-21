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
    public partial class frmChamados : Form
    {
        // Inicialização dos componentes
        public frmChamados()
        {
            InitializeComponent();
        }

        // Método LOAD
        public void frmChamados_Load(object sender, EventArgs e)
        {
            PrivilegioAcesso();
        }

        // Privilégios
        private void PrivilegioAcesso()
        {
            if (Program.Departamento != "Administrador")
            {
                MostrarChamadosAbertosComum();
                MostrarChamadosFechadosComum();
            }
            else
            {
                MostrarChamadosAbertos();
                MostrarChamadosFechados();
            }
        }

        // Mostrar - Chamados abertos - ADM
        private void MostrarChamadosAbertos()
        {
            ctlChamado _ctlchamado = new ctlChamado();
            mdlChamado _chamado = new mdlChamado();
            _chamado.Status = true;
            dgvAberto.DataSource = _ctlchamado.MostrarChamados(_chamado);
            Aviso();
            dgvAberto.Columns[5].Visible = false;
            dgvAberto.Columns[7].Visible = false;
            dgvAberto.Columns[8].Visible = false;
            
        }

        // Mostrar - Chamados abertos - Usuário Comum
        private void MostrarChamadosAbertosComum()
        {
            ctlChamado _ctlchamado = new ctlChamado();
            mdlChamado _chamado = new mdlChamado();
            _chamado.Status = true;
            _chamado.Departamento = Program.Departamento;
            dgvAberto.DataSource = _ctlchamado.MostrarChamadosComum(_chamado);
            Aviso();
            dgvAberto.Columns[5].Visible = false;
            dgvAberto.Columns[7].Visible = false;
            dgvAberto.Columns[8].Visible = false;
        }

        // Mostrar - Chamados fechados - ADM
        private void MostrarChamadosFechados()
        {
            ctlChamado _ctlchamado = new ctlChamado();
            mdlChamado _chamado = new mdlChamado();
            _chamado.Status = false;
            _chamado.Departamento = Program.Departamento;
            dgvFechado.DataSource = _ctlchamado.MostrarChamados(_chamado);
            Aviso();
            dgvFechado.Columns[5].Visible = false;
            dgvFechado.Columns[7].Visible = false;
            dgvFechado.Columns[8].Visible = false;
        }

        // Mostrar - Chamados fechados - Usuário Comum
        private void MostrarChamadosFechadosComum()
        {
            ctlChamado _ctlchamado = new ctlChamado();
            mdlChamado _chamado = new mdlChamado();
            _chamado.Status = false;
            _chamado.Departamento = Program.Departamento;
            dgvFechado.DataSource = _ctlchamado.MostrarChamadosComum(_chamado);
            Aviso();
            dgvFechado.Columns[5].Visible = false;
            dgvFechado.Columns[7].Visible = false;
            dgvFechado.Columns[8].Visible = false;
        }
        
        // Aviso caso não exista chamados
        private void Aviso()
        {
            if (dgvAberto.Rows.Count == 1)
            {
                lblAvisoAberto.Visible = true;
            }
            else
            {
                lblAvisoAberto.Visible = false;
            }
            if (dgvFechado.Rows.Count == 1)
            {
                lblAvisoFechado.Visible = true;
            }
            else
            {
                lblAvisoFechado.Visible = false;
            }
        }

        // Botão Novo Chamado
        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            frmManipulaChamado frmnovochamado = new frmManipulaChamado();
            AddOwnedForm(frmnovochamado);
            frmnovochamado.TopLevel = false;
            frmnovochamado.Dock = DockStyle.Fill;
            this.Controls.Add(frmnovochamado);
            frmnovochamado.BringToFront();
            frmnovochamado.Show();
        }

        // Botão Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mdlChamado _chamado = new mdlChamado();
            ctlChamado _ctlchamado = new ctlChamado();

            _chamado.Protocolo = txtProtocolo.Text;
            _chamado.Departamento = Program.Departamento;

            if (Program.Departamento != "Administrador")
            {
                if (tabControl.SelectedTab == tabAberto)
                {
                    _chamado.Status = true;
                    dgvAberto.DataSource = _ctlchamado.ConsultarChamadoComum(_chamado);
                    if (dgvAberto.Rows.Count == 1)
                    {
                        lblAviso.Visible = true;
                        PrivilegioAcesso();
                    }
                    else
                    {
                        lblAviso.Visible = false;
                    }
                }
                else
                {
                    _chamado.Status = false;
                    dgvFechado.DataSource = _ctlchamado.ConsultarChamadoComum(_chamado);
                    if (dgvFechado.Rows.Count == 1)
                    {
                        lblAviso.Visible = true;
                        PrivilegioAcesso();
                    }
                    else
                    {
                        lblAviso.Visible = false;
                    }
                }     
            }
            else
            {
                if (tabControl.SelectedTab == tabAberto)
                {
                    _chamado.Status = true;
                    dgvAberto.DataSource = _ctlchamado.ConsultarChamado(_chamado);
                    if (dgvAberto.Rows.Count == 1)
                    {
                        lblAviso.Visible = true;
                        PrivilegioAcesso();
                    }
                    else
                    {
                        lblAviso.Visible = false;
                    }
                }
                else
                {
                    _chamado.Status = false;
                    dgvFechado.DataSource = _ctlchamado.ConsultarChamado(_chamado);
                    if (dgvFechado.Rows.Count == 1)
                    {
                        lblAviso.Visible = true;
                        PrivilegioAcesso();
                    }
                    else
                    {
                        lblAviso.Visible = false;
                    }
                }
            }
            if (txtProtocolo.Text == "")
            {
                lblAviso.Visible = false;
                PrivilegioAcesso();
            }
        }

        // Botão Visualizar Chamado
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabAberto)
            {
                frmManipulaChamado frmmanipulachamado = new frmManipulaChamado();

                if (dgvAberto.SelectedRows.Count > 0)
                {
                    AddOwnedForm(frmmanipulachamado);
                    frmmanipulachamado.TopLevel = false;
                    frmmanipulachamado.Dock = DockStyle.Fill;
                    this.Controls.Add(frmmanipulachamado);
                    frmmanipulachamado.BringToFront();
                    frmmanipulachamado.Show();
                    frmmanipulachamado.cbTipo.Text = dgvAberto.CurrentRow.Cells["Categoria"].Value.ToString();
                    frmmanipulachamado.cbTipo.Enabled = false;
                    frmmanipulachamado.txtAssunto.Text = dgvAberto.CurrentRow.Cells["Assunto"].Value.ToString();
                    frmmanipulachamado.txtAssunto.Enabled = false;
                    frmmanipulachamado.txtMensagem.Text = dgvAberto.CurrentRow.Cells["Texto"].Value.ToString();
                    frmmanipulachamado.txtMensagem.Enabled = false;
                    frmmanipulachamado.btnCriarChamado.Visible = false;
                    frmmanipulachamado.txtProtocolo.Text = dgvAberto.CurrentRow.Cells["Protocolo"].Value.ToString();

                    if (Program.Departamento != "Administrador")
                    {
                        frmmanipulachamado.btnSair.Visible = true;
                        frmmanipulachamado.btnCancelar.Visible = false;
                    }
                    else
                    {
                        frmmanipulachamado.btnFinalizarChamado.Visible = true;
                    }
                }
            }
            else
            {
                frmManipulaChamado frmmanipulachamado = new frmManipulaChamado();

                if (dgvFechado.SelectedRows.Count > 0)
                {
                    AddOwnedForm(frmmanipulachamado);
                    frmmanipulachamado.TopLevel = false;
                    frmmanipulachamado.Dock = DockStyle.Fill;
                    this.Controls.Add(frmmanipulachamado);
                    frmmanipulachamado.BringToFront();
                    frmmanipulachamado.Show();
                    frmmanipulachamado.cbTipo.Text = dgvFechado.CurrentRow.Cells["Categoria"].Value.ToString();
                    frmmanipulachamado.cbTipo.Enabled = false;
                    frmmanipulachamado.txtAssunto.Text = dgvFechado.CurrentRow.Cells["Assunto"].Value.ToString();
                    frmmanipulachamado.txtAssunto.Enabled = false;
                    frmmanipulachamado.txtMensagem.Text = dgvFechado.CurrentRow.Cells["Texto"].Value.ToString();
                    frmmanipulachamado.txtMensagem.Enabled = false;
                    frmmanipulachamado.btnCriarChamado.Visible = false;
                    frmmanipulachamado.btnSair.Visible = true;
                    frmmanipulachamado.btnCancelar.Visible = false;

                    frmReplica frmreplica = new frmReplica();
                    frmreplica.txtReplica.Text = dgvFechado.CurrentRow.Cells["Replica"].Value.ToString();
                    frmreplica.ShowDialog();
                    frmreplica.txtReplica.Enabled = false;
                }
            }
        }
        
        // Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
            {
                Dispose();
            }

        // Botão Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PrivilegioAcesso();
        }
    }
}
