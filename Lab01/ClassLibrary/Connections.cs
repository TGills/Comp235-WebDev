using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Connections
    {
        private static readonly string connectionString;

        static Connections()
        {
            connectionString = "Data Source=bisiisdev;Initial Catalog=dbMovies1;Persist Security Info=True;User ID=bisstudent;Password=bobby2013";


        }

        public static string ConnectionString()
        {
            return connectionString;
        }




    }
}
