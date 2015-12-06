using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UninoveAcademiaSistemas.Util;
using UninoveAcademiaSistemas.Queries;
using System.Data;
using System.Data.SqlClient;


namespace UninoveAcademiaSistemas.ADO
{
    public class CargoADO: ADOBase //Herdando da classe ADOBase
    {
        string conn = string.Empty;
        Conexao objConexao = new Conexao();

        

        private bool InsereCargo(int codigo, string cargo)
        {
            string query = string.Format(UninoveAcademiaSistemas.Queries.Create.SistemaQueriesInsert.qInsertCargo, codigo, cargo);
            //ADOBase objCon = new ADOBase();
            bool bRet = false;
            RealizaComandoSQL(query, "");
            return bRet;
        }

        public bool ConsultaCargo()
        {
            bool bRet = false;
            DataTable dtCargo = null;
            string query = UninoveAcademiaSistemas.Queries.Read.SistemasQueriesConsulta.qConsultaCargo;

            try
            {
                conn = Conexao.ObterConexao();
                dtCargo = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            //TODO ajustar o retorno do método
            return bRet;
        }
    }
}
