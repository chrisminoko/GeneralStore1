using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Logic
{
   public class PaymentLogic
    {

        public List<Customer> GetCustomers;
        Payments Payments = new Payments();
        public PaymentLogic()
        {
            GetCustomers = new List<Customer>()
            {
                new Customer("CU101","Chris","47 Gillespie",1400,CustomerType.Bulk),
                new Customer("CU101","Chris","47 Gillespie",1400,CustomerType.Casual)
            };

        }


        public bool CheckPayment(Product product, Payments payments)
        {
            foreach (var customer in GetCustomers) 
            {
                if (customer.CustomerID==payments.customerID && customer.CustomerBalance>=payments.PaymentAmount)
                {
                    return true;
                }

            }
            return false;
        }


        public void makePayment()
        {
        
        
        }

    }
}
