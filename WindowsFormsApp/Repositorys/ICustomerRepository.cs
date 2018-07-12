using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Repositorys
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomer(int id);

        void SaveCustomer(int id, Customer customer);
    }
}
