using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Presenters;

namespace WindowsFormsApp.Views
{
    public interface ICustomerView
    {
        IList<string> CustomerList { get; set; }

        int SelectedCustomer { get; set; }

        string CustomerName { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

    }
}
