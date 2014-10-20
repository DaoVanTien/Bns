using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblContractMap
    {
        [Key]
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string ContractID { get; set; }
        public string ContractName { get; set; }
    }
}
