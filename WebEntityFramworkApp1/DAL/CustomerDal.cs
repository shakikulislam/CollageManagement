using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEntityFramworkApp1.DatabaseContext;
using WebEntityFramworkApp1.Models;

namespace WebEntityFramworkApp1.DAL
{
    public class CustomerDal
    {

        ConnectionString connection = new ConnectionString();
        public bool Add(Customer customer)
        {
            connection.Customers.Add(customer);
            int isSaved = connection.SaveChanges();
            return isSaved > 0 ? true : false;
        }
        public bool Delete(Customer customer)
        {
            //Customer acustomer = connection.Customers.Where(c => c.Id == id).FirstOrDefault();
            //if (acustomer !=null)
            //{
            //    connection.Customers.Remove(acustomer);
            //}
            connection.Customers.Remove(customer);
            int isSaved = connection.SaveChanges();
            return isSaved > 0 ? true : false;
        }

        public bool Update(Customer customer, int id)
        {
            connection.Entry(customer).State=EntityState.Modified;
            //Customer acustomer = connection.Customers.Where(c => c.Id == id).FirstOrDefault();
            //if (acustomer != null)
            //{
            //    acustomer.Name = customer.Name;
            //    acustomer.PhoneNo = customer.PhoneNo;
            //    acustomer.Address = customer.Address;
            //}
            
            int isSaved = connection.SaveChanges();
            return isSaved > 0 ? true : false;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customer = connection.Customers.Where(c => c.Id == id).FirstOrDefault();
            return customer;
        }
    }
}