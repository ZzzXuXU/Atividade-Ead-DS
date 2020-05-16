using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Pizza;
using DTO_Trident;





namespace BLL_chuchu
{
    public class BLL_Login
    {
        public bool ValidarLogin(DTO_Login objLogin) 
        {
            if(string.IsNullOrWhiteSpace(objLogin.Usuario))

            {
                throw new Exception("Por favor digitar e-mail e usuario");
            }
            if (string.IsNullOrWhiteSpace(objLogin.Senha))
            {
                throw new Exception("por favor digitar senha");

            }
            Conexao.Conectar();
            return true;
            
        }
    }
}
