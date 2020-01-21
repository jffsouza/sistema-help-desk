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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSalatiel1DataSet.tb_Pessoa' table. You can move, or remove it, as needed.
            this.tb_PessoaTableAdapter.Fill(this.dbSalatiel1DataSet.tb_Pessoa);

        }
    }
}
