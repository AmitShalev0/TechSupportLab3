using CustomersData;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmCustomerMaintenance : Form
    {
        private Customer? selectedCustomer = null;
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        // at the start
        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        // get customer with given ID
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtCustomerID) &&// if valid customer ID
                Validator.IsNonNegativeInt(txtCustomerID))
            {
                int custID = Convert.ToInt32(txtCustomerID.Text);
                try
                {
                    using (TechSupportContext db = new TechSupportContext())
                    {
                        selectedCustomer = db.Customers.Find(custID);
                        if (selectedCustomer != null)
                        {
                            DisplayCustomer();

                            // get related incidents
                            var incidents = selectedCustomer.Incidents.
                                Select(i => new
                                {
                                    i.IncidentId, i.CustomerId,
                                    i.IncidentDate, i.IncidentTotal
                                }).ToList();
                            dgvIncident.DataSource = incidents;
                            dgvIncident.Columns[3].DefaultCellStyle.Format = "c";
                        }
                        else
                        {
                            MessageBox.Show
                                ($"There is no customer with ID = {custID}");
                        }
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error while retrieving customer data: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }
            }
        }

        // display selected customer in text boxes
        private void DisplayCustomer()
        {
            if (selectedCustomer != null)
            {
                txtCustomerID.Text = selectedCustomer.CustomerId.ToString();
                txtName.Text = selectedCustomer.Name;
                txtAddress.Text = selectedCustomer.Address;
                txtCity.Text = selectedCustomer.City;
                txtState.Text = selectedCustomer.State;
                txtZipCode.Text = selectedCustomer.ZipCode;
                // enable Modify and Delete
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        // terminate execution
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // add new customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // display second form to collect data
            frmAddModifyCustomer secondForm =
                new frmAddModifyCustomer();
            secondForm.isAdd = true; // it is Add operation
            secondForm.customer = null; // no customer yet

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // second form collected data
            {
                selectedCustomer = secondForm.customer;
                // add it to the Customers table
                try
                {
                    using (TechSupportContext db = new TechSupportContext())
                    {
                        if (selectedCustomer != null)
                        {
                            db.Customers.Add(selectedCustomer);
                            db.SaveChanges();
                            DisplayCustomer();
                        }
                    }
                }
                catch (DbUpdateException ex)
                {
                    string msg = "";
                    var sqlException =
                        (SqlException)ex.InnerException!;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        msg += $"ERROR CODE {error.Number}: { error.Message}\n";
                    }
                    MessageBox.Show(msg, "Database Error");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while adding customer: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }
            }

        }

        // modify selected customer
        private void btnModify_Click(object sender, EventArgs e)
        {
            // display second form with current data
            // and collect new data values
            frmAddModifyCustomer secondForm =
                new frmAddModifyCustomer();
            secondForm.isAdd = false; // it is Modify operation
            secondForm.customer = selectedCustomer;
            // pass selected customer to the second form

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // second form collected new data
            {
                // perform the update
                try
                {
                    using (TechSupportContext db = new TechSupportContext())
                    {
                        if (secondForm.customer != null)
                        {
                            db.Customers.Update(secondForm.customer);
                            db.SaveChanges();
                            DisplayCustomer();
                            //// find this customer in the current context
                            //int custID = secondForm.customer.CustomerId;
                            //selectedCustomer = db.Customers.Find(custID);
                            //if (selectedCustomer != null)
                            //{
                            //    // copy over new data from the secons form
                            //    selectedCustomer.Name =secondForm.customer.Name;
                            //    selectedCustomer.Address = secondForm.customer.Address;
                            //    selectedCustomer.City = secondForm.customer.City;
                            //    selectedCustomer.State = secondForm.customer.State;
                            //    selectedCustomer.ZipCode = secondForm.customer.ZipCode;
                            //    // no need to call Update method
                            //    db.SaveChanges();
                            //    DisplayCustomer();
                            //}
                        }
                    }
                }
                catch (DbUpdateException ex)
                {
                    string msg = "";
                    var sqlException =
                        (SqlException)ex.InnerException!;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        msg += $"ERROR CODE {error.Number}: {error.Message}\n";
                    }
                    MessageBox.Show(msg, "Database Error");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while modifying customer: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }
            }


        }

        // delete selected customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedCustomer != null)
            {
                // get the user's confirmation
                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete {selectedCustomer.Name}",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // user confirmed
                {
                    // perform delete
                    try
                    {
                        using (TechSupportContext db = new TechSupportContext())
                        {
                            db.Customers.Remove(selectedCustomer);
                            db.SaveChanges();
                            selectedCustomer = null;
                            ClearControls();
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        string msg = "";
                        var sqlException =
                            (SqlException)ex.InnerException!;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            msg += $"ERROR CODE {error.Number}: {error.Message}\n";
                        }
                        MessageBox.Show(msg, "Database Error");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error while deleting customer: " + ex.Message,
                            "Database Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unanticipated error: " + ex.Message,
                            ex.GetType().ToString());
                    }
                }

            }
        }

        // no selected customer - clear controls
        private void ClearControls()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            // disable Modify and Delete
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtCustomerID.Focus(); // facilitate selecting another customer
        }
    }
}
