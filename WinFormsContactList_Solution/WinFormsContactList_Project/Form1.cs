using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsContactList_Project
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                contactTableAdapter.Fill(database1DataSet.Contact);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            var errors = ValidateInput();
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlQuery = "INSERT INTO Contact (ContactNumber, FirstName, LastName, Email) " +
                             "VALUES (@ContactNumber, @FirstName, @LastName, @Email)";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ContactNumber", int.Parse(txtContactNumber.Text.Trim()));
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contact added successfully!", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            RefreshDataGrid();
                            ClearInputFields();
                            txtContactNumber.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add contact.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("Contact Number already exists. Please use a different number.", 
                        "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Database Error: {sqlEx.Message}", "Database Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unexpected Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null)
            {
                MessageBox.Show("Please select a contact to update.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var errors = ValidateInput();
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TryGetSelectedContactNumber(out int originalContactNumber))
            {
                MessageBox.Show("Invalid contact selection.", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlQuery = "UPDATE Contact SET FirstName = @FirstName, " +
                             "LastName = @LastName, Email = @Email, ContactNumber = @NewContactNumber " +
                             "WHERE ContactNumber = @OriginalContactNumber";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewContactNumber", int.Parse(txtContactNumber.Text.Trim()));
                        command.Parameters.AddWithValue("@OriginalContactNumber", originalContactNumber);
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contact updated successfully!", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            RefreshDataGrid();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update contact.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("Contact Number already exists. Please use a different number.", 
                        "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Database Error: {sqlEx.Message}", "Database Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unexpected Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null)
            {
                MessageBox.Show("Please select a contact to delete.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = dgvContacts.CurrentRow.Cells["colFirstName"].Value.ToString();
            string lastName = dgvContacts.CurrentRow.Cells["colLastName"].Value.ToString();
            string contactName = $"{firstName} {lastName}";

            var result = MessageBox.Show($"Are you sure you want to delete {contactName}?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!TryGetSelectedContactNumber(out int contactNumber))
                {
                    MessageBox.Show("Invalid contact selection.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sqlQuery = "DELETE FROM Contact WHERE ContactNumber = @ContactNumber";

                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);

                            int rowsAffected = command.ExecuteNonQuery();
                            
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Contact deleted successfully!", "Success", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                RefreshDataGrid();
                                ClearInputFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete contact.", "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private List<string> ValidateInput()
        {
            var errors = new List<string>();
            var contactNumber = txtContactNumber.Text.Trim();
            var firstName = txtFirstName.Text.Trim();
            var lastName = txtLastName.Text.Trim();
            var email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(contactNumber))
            {
                errors.Add("Contact Number is required.");
            }
            else if (!int.TryParse(contactNumber, out _))
            {
                errors.Add("Contact Number must be numeric.");
            }

            if (string.IsNullOrEmpty(firstName))
            {
                errors.Add("First Name is required.");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                errors.Add("Last Name is required.");
            }

            if (string.IsNullOrEmpty(email))
            {
                errors.Add("Email is required.");
            }
            else if (!IsValidEmail(email))
            {
                errors.Add("Please enter a valid email address.");
            }

            return errors;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ClearInputFields()
        {
            txtContactNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            dgvContacts.ClearSelection();
            txtContactNumber.Focus();
        }

        private void RefreshDataGrid()
        {
            try
            {
                database1DataSet.Contact.Clear();
                contactTableAdapter.Fill(database1DataSet.Contact);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryGetSelectedContactNumber(out int contactNumber)
        {
            contactNumber = 0;

            if (dgvContacts.CurrentRow?.Cells["colContactNumber"]?.Value == null)
                return false;

            var cellValue = dgvContacts.CurrentRow.Cells["colContactNumber"].Value;

            if (cellValue is int intValue)
            {
                contactNumber = intValue;
                return true;
            }

            if (cellValue is string stringValue && int.TryParse(stringValue, out int parsedValue))
            {
                contactNumber = parsedValue;
                return true;
            }

            return false;
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContacts.CurrentRow != null && dgvContacts.CurrentRow.Index >= 0)
            {
                txtContactNumber.Text = dgvContacts.CurrentRow.Cells["colContactNumber"].Value?.ToString() ?? "";
                txtFirstName.Text = dgvContacts.CurrentRow.Cells["colFirstName"].Value?.ToString() ?? "";
                txtLastName.Text = dgvContacts.CurrentRow.Cells["colLastName"].Value?.ToString() ?? "";
                txtEmail.Text = dgvContacts.CurrentRow.Cells["colEmail"].Value?.ToString() ?? "";
            }
        }
    }
}
