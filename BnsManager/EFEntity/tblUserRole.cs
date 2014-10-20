using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblUserRole
    {
        [Key]
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }

    }
}
