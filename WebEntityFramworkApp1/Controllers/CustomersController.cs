using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEntityFramworkApp1.BLL;
using WebEntityFramworkApp1.DatabaseContext;
using WebEntityFramworkApp1.Models;

namespace WebEntityFramworkApp1.Controllers
{
    public class CustomersController : Controller
    {
        CustomerBll _customer=new CustomerBll();

        public string Add(Customer customer)
        {
            //connection.Customers.Add(customer);
            var isSaved = _customer.Add(customer);
            return isSaved? "Saved" : "Not Saved";
        }

        public string Delete(int ? id)
        {
            var isDelete = _customer.Delete(id);
            return isDelete ? "Delete" : "Not Delete";
        }

        public string Update(Customer customer, int id)
        {

            var isUpdate = _customer.Update(customer, id);
            return isUpdate ? "Update" : "Not Update";
        }
	}
}