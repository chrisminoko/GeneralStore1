using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore
{
    public enum FoodTypes
    {
      Perishable,
      NonPerishable
    }
   public  class Food : Product
    
    {
    public FoodTypes FoodType { get; set; }


        public Food()
        {

        }

        public Food(string productid, string productname, double sellingprice, DateTime purchaseddate, int quantity,FoodTypes foodtype) :base(productid,productname,sellingprice, purchaseddate, quantity)
        {
            FoodType = foodtype;
        }


    }
}
