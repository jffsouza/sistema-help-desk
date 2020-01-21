using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace CamadaDados
{
    public class ctlConexao
    {
        // Atributos do banco de dados
        protected OleDbConnection ConexaoDB;
        protected OleDbCommand ComandoDB;
        protected OleDbDataReader DataReaderDB;
        
        // Método - Abrir Conexão
        protected void AbrirConexao()
        {
            try
            {
                ConexaoDB = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\INSERIR AQUI O CAMINHO DO BANCO DE DADOS!");
                ConexaoDB.Open();       
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 

        // Método - Fechar Conexão
        protected void FecharConexao()
        {
            try
            {
                ConexaoDB.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }   
    }  
}

