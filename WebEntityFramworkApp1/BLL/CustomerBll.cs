using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEntityFramworkApp1.DAL;
using WebEntityFramworkApp1.Models;

namespace WebEntityFramworkApp1.BLL
{
    public class CustomerBll
    {
        CustomerDal _customer=new CustomerDal();
        public bool Add(Customer customer)
        {
            var isAdded=_customer.Add(customer);
            return isAdded;
        }
        public bool Delete(Customer customer)
        {
            var isDelete = _customer.Delete(customer);
            return isDelete;
        }

        public bool Update(Customer customer, int id)
        {
            var isUpdate = _customer.Update(customer, id);
            return isUpdate;
        }
        public Customer GetCustomerById(int id)
        {
            var GetId=_customer.GetCustomerById(id);
            return GetId;
        }
    }
}