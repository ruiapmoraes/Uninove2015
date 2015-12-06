using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace UninoveAcademiaSistemas.Util
{
    public class Conexao
    {

        //ConnectionStringSettingsCollection configuracao = ConfigurationManager.ConnectionStrings;
        //return ConfigurationManager.ConnectionStrings[""].ConnectionString;
        

        public static string ObterConexao()
        {
            //return ConfigurationManager.ConnectionStrings["UninoveAcademiaDB"].ConnectionString;
            //return ConfigurationManager.ConnectionStrings["AcademiaUninoveConnectionString"].ConnectionString;
            try
            {
                //string strConn = @"Server=ARSENAL-GEAR4\SQLEXPRESS2;Database=AcademiaUninove;Trusted_Connection=True";
                string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=AcademiaUninove;Integrated Security=SSPI";
                //string strConn = @"Provider=sqloledb;Data Source=LOCALHOST\SQLEXPRESS2;Initial Catalog=AcademiaUninove;Integrated Security=SSPI;";

                //return ConfigurationManager.ConnectionStrings["UninoveAcademiaConn"].ConnectionString;

                //return ConfigurationManager.ConnectionStrings["UninoveAcademiaConn"].ConnectionString;
                return strConn;

                //return ConfigurationSettings.AppSettings["UninoveAcademiaConn"];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
