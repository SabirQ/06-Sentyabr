using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Threading.Tasks;
namespace FileTask_06_09.Models
{
internal class Product

{
public Int32 ProductID { get; set; }
public String ProductName { get; set; }
public Int32 SupplierID { get; set; }
public Int32 CategoryID { get; set; }
public String QuantityPerUnit { get; set; }
public Decimal UnitPrice { get; set; }
public Int16 UnitsInStock { get; set; }
public Int16 UnitsOnOrder { get; set; }
public Int16 ReorderLevel { get; set; }
public Boolean Discontinued { get; set; }
}
}
