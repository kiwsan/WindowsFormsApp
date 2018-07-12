using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Presenters;
using WindowsFormsApp.Services;
using WindowsFormsApp.Views;

namespace WindowsFormsApp
{
    public partial class CustomerForm : Form, ICustomerView
    {

        private bool _isEditMode = false;

        private readonly IMessageService _messageService;
        private readonly ICustomerPresenter _customerPresenter;
        public CustomerForm(IMessageService _messageService,
            ICustomerPresenter _customerPresenter)
        {
            InitializeComponent();

            this._messageService = _messageService;
            this._customerPresenter = _customerPresenter;

            Text = this._messageService.Title;
        }

        public IList<string> CustomerList
        {
            get { return (IList<string>)this.customerListBox.DataSource; }
            set { this.customerListBox.DataSource = value; }
        }

        public int SelectedCustomer
        {
            get { return this.customerListBox.SelectedIndex; }
            set { this.customerListBox.SelectedIndex = value; }
        }

        public string Address
        {
            get { return this.addressTextBox.Text; }
            set { this.addressTextBox.Text = value; }
        }

        public string CustomerName
        {
            get { return this.nameTextBox.Text; }
            set { this.nameTextBox.Text = value; }
        }

        public string Phone
        {
            get { return this.phoneTextBox.Text; }
            set { this.phoneTextBox.Text = value; }
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FIXME: try/catch
            _customerPresenter.UpdateCustomerView(customerListBox.SelectedIndex);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.addressTextBox.ReadOnly = _isEditMode;
            this.nameTextBox.ReadOnly = _isEditMode;
            this.phoneTextBox.ReadOnly = _isEditMode;

            _isEditMode = !_isEditMode;

            this.editButton.Text = _isEditMode ? "Save" : "Edit";
            // TODO: add cancel button

            if (!_isEditMode)
            {
                // TODO: validation
                // FIXME: try/catch
                _customerPresenter.SaveCustomer();
            }
        }

    }
}
