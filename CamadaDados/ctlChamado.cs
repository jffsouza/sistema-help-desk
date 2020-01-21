using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using CamadaModelo;

namespace CamadaDados
{
    public class ctlChamado : ctlConexao
    {
        // Mostrar Chamados - ADM
        public DataTable MostrarChamados(mdlChamado _chamado)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Chamado where Status = @Status", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@Status", _chamado.Status);
                DataReaderDB = ComandoDB.ExecuteReader();
                DataTable dtUser = new DataTable();
                dtUser.Load(DataReaderDB);
                return dtUser;
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

        // Mostrar Chamados - Usuário Comum
        public DataTable MostrarChamadosComum(mdlChamado _chamado)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Chamado where Status = @Status and Departamento = @Departamento", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@Status", _chamado.Status);
                ComandoDB.Parameters.AddWithValue("@Departamento", _chamado.Departamento);
                DataReaderDB = ComandoDB.ExecuteReader();
                DataTable dtUser = new DataTable();
                dtUser.Load(DataReaderDB);
                return dtUser;
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

        // Cadastar Chamado
        public bool CriarChamado(mdlChamado _chamado)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("insert into tb_Chamado (Assunto, Usuario, Departamento, Categoria, Texto, " +
                "DataHora, Status) values (@Assunto, @Usuario, @Departamento, @Categoria, @Texto, @DataHora, @Status)", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@Assunto", _chamado.Assunto);
                ComandoDB.Parameters.AddWithValue("@Usuario", _chamado.Usuario);
                ComandoDB.Parameters.AddWithValue("@Departamento", _chamado.Departamento);
                ComandoDB.Parameters.AddWithValue("@Categoria", _chamado.Categoria);
                ComandoDB.Parameters.AddWithValue("@Texto", _chamado.Texto);
                ComandoDB.Parameters.AddWithValue("@DataHora", _chamado.DataHora);
                ComandoDB.Parameters.AddWithValue("@Status", _chamado.Status);

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

        // Consultar Chamado - ADM
        public DataTable ConsultarChamado(mdlChamado _chamado)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Chamado where Protocolo = @Protocolo and Status = @Status", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@Protocolo", _chamado.Protocolo);
                ComandoDB.Parameters.AddWithValue("@Status", _chamado.Status);
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

        // Consultar Chamado - Usuário Comum
        public DataTable ConsultarChamadoComum(mdlChamado _chamado)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Chamado where Protocolo = @Protocolo and Departamento = @Departamento and Status = @Status", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@Protocolo", _chamado.Protocolo);
                ComandoDB.Parameters.AddWithValue("@Departamento", _chamado.Departamento);
                ComandoDB.Parameters.AddWithValue("@Status", _chamado.Status);
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

        // Finalizar Chamado
        public bool FinalizarChamado(mdlChamado _chamado)
        {
            try
            {
                AbrirConexao();

                ComandoDB = new OleDbCommand("UPDATE tb_Chamado SET [Status] = @Status, [Replica] = @Replica WHERE Protocolo = @Protocolo", ConexaoDB);

                ComandoDB.Parameters.AddWithValue("@Status", _chamado.Status);
                ComandoDB.Parameters.AddWithValue("@Replica", _chamado.Replica); 
                ComandoDB.Parameters.AddWithValue("@Protocolo", _chamado.Protocolo);

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
    }
}
