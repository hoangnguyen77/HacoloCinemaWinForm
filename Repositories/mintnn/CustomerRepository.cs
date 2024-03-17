using BussinessObject;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomerByName(string name)
            => CustomerDAO.Instance.GetCustomerByName(name);
        public List<Customer> GetCustomers()
            => CustomerDAO.Instance.GetCustomers();

        public List<Customer> GetCustomersAscending()
            => CustomerDAO.Instance.GetCustomersAscending();
    }
}
