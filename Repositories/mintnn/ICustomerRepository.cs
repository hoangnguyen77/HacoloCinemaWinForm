using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomerByName(string name);
        List<Customer> GetCustomersAscending();
    }
}
