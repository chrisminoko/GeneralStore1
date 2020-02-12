using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore
{
    public class ProductLogic
    {
        public List<Product> products { get; set; }
        public ProductLogic()
        {
            products = new List<Product>
            {
              new Food ("DK101","Chicken",15,new DateTime(2020,01,29),5,FoodTypes.Perishable),
              new Food ("DK102","Beef",10,new DateTime(2020,01,9),5,FoodTypes.Perishable),
              new Food ("DK101","Rice",15,new DateTime(2020,01,29),5,FoodTypes.NonPerishable)
             
            };

            
        }
        public void BuyProduct(string productid, string productName,int quantity,Product product,double sellingprice,DateTime purchaseddate)
        {
            foreach (var prouctIterm in products) 
            {
                if (product.ProductName.Equals(productName)) 
                {
                    product.ProductID = productid+1;
                    product.SellingPrice = sellingprice;
                    product.Quantity = quantity;
                    product.PurchasedDate = purchaseddate;

                }
            }
            products.Add(product);
        }

        public void UpdateSTock(int productQuanity, Product product) 
        {
            foreach (var productIterm in products)
            {
                if (product.ProductName.Equals(productIterm.ProductName)) 
                {

                    product.Quantity -= productQuanity;
                }
            }
        
        }
    }
}
