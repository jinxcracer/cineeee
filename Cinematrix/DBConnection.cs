using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematrix
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=Cinematrix;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            return con;
        }
    }
}
