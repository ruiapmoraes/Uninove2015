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
       
            ConnectionStringSettingsCollection configuracao = ConfigurationManager.ConnectionStrings;
            //return ConfigurationManager.ConnectionStrings[""].ConnectionString;

            public static string ObterConexao()
            {
                return ConfigurationManager.ConnectionStrings["UninoveAcademiaDB"].ConnectionString;
                //return ConfigurationManager.ConnectionStrings["AcademiaUninoveConnectionString"].ConnectionString;
            }

        
    }
}
