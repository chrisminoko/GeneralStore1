using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
    public enum CustomerType
    {
    Bulk=20,
    Casual=100
    
    }
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public double CustomerBalance { get; set; }
        public CustomerType CustomerType { get; set; }
        public Product GetProducts;
        public Payments GetPayments;

        public Customer()
        {
            GetProducts = new Product();
            GetPayments = new Payments(); 
        }
        public Customer(string customerid,string customername, string address, double customerbalance, CustomerType customertype)
        {
            CustomerID = customerid;
            CustomerName = customername;
            Address = address;
            CustomerBalance = customerbalance;
            CustomerType = customertype;
        }

        
    }
}
