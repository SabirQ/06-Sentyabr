using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Threading.Tasks;
namespace FileTask_06_09.Models
{
internal class OrderDetail

{
public Int32 OrderID { get; set; }
public Int32 ProductID { get; set; }
public Decimal UnitPrice { get; set; }
public Int16 Quantity { get; set; }
public Single Discount { get; set; }
}
}
