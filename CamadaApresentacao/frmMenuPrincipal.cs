using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace help_desk
{
    public partial class frmMenuPrincipal : Form
    {
        private bool isCollapsed;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Métodos de Privilégios de Acesso

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            PrivilegioAcesso();
            UsuarioAtivo();
        }

        // Movimentação da Janela Principal.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        private void painelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Botão Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Botão Maximizar
        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        // Botão Restaurar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Normal;
            this.Size = new Size(1100, 580);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        // Botão Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Privilégios de Acesso
        private void PrivilegioAcesso()
        {
            if (Program.Departamento != "Administrador")
            {
                painelbtnAtualizacoes.Visible = false;
                btnAtualizacoes.Visible = false;
            }
        }

        // Usuario Ativo no momento.
        private void UsuarioAtivo()
        {
            lblNome.Text = Program.Nome;
            lblEmail.Text = Program.Email;
            lblDepartamento.Text = Program.Departamento;
        }

        // Botão Logoff
        private void picboxLogoff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Fazer Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frmlogin = new frmLogin();
                frmlogin.Show();
            }
        }

        // Abrir form no painel
        private void AbrirFormulario(object formulario)
        {
            if (this.painelFormulario.Controls.Count > 0)
                this.painelFormulario.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.painelFormulario.Controls.Add(fh);
            this.painelFormulario.Tag = fh;
            fh.Show();
        }

        // Botão Atualizações
        private void btnAtualizacoes_Click(object sender, EventArgs e)
        {
            timerbtnAtualizacoes.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                painelbtnAtualizacoes.Height += 10;
                if (painelbtnAtualizacoes.Size == painelbtnAtualizacoes.MaximumSize)
                {
                    timerbtnAtualizacoes.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                painelbtnAtualizacoes.Height -= 10;
                if (painelbtnAtualizacoes.Size == painelbtnAtualizacoes.MinimumSize)
                {
                    timerbtnAtualizacoes.Stop();
                    isCollapsed = true;
                }
            }
        }
            // btnAtualizações - Usuário
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFuncionario());
        
        }
            // btnAtualizações - Departamento
        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDepartamento());
        }

        // Botão Chamados
        private void btnChamados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmChamados());
        }
    }
}
