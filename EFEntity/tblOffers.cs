using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class tblOffers
    {
        [Key]
        public int ID {get;set;}
        public int EmployeeID { get; set; }
        public int RequestID {get;set;}
        public int OfferID	{get;set;}
        public string OfferName	{get;set;}
    }
}
