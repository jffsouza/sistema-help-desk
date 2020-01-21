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
    public partial class frmConsultaUser : Form
    {
        public frmConsultaUser()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            mdlUser _user = new mdlUser();
            
            if (cbFiltro.Text == "Nome")
            {
                _user.Nome = txtFiltro.Text;
            }
            else if (cbFiltro.Text == "RG")
            {
                _user.RG = txtFiltro.Text;
            }
            else if (cbFiltro.Text == "CPF")
            {
                _user.CPF = txtFiltro.Text;
            }

            /*_user.CPF = txtFiltro.Text;
            _user.Nome = txtFiltro.Text;
            _user.RG = txtFiltro.Text;*/

            ctlUser _ctlUser = new ctlUser();

            dgUser.DataSource = _ctlUser.PesquisarUsuario(_user);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
