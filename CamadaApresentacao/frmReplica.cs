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
    public partial class frmReplica : Form
    {

        // Movimentação da Janela.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        private void painelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Variaveis de instância
        public string replica;
        
        // Inicialização dos Componentes
        public frmReplica()
        {
            InitializeComponent();
        }

        // Botão Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Botão OK - Confirma a finalização do chamado
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtReplica.Text == "")
            {
                lblAviso.Visible = true;
                lblAvisoMensagem.Visible = true;
            }
            else
            {
                lblAviso.Visible = false;
                lblAvisoMensagem.Visible = false;
                replica = txtReplica.Text;
                Dispose();
            }
        }    
    }
}
