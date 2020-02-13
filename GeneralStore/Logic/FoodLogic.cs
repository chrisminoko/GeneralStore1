using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore
{
   public class FoodLogic
    {

        public static List<Food> FoodList { get; set; }

        public FoodLogic()
        {
            FoodList = new List<Food>
            {
                new Food("RC101","Rice",100,new DateTime(2020,01,14),14,FoodTypes.NonPerishable),
                new Food("CH101","Rice",100,new DateTime(2020,02,11),14,FoodTypes.Perishable)

            };
        }

        public bool checkExpiryDate(string id )
        {
            foreach (var fooditerm in FoodList)
            {
              return (fooditerm.ProductID == id && fooditerm.PurchasedDate.AddDays(7) > DateTime.Now && fooditerm.FoodType == FoodTypes.Perishable) ? true : false;
            }
            return false;
        }

        public void ReduceFoodPrice()
        {
         
        
        }

       
    }
}
