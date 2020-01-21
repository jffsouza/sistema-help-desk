using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calcular_nota
{
    public partial class frmConsultarPessoas : Form
    {
        public frmConsultarPessoas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string conexaoAcess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Jefferson\Stefani\Banco de Dados\dbSalatiel1.mdb";
            OleDbConnection conexaoDB = new OleDbConnection(conexaoAcess);
            conexaoDB.Open();

            string Query = "select * from tb_Pessoa";
            OleDbCommand cmd = new OleDbCommand(Query, conexaoDB);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable Pessoas = new DataTable();
            da.Fill(Pessoas);
            dtPessoas.DataSource = Pessoas;
        }
    }
}
