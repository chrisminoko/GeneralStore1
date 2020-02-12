using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore
{
    public enum SupplierType
    {
        Foods,
        Drinks,
        Games
    }

   public class Supplier
    {
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public SupplierType SupplierType { get; set; }
        public Product SupplierProducts;
        public Supplier()
        {
            SupplierProducts = new Product();
        }
        //this
        public Supplier(string supplierid ,string suppliername,SupplierType suppliertype)
        {
            SupplierID = supplierid;
            SupplierName = suppliername;
            SupplierType=suppliertype;
        }
    }
}
