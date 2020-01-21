using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using CamadaModelo;


namespace CamadaDados
{
    public class ctlDepartamento : ctlConexao
    {
        // Mostrar Departamento
        public DataTable MostrarDepartamento()
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Departamento", ConexaoDB);
                DataReaderDB = ComandoDB.ExecuteReader();
                DataTable dtDepto = new DataTable();
                dtDepto.Load(DataReaderDB);
                return dtDepto;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Inserir Departamento
        public bool InserirDepartamento(mdlDepartamento _departamento)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("insert into tb_Departamento (Nome) values (@Nome)", ConexaoDB);

                var pmtNome = ComandoDB.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _departamento.Nome;
                ComandoDB.Parameters.Add(pmtNome);

                if (ComandoDB.ExecuteNonQuery() > 0)
                {

                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        // Consultar Departamento
        public DataTable ConsultarDepartamento(mdlDepartamento _departamento)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Departamento where Nome = @Nome", ConexaoDB);

                ComandoDB.Parameters.AddWithValue("@Nome", _departamento.Nome);

                DataReaderDB = ComandoDB.ExecuteReader();
                DataTable dtDepto = new DataTable();
                dtDepto.Load(DataReaderDB);
                return dtDepto;


            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Editar Departamento
        public bool EditarDepartamento(mdlDepartamento _departamento)
        {
            try
            {
                AbrirConexao();

                ComandoDB = new OleDbCommand("UPDATE tb_Departamento SET Nome = @Nome WHERE ID = @ID", ConexaoDB);

                ComandoDB.Parameters.AddWithValue("@Nome", _departamento.Nome);
                ComandoDB.Parameters.AddWithValue("@ID", _departamento.ID);

                if (ComandoDB.ExecuteNonQuery() > 0)
                {

                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        // Apagar Departamento
        public bool ApagarDepartamento(mdlDepartamento _departamento)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("DELETE FROM tb_Departamento WHERE ID = @ID", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@ID", _departamento.ID);

                if (ComandoDB.ExecuteNonQuery() > 0)
                {

                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
        }
    }
}
