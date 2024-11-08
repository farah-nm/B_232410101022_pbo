using B_232410101022_UTSPBO.App.Core;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101022_UTSPBO.App.Context
{.n\ 
    internal class LoginContext : DatabaseWrapper
    {
        public FormLoginAdmin Validate(string username, string password)
        {
            LoginAkun loginAkun = null;
            string query = "SELECT * FROM akun WHERE username = @username AND psword = @password";
// Parameter untuk query
             NpgsqlParameter[] parameters =
             {
             new NpgsqlParameter("@username", username),
             new NpgsqlParameter("@password", password)
             };
            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))
                if (reader.Read())
                {
                    loginAkun = new LoginAkun(username, password);
                    loginAkun.Username = (string)reader["username"];
                    loginAkun.Password = (string)reader["psword"];
                };
            return loginAkun
        }
    }
}
