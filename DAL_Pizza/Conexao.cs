using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_Pizza
{
     public class Conexao
    {
        
       
            public static SqlConnection Conectar()

            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projeto_DS2020batata;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                    conn.Open();
                    return conn;

                }
                catch
                {
                    throw new Exception("não foi possivel concetar a o banco de dados");
                }
            }    
     }

    }
