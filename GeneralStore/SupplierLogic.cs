using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore
{
   public class SupplierLogic
    {
        public List<Supplier> SupplierProducts { get; set; }

        public SupplierLogic()
        {
            SupplierProducts = new List<Supplier>()
            {
                new Supplier("SP101","",SupplierType.Drinks)                                                                                                                                                                                                                )
            };
        }
    }
}
