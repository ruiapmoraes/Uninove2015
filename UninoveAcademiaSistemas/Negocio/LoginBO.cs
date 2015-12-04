using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UninoveAcademiaSistemas.ADO;

namespace UninoveAcademiaSistemas.Negocio
{
    public class LoginBO
    {
        /// <summary>
        /// Verifica Login
        /// </summary>
        /// <param name="user">Usuário</param>
        /// <param name="pass">Senha</param>
        /// <returns>Returna se o usuário exista</returns>
        public bool VerificaLogin(string user, string pass) {
            LoginADO objLoginADO = new LoginADO();

            bool resultado = false;

            resultado = objLoginADO.VerificaLoginADO(user, pass);

            return resultado;
        }
    }
}
