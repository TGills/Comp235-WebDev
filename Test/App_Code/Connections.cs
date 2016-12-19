using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Connections
/// </summary>
public class Connections
{
    private static readonly string connectionString;

    static Connections()
    {
        connectionString = "Data Source=bisiisdev;Initial Catalog=dbEmp1;Persist Security Info=True;User ID=bisstudent;Password=bobby2013";
    }

    public static string ConnectionString()
    {
        return connectionString;
    }
}