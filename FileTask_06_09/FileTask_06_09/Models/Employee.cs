using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Threading.Tasks;
namespace FileTask_06_09.Models
{
internal class Employee

{
public Int32 EmployeeID { get; set; }
public String LastName { get; set; }
public String FirstName { get; set; }
public String Title { get; set; }
public String TitleOfCourtesy { get; set; }
public DateTime BirthDate { get; set; }
public DateTime HireDate { get; set; }
public String Address { get; set; }
public String City { get; set; }
public String Region { get; set; }
public String PostalCode { get; set; }
public String Country { get; set; }
public String HomePhone { get; set; }
public String Extension { get; set; }
public Byte[] Photo { get; set; }
public String Notes { get; set; }
public Int32 ReportsTo { get; set; }
public String PhotoPath { get; set; }
}
}
