using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEntity
{
    public class tblRequests
    {
        [Key]
        public int ID {set; get;}
        public int CustomerID {set; get;}
        public int ProductID {set; get;}
        public string RequestID {set; get;}
        public string RequestName { set; get; }
    }
}
