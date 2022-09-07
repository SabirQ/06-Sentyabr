using System.Data;
using System.Data.SqlClient;

//const string connection = "server=localhost;database=Northwind;trusted_connection=true;";
//SqlConnection con = new SqlConnection(connection);
//List<string> result = new List<string>();
//SqlCommand cmd = new SqlCommand("SELECT name FROM sys.Tables", con);
//if (con.State == System.Data.ConnectionState.Closed)
//    con.Open();
//SqlDataReader dr = cmd.ExecuteReader();
//while (dr.Read())
//{
//    result.Add(dr["name"].ToString());
//}

//dr.Close();
//foreach (var value in result)
//{
//    cmd = new SqlCommand($"select * from {value}", con);
//    dr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
//    dr.Read();

//    DataTable dt = dr.GetSchemaTable();


//    string className = string.Empty;
//    if (value.EndsWith("ies"))
//    {
//        className = value.Substring(0, value.Length - 3) + "y";
//    }
//    else if (value.EndsWith("s"))
//    {
//        className = value.Substring(0, value.Length - 1);
//    }
//    else
//    {
//        className = value;
//    }
//    List<string> str = new List<string>()
//    {
//        "using System;","using System.Collections.Generic;","using System.Linq;","using System.Text;" ," using System.Threading.Tasks;","namespace FileTask_06_09.Models\n{",$"internal class {className}\n","{"
//    };

//    foreach (DataRow row in dt.Rows)
//    { 
//        str.Add($"public {row[12].ToString().Substring(7, row[12].ToString().Length-7)} {row[0]}" + " { get; set; }");
//    }
//var path = Path.Combine(Directory.GetCurrentDirectory(), @$"..\..\..\Models\az.cs");
//Console.WriteLine(path);
//    str.Add("}\n}");
//    await File.WriteAllLinesAsync(path, str);
//    dr.Close();
//}

//con.Close();


