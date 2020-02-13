using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchasedDate { get; set; }
        public Product()
        {

        }

        public Product(string productid,string productname,double sellingprice,DateTime purchaseddate, int quantity)
        {
            ProductName = productid;
            ProductName = productname;
            SellingPrice = sellingprice;
            Quantity = quantity;
        }
    }
}
