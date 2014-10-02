using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDataAccess;
using EFEntity;

namespace EFBusiness
{
    public class ProductBLL
    {
        ProductDAL objProductBLL = new ProductDAL();
        // insert
        public int Insert(tblProducts product) 
        {
            return objProductBLL.Insert(product);
        }
        // get all
        public List<tblProducts> ListProductAll()
        {
            return objProductBLL.ListProductAll();

        }
        //get by id
        public tblProducts GetProductByID(int ID)
        {
            return objProductBLL.GetProductByID(ID);
        }
        //delete
        public bool Delete(int ID)
        {
            return objProductBLL.Delete(ID);
        }
        //update
        public bool Update(tblProducts pro)
        {
            return objProductBLL.Update(pro);
        }
    }
}
