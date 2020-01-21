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
    public partial class frmFuncionario : Form
    {

        // Variaveis de instância
        private string IDFuncionario = null;
        private bool Editar = false;

        // Inicialização dos componentes
        public frmFuncionario()
        {
            InitializeComponent();
        }

        // Método LOAD
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            MostrarTabelaUsuarios();
            CarregarComboBoxDepto();
        }

        // Método para mostrar todos usuários
        private void MostrarTabelaUsuarios()
        {
            ctlFuncionario _ctlfuncionario = new ctlFuncionario();
            mdlFuncionario _funcionario = new mdlFuncionario();
            _funcionario.Status = true;
            dgvUsuarios.DataSource= _ctlfuncionario.MostrarUsuarios(_funcionario);
            dgvUsuarios.Columns["Status"].Visible = false;
        }

        // Método Limpar txtBox
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        // Carregar ComboBox com os Departamentos
        private void CarregarComboBoxDepto()
        {
            ctlDepartamento _departamento = new ctlDepartamento();
            cbDepartamento.ValueMember = "ID";
            cbDepartamento.DisplayMember = "Nome";
            cbDepartamento.DataSource = _departamento.MostrarDepartamento();
        }
        
        // Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ctlFuncionario _ctlfuncionario = new ctlFuncionario();

            mdlFuncionario _funcionario = new mdlFuncionario();

            _funcionario.Nome = txtNome.Text;
            _funcionario.Sobrenome = txtSobrenome.Text;
            _funcionario.Email = txtEmail.Text;
            _funcionario.Senha = txtSenha.Text;
            _funcionario.Departamento = cbDepartamento.Text;
            _funcionario.Status = true;


            if (Editar == false)
            {
                bool retorno1 = _ctlfuncionario.InserirFuncionario(_funcionario);

                if (retorno1)
                {
                    MessageBox.Show(string.Format("Usuário: {0} {1} registrado com sucesso!", _funcionario.Nome, _funcionario.Sobrenome), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Falha ao registrar usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Editar == true)
            {
                _funcionario.ID = IDFuncionario;
                bool retorno2 = _ctlfuncionario.EditarFuncionario(_funcionario);


                if (retorno2)
                {
                    MessageBox.Show("Usuário alterado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Editar = false;
                }
                else
                {
                    MessageBox.Show("Falha ao alterar usuário!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MostrarTabelaUsuarios();
            LimparFormulario();           
        }

        // Botão buscar por Email
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mdlFuncionario _funcionario = new mdlFuncionario();
            ctlFuncionario _ctlfuncionario = new ctlFuncionario();

            _funcionario.Email = txtEmail.Text;

            dgvUsuarios.DataSource = _ctlfuncionario.ConsultarporEmail(_funcionario);

            if (dgvUsuarios.Rows.Count == 1)
            {
                lblAviso.Visible = true;
                MostrarTabelaUsuarios();
            }
            else
            {
                lblAviso.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                lblAviso.Visible = false;
                MostrarTabelaUsuarios();
            }
        }

        // Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count>0)
            {
                Editar = true;
                
                txtNome.Text = dgvUsuarios.CurrentRow.Cells["Nome"].Value.ToString();
                txtSobrenome.Text = dgvUsuarios.CurrentRow.Cells["Sobrenome"].Value.ToString();
                txtEmail.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                txtSenha.Text = dgvUsuarios.CurrentRow.Cells["Senha"].Value.ToString();
                cbDepartamento.Text = dgvUsuarios.CurrentRow.Cells["Departamento"].Value.ToString();
                IDFuncionario = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione um registro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Botão Apagar
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                ctlFuncionario _ctlfuncionario = new ctlFuncionario();
                mdlFuncionario _funcionario = new mdlFuncionario();

                _funcionario.ID = IDFuncionario;
                IDFuncionario = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                _funcionario.Email = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                _funcionario.ID = IDFuncionario;


                if (MessageBox.Show(string.Format ("Deseja realmente remover o usuário selecionado: {0}?", _funcionario.Email), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool retornoApagar = _ctlfuncionario.ApagarFuncionario(_funcionario);
                    MessageBox.Show("Usuário removido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MostrarTabelaUsuarios();
                }
            }
        }

        // Botão Desativar
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                ctlFuncionario _ctlfuncionario = new ctlFuncionario();
                mdlFuncionario _funcionario = new mdlFuncionario();

                _funcionario.ID = IDFuncionario;
                IDFuncionario = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                _funcionario.Email = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                _funcionario.ID = IDFuncionario;
                _funcionario.Status = false;


                if (MessageBox.Show(string.Format("Deseja realmente desativar o usuário selecionado: {0}?", _funcionario.Email), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool retornoDesativar = _ctlfuncionario.DesativarFuncionario(_funcionario);
                    MessageBox.Show("Usuário desativado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MostrarTabelaUsuarios();
                }
            }
        }

        // Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
