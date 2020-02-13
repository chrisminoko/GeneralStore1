using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
    public enum PaymentTypes 
    {
        Cash ,
        Card,
        Portal
    }
    public class Payments
    {
        public string PaymentsID { get; set; }
        public string customerID { get; set; }
        public PaymentTypes PaymentTypes { get; set; }
        public double PaymentAmount { get; set; }

        public Payments()
        {
        }
        public Payments(string payementsid,string customerid,PaymentTypes paymenttype,Customer customer,Product product)
        {
            PaymentsID = payementsid;
            customerID = customerid;
            PaymentTypes = paymenttype;
            product = new Product();
            customer = new Customer();
        }
    }
}
