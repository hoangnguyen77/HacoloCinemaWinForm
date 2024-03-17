using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static object lockObject = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }
        public List<Customer> GetCustomers()
        {
            using var db = new HakoloCinemaManagementContext();
            return db.Customers.ToList();
        }

        public List<Customer> GetCustomerByName(string name)
        {
            using var db = new HakoloCinemaManagementContext();
            return db.Customers.Where(f => f.CustomerName.Contains(name)).ToList();
        }
        public List<Customer> GetCustomersAscending()
        {
            using var db = new HakoloCinemaManagementContext();
            return db.Customers.OrderBy(f => f.CustomerName).ToList();
        }
    }
}
