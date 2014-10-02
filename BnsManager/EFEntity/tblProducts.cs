using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEntity
{
    public class tblProducts
    {
        [Key]
        public int ID {get;set;}
        public string ProductID	{get;set;}
        public string ProductName {get;set;}
        
        public string Model	{get;set;}
        public string SKU	{get;set;}
        public string UPC	{get;set;}
        public string EAN	{get;set;}
        public string JAN	{get;set;}
        public string ISBN {get;set;}
        public string MPN	{get;set;}
        public string Location {get;set;}
        public int Quantity {get;set;}
        public int Stock_status_id {get;set;}
        public string image {get;set;}
        public int manufacturer_id	{get;set;}
        public bool shipping {get;set;}
        public decimal price {get;set;}
        public int points {get;set;}
        public int tax_class_id {get;set;}
        public DateTime? date_available {get;set;}
        public decimal? weight { get; set; }
        public int weight_class_id	{get;set;}
        public decimal? length {get;set;}
        public decimal?  width	{get;set;}
        public decimal? height {get;set;}
        public int length_class_id {get;set;}
        public bool subtract {get;set;}
        public int  minimum	{get;set;}
        public int sort_order {get;set;}
        public bool status	{get;set;}
        public DateTime? date_added	{get;set;}
        public DateTime? date_modified {get;set;}
        public int viewed {get;set;}
    }
}
