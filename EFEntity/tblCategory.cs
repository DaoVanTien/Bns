using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEntity
{
    public class tblCategory
    {
        [Key]
        public int CategoryID	{get;set;}
        public string CategoryName { get; set; }
        public string image	{get;set;}
        public int parent_id {get;set;}
        public int sort_order {get;set;}
        public bool status {get;set;}
    }
}
