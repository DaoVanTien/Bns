using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEntity
{
    public class tblProduct_To_Category
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
    }
}
