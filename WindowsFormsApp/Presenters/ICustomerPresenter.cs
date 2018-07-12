using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Presenters
{
    public interface ICustomerPresenter
    {

        void UpdateCustomerListView();

        void UpdateCustomerView(int id);

        void SaveCustomer();

    }
}
