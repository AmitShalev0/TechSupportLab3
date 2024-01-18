using CustomersData;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersGUI
{
    // auxilliary form to collect data for Add or Modify operation
    public partial class frmAddModifyCustomer : Form
    {
        // public, because the main  form needs access
        public bool isAdd; // true when Add, and false when Modify
        public Customer? customer; // new customer data

        public frmAddModifyCustomer()
        {
            InitializeComponent();
        }

        // populate the states combo box as the form loads
        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                using (TechSupportContext db = new TechSupportContext())
                {
                    // bind the combo box to the states collection
                    cboState.DataSource = db.States.ToList();
                    cboState.DisplayMember = "StateName";
                    cboState.ValueMember = "StateCode";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while retrieving states data: " + ex.Message,
                    "Database Error");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error: " + ex.Message,
                    ex.GetType().ToString());
                Close();
            }
            if (isAdd)
            {
                Text = "Add Customer";
            }
            else // Modify operation
            {
                Text = "Modify Customer";
                DisplayCustomer();
            }
        }

        // for Modify, start with old data values
        private void DisplayCustomer()
        {
            if(customer != null)
            {
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address;
                txtCity.Text = customer.City;
                cboState.SelectedValue = customer.State;
                txtZipCode.Text = customer.ZipCode;
            }
            

        }

        // make a Customer object from collected data
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // validate data
            if(Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtAddress) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsSelected(cboState) &&
                Validator.IsPresent(txtZipCode)
              )
            {
                if (isAdd)
                {
                    customer = new Customer(); // creates empty object
                    GetCustomerData();
                }
                else // Modify
                {
                    // customer is not null
                    GetCustomerData();
                }
                DialogResult = DialogResult.OK; // closes the form
            }
        }

        // populate customer object with data from the controls
        private void GetCustomerData()
        {
            if(customer != null)
            {
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.City = txtCity.Text;
                customer.State = cboState.SelectedValue.ToString(); 
                customer.ZipCode = txtZipCode.Text;
            }
        }
    }
}
