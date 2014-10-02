using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{

    public class tblRequestMap
    {
        [Key]
        public int ID { set; get; }
        public string CustomerName { set; get; }
        public string ProductName { set; get; }
        public string RequestID { set; get; }
        public string RequestName { set; get; }
    }
}
