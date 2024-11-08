using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101022_UTSPBO.App.Model
{
    internal class M_Admin
    {
        public string username { get; set; }
        public string password { get; set; }
        [Required]

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public LoginAkun(string username, string password)
        {
            this username = username;
            this password - password;
        }
    }
}
