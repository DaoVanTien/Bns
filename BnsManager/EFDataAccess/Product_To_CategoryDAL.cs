using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class Product_To_CategoryDAL
    {
        public int Insert(tblProduct_To_Category productToCategory)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.tblProduct_To_Category.Add(productToCategory);
                db.SaveChanges();
                return productToCategory.ID;
            }
            catch (Exception ex)
            {
                db.Dispose();
                return 0;
            }
        }
    }
}
