using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class Employee
{

    public int employeeNumber;
    public int jobCode;
    public string firstName;
    public string lastName;

    public Employee() { }
    public Employee(int employeeNum, int jobcode, string firstname, string lastname)
    {
        employeeNumber = employeeNum;
        jobCode = jobcode;
        firstName = firstname;
        lastName = lastname;
    }

}