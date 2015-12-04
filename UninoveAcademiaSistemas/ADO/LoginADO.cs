using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UninoveAcademiaSistemas.Queries;
using UninoveAcademiaSistemas.Util;

namespace UninoveAcademiaSistemas.ADO
{
    public class LoginADO
    {
        /// <summary>
        /// Verifica o Login no banco de dados.
        /// </summary>
        /// <param name="usuario">Usuário</param>
        /// <param name="senha">Senha</param>
        /// <returns>Devolver o resultado da consulta do usuário no banco de dados</returns>
        public bool VerificaLoginADO(string usuario, string senha)
        {
            bool resultado = false;
            string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHubUninove\2SEM_2015\UninoveAcademia\UninoveAcademia\AcademiaUninove.mdf;Integrated Security=True;Connect Timeout=30";
            //string stringConn = Conexao.ObterConexao();
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = null;
            string query = string.Format(Queries.SistemaQueries.qLogin, usuario, senha);


            conn.ConnectionString = stringConn;
                

                try
                {
                //SqlCommand cmd = new SqlCommand("select usuario, senha from Login Where usuario = '" + usuario +
                //    "' and senha = '" + senha + "'", conn);
                SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0 && dt != null)
                    resultado = true;
                
                }
                catch (Exception)
                {

                    throw;
                }
            
            return resultado;
        }
    }
}
