using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class ProductDAL
    {
        // insert
        public int Insert(tblProducts product)
        {
            DBConnect db = new DBConnect();
            try 
	        {	        
		        db.tblProducts.Add(product);
                db.SaveChanges();
                db.Dispose();
                return product.ID;
	        }
	        catch (Exception ex)
	        {
                db.Dispose();
                return 0;
	        }
        }
        // List all product
        public List<tblProducts> ListProductAll()
        {
            DBConnect db = new DBConnect();
            List<tblProducts> ListProduct = new List<tblProducts>();
            try
            {
                var p = (from n in db.tblProducts
                               select n).ToList();
                foreach (var pro in p)
                { 
                    tblProducts product = new tblProducts();
                    product.ID = pro.ID;
                    product.ProductID = pro.ProductID;
                    product.ProductName = pro.ProductName;
                    product.Model = pro.Model;
                    product.SKU = pro.SKU;
                    product.UPC = pro.UPC;
                    product.EAN = pro.EAN;
                    product.JAN = pro.JAN;
                    product.ISBN = pro.ISBN;
                    product.MPN = pro.MPN;
                    product.Location = pro.Location;
                    product.Quantity = pro.Quantity;
                    product.Stock_status_id = pro.Stock_status_id;
                    product.image = pro.image;
                    product.manufacturer_id = pro.manufacturer_id;
                    product.shipping = pro.shipping;
                    product.price = pro.price;
                    product.points = pro.points;
                    product.tax_class_id = pro.tax_class_id;
                    product.date_available = pro.date_available;
                    product.weight = pro.weight;
                    product.weight_class_id = pro.weight_class_id;
                    product.length = pro.length;
                    product.width = pro.width;
                    product.height = pro.height;
                    product.length_class_id = pro.length_class_id;
                    product.subtract = pro.subtract;
                    product.minimum = pro.minimum;
                    product.sort_order = pro.sort_order;
                    product.status = pro.status;
                    product.date_added = product.date_added;
                    product.date_modified = pro.date_modified;
                    product.viewed  = pro.viewed;
                    ListProduct.Add(product);
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return ListProduct;
        }
        // get product by id
        public tblProducts GetProductByID(int ID)
        {
            DBConnect db = new DBConnect();
            return db.tblProducts.SingleOrDefault(p => p.ID == ID);
        }
        // delete
        public bool Delete(int ID)
        {
            DBConnect db = new DBConnect();
            try
            {
                var product = db.tblProducts.Find(ID);
                if (product != null)
                {
                    db.tblProducts.Remove(product);
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return false;
            }
        }
        //update
        public bool Update(tblProducts pro)
        {
            DBConnect db = new DBConnect();
            try
            {
                var product = db.tblProducts.Find(pro.ID);
                if (product != null)
                {
                    product.ProductID = pro.ProductID;
                    product.ProductName = pro.ProductName;
                    product.Model = pro.Model;
                    product.SKU = pro.SKU;
                    product.UPC = pro.UPC;
                    product.EAN = pro.EAN;
                    product.JAN = pro.JAN;
                    product.ISBN = pro.ISBN;
                    product.MPN = pro.MPN;
                    product.Location = pro.Location;
                    product.Quantity = pro.Quantity;
                    product.Stock_status_id = pro.Stock_status_id;
                    product.image = pro.image;
                    product.manufacturer_id = pro.manufacturer_id;
                    product.shipping = pro.shipping;
                    product.price = pro.price;
                    product.points = pro.points;
                    product.tax_class_id = pro.tax_class_id;
                    product.date_available = pro.date_available;
                    product.weight = pro.weight;
                    product.weight_class_id = pro.weight_class_id;
                    product.length = pro.length;
                    product.width = pro.width;
                    product.height = pro.height;
                    product.length_class_id = pro.length_class_id;
                    product.subtract = pro.subtract;
                    product.minimum = pro.minimum;
                    product.sort_order = pro.sort_order;
                    product.status = pro.status;
                    product.date_added = product.date_added;
                    product.date_modified = pro.date_modified;
                    product.viewed = pro.viewed;
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return false;
            }
        }

    }
}
