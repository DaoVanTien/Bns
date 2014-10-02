using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblEmployees
    {
        [Key]
        public int  ID	{get;set;}
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address {get;set;}
    }
}
