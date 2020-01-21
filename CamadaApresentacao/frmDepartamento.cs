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
    public partial class frmDepartamento : Form
    {
        // Variaveis de Instância
        private string IDDepartamento = null;
        private bool Editar = false;

        // Inicialização dos componentes
        public frmDepartamento()
        {
            InitializeComponent();
        }

        // Método LOAD
        private void frmCadastrarDepartamento_Load(object sender, EventArgs e)
        {
            {
                MostrarTabelaDepartamento();
            }
        }

        // Método para mostrar todos departamentos
        private void MostrarTabelaDepartamento()
        {
            ctlDepartamento _departamento = new ctlDepartamento();
            dgvDepartamento.DataSource = _departamento.MostrarDepartamento();
        }

        // Método Limpar txtBox
        private void LimparFormulario()
        {
            txtNome.Clear();
        }

        // Botão Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mdlDepartamento _departamento = new mdlDepartamento();
            ctlDepartamento _ctldepartamento = new ctlDepartamento();

            _departamento.Nome = txtNome.Text;

            dgvDepartamento.DataSource = _ctldepartamento.ConsultarDepartamento(_departamento);

            if (dgvDepartamento.Rows.Count == 1)
            {
                lblAviso.Visible = true;
                MostrarTabelaDepartamento();
            }
            else
            {
                lblAviso.Visible = false;
            }

            if (txtNome.Text == "")
            {
                lblAviso.Visible = false;
                MostrarTabelaDepartamento();
            }
        }

        // Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ctlDepartamento _ctldepartamento = new ctlDepartamento();

            mdlDepartamento _departamento = new mdlDepartamento();

            _departamento.Nome = txtNome.Text;
            

            if (Editar == false)
            {
                bool retorno1 = _ctldepartamento.InserirDepartamento(_departamento);

                if (retorno1)
                {
                    MessageBox.Show("Departamento criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Falha ao criar departamento", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Editar == true)
            {
                _departamento.ID = IDDepartamento;
                bool retorno2 = _ctldepartamento.EditarDepartamento(_departamento);


                if (retorno2)
                {
                    MessageBox.Show("Departamento alterado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Editar = false;
                }
                else
                {
                    MessageBox.Show("Departamento alterado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            MostrarTabelaDepartamento();
            LimparFormulario();
        }

        // Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamento.SelectedRows.Count > 0)
            {
                Editar = true;

                txtNome.Text = dgvDepartamento.CurrentRow.Cells["Nome"].Value.ToString();
                IDDepartamento = dgvDepartamento.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione um departamento para editar!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Botão Apagar
        private void btnApagar_Click1(object sender, EventArgs e)
        {
            if (dgvDepartamento.SelectedRows.Count > 0)
            {
                ctlDepartamento _ctldepartamento = new ctlDepartamento();
                mdlDepartamento _departamento = new mdlDepartamento();

                _departamento.ID = IDDepartamento;
                IDDepartamento = dgvDepartamento.CurrentRow.Cells["ID"].Value.ToString();
                _departamento.ID = IDDepartamento;

                bool retorno3 = _ctldepartamento.ApagarDepartamento(_departamento);

                if (retorno3)
                {
                    MessageBox.Show("Departamento removido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MostrarTabelaDepartamento();
                }
                else
                {
                    MessageBox.Show("Selecione um departamento para remover!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        
        // Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            {
                Dispose();
            }
        }
    }
}
