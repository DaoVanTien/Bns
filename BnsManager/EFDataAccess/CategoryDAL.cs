using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;

namespace EFDataAccess
{
    public class CategoryDAL
    {
        public List<tblCategory> ListCategoryAll()
        {
            DBConnect db = new DBConnect();
            List<tblCategory> ListCategory = new List<tblCategory>();
            try
            {
                var category = (from c in db.tblCategory
                                select c).ToList();
                foreach (var c in category)
                {
                    tblCategory cate = new tblCategory();
                    cate.CategoryID = c.CategoryID;
                    cate.CategoryName = c.CategoryName;
                    ListCategory.Add(cate);
                }
                db.Dispose();
            }
            catch (Exception ex)
            {
                db.Dispose();
            }
            return ListCategory;
        }
    }
}
