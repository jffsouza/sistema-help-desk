using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using CamadaModelo;


namespace CamadaDados
{
    public class ctlFuncionario : ctlConexao
    {
        // Iniciar Sessão
        public OleDbDataReader IniciarSessao(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();

                ComandoDB = new OleDbCommand("select * from tb_Funcionario where Email = @Email and Senha = @Senha and Status = @Status", ConexaoDB);

                var pmtEmail = ComandoDB.CreateParameter();
                pmtEmail.ParameterName = "@Email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _funcionario.Email;
                ComandoDB.Parameters.Add(pmtEmail);

                var pmtSenha = ComandoDB.CreateParameter();
                pmtSenha.ParameterName = "@Senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _funcionario.Senha;
                ComandoDB.Parameters.Add(pmtSenha);

                var pmtStatus = ComandoDB.CreateParameter();
                pmtStatus.ParameterName = "@Status";
                pmtStatus.DbType = DbType.Boolean;
                pmtStatus.Value = _funcionario.Status;
                ComandoDB.Parameters.Add(pmtStatus);

                DataReaderDB = ComandoDB.ExecuteReader();
                return DataReaderDB;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // Mostrar Funcionário
        public DataTable MostrarUsuarios(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Funcionario where Status = @Status", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("Status", _funcionario.Status);
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

        // Cadastrar Funcionário
        public bool InserirFuncionario(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("insert into tb_Funcionario (Nome, Sobrenome, Email, Senha, Departamento, Status) values (@Nome, @Sobrenome, @Email, @Senha, @Departamento, @Status)", ConexaoDB);

                var pmtNome = ComandoDB.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _funcionario.Nome;
                ComandoDB.Parameters.Add(pmtNome);

                var pmtSobrenome = ComandoDB.CreateParameter();
                pmtSobrenome.ParameterName = "@Sobrenome";
                pmtSobrenome.DbType = DbType.String;
                pmtSobrenome.Value = _funcionario.Sobrenome;
                ComandoDB.Parameters.Add(pmtSobrenome);

                var pmtEmail = ComandoDB.CreateParameter();
                pmtEmail.ParameterName = "@Email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _funcionario.Email;
                ComandoDB.Parameters.Add(pmtEmail);

                var pmtSenha = ComandoDB.CreateParameter();
                pmtSenha.ParameterName = "@Senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _funcionario.Senha;
                ComandoDB.Parameters.Add(pmtSenha);

                var pmtDepartamento = ComandoDB.CreateParameter();
                pmtDepartamento.ParameterName = "@Departamento";
                pmtDepartamento.DbType = DbType.String;
                pmtDepartamento.Value = _funcionario.Departamento;
                ComandoDB.Parameters.Add(pmtDepartamento);

                var pmtStatus = ComandoDB.CreateParameter();
                pmtStatus.ParameterName = "@Status";
                pmtStatus.DbType = DbType.Boolean;
                pmtStatus.Value = _funcionario.Status;
                ComandoDB.Parameters.Add(pmtStatus);

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

        // Buscar Funcionário
        public DataTable ConsultarporEmail(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("select * from tb_Funcionario where Email = @Email", ConexaoDB);

                ComandoDB.Parameters.AddWithValue("@Email", _funcionario.Email);

                DataReaderDB = ComandoDB.ExecuteReader();
                DataTable dtFuncionario = new DataTable();
                dtFuncionario.Load(DataReaderDB);
                return dtFuncionario;
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

        // Editar Funcionário
        public bool EditarFuncionario(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();

                ComandoDB = new OleDbCommand("UPDATE tb_Funcionario SET [Nome] = @Nome, [Sobrenome] = @Sobrenome, [Email] = @Email, [Senha] = @Senha, [Departamento] = @Departamento WHERE ID = @ID", ConexaoDB);

                ComandoDB.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                ComandoDB.Parameters.AddWithValue("@Sobrenome", _funcionario.Sobrenome);
                ComandoDB.Parameters.AddWithValue("@Email", _funcionario.Email);
                ComandoDB.Parameters.AddWithValue("@Senha", _funcionario.Senha);
                ComandoDB.Parameters.AddWithValue("Departamento", _funcionario.Departamento);
                ComandoDB.Parameters.AddWithValue("@ID", _funcionario.ID);

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

        // Apagar Funcionário
        public bool ApagarFuncionario(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();
                ComandoDB = new OleDbCommand("DELETE FROM tb_Funcionario WHERE ID = @ID", ConexaoDB);
                ComandoDB.Parameters.AddWithValue("@ID", _funcionario.ID);

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

        // Desativar Funcionário
        public bool DesativarFuncionario(mdlFuncionario _funcionario)
        {
            try
            {
                AbrirConexao();

                ComandoDB = new OleDbCommand("UPDATE tb_Funcionario SET Status = @Status where ID = @ID", ConexaoDB);

                ComandoDB.Parameters.AddWithValue("@Status", _funcionario.Status);
                ComandoDB.Parameters.AddWithValue("@ID", _funcionario.ID);

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
