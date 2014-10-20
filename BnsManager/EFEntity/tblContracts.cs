using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblContracts
    {
        [Key]
        public int ID { get; set; }
        public int EmployeeID { get;set;}
        public int OrderID {get;set;}
        public string ContractID {get;set;}
        public string ContractName {get;set;}
    }
}
