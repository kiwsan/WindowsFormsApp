using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;
using WindowsFormsApp.Repositorys;
using WindowsFormsApp.Views;

namespace WindowsFormsApp.Presenters
{
    public class CustomerPresenter : ICustomerPresenter
    {

        //private readonly ICustomerView _customerView;
        private readonly ICustomerRepository _customerRepository;

        public CustomerPresenter(ICustomerRepository _customerRepository)
        {
            //this._customerView = _customerView;
            this._customerRepository = _customerRepository;

            UpdateCustomerListView();
        }

        public void SaveCustomer()
        {
            //Customer customer = new Customer { Name = _customerView.CustomerName, Address = _customerView.Address, Phone = _customerView.Phone };
            //_customerRepository.SaveCustomer(_customerView.SelectedCustomer, customer);

            UpdateCustomerListView();
        }

        public void UpdateCustomerListView()
        {
            var customerNames = from customer in _customerRepository.GetAllCustomers() select customer.Name;

            //int selectedCustomer = _customerView.SelectedCustomer >= 0 ? _customerView.SelectedCustomer : 0;

            //_customerView.CustomerList = customerNames.ToList();
            //_customerView.SelectedCustomer = selectedCustomer;
        }

        public void UpdateCustomerView(int id)
        {
            Customer customer = _customerRepository.GetCustomer(id);

            //_customerView.CustomerName = customer.Name;
            //_customerView.Address = customer.Address;
            //_customerView.Phone = customer.Phone;
        }

    }
}
