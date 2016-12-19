using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for employeeManager
/// </summary>
public class employeeManager
{
    public string connectionString;
    public employeeManager()
    {
        connectionString = Connections.ConnectionString();
    }


    public List<Employee> getEmployees()
    {
        List<Employee> Employees = new List<Employee>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = Connections.ConnectionString();
        SqlCommand cmd =
            new SqlCommand("Select EmployeeId, FirstName, LastName, JobCode From Employees");
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        while (reader.Read())
        {
            Employees.Add(new Employee(
                    Convert.ToInt32(reader["EmployeeId"]),
                    Convert.ToInt32(reader["JobCode"]),
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString()));
        }
        con.Close();
        return Employees;
    }
    public List<Employee> getEmployeesByJobCode(int jobCode)
    {
        List<Employee> Employees = new List<Employee>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = Connections.ConnectionString();
        SqlCommand cmd =
            new SqlCommand("Select * From Employees Where JobCode=@JobCode");
        cmd.Parameters.AddWithValue("JobCode", jobCode);
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        con.Close();
        return Employees;
    }
    public void employeeUpdate(Employee CategoryToUpdate)
    {
        SqlConnection con = new SqlConnection(Connections.ConnectionString());
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "UPDATE Employees SET  EmployeeId=@EmployeeId, FirstName=@FirstName, LastName=@LastName, JobCode=@JobCode WHERE EmployeeId=@EmployeeId";
        cmd.Parameters.AddWithValue("@EmployeeId", CategoryToUpdate.employeeNumber);
        cmd.Parameters.AddWithValue("@FirstName", CategoryToUpdate.firstName);
        cmd.Parameters.AddWithValue("@LastName", CategoryToUpdate.lastName);
        cmd.Parameters.AddWithValue("@JobCode", CategoryToUpdate.jobCode);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void insertEmployee(int jobCode, string firstName, string lastName)
    {
        SqlConnection con = new SqlConnection(Connections.ConnectionString());
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT INTO Employees(FirstName, LastName, JobCode) VALUES( @FirstName, @LastName , @JobCode)";
        cmd.Parameters.AddWithValue("FirstName", firstName);
        cmd.Parameters.AddWithValue("LastName", lastName);
        cmd.Parameters.AddWithValue("JobCode", jobCode);
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        con.Close();
    }
    public SqlDataReader getEmployeesNoList()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd =
            new SqlCommand("Select * From Employees");
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return reader;
    }
}