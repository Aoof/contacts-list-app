using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace ContactListProject
{
    public partial class Form1 : Form
    {
        private List<bus.Contact> contacts = new List<bus.Contact>();

        private bus.Contact current = new bus.Contact();
        private bus.Contact selected = new bus.Contact();

        public Form1()
        {
            InitializeComponent();

            comboBoxContactType.DataSource = Enum.GetValues(typeof(bus.EnumType));
        }

        private List<string> ValidateInput()
        {
            List<string> errors = new List<string>();

            var contactNumber = textBoxContactNumber.Text.Trim();
            var firstName = textBoxFirstName.Text.Trim();
            var lastName = textBoxLastName.Text.Trim();
            var email = textBoxEmail.Text.Trim();
            var contactType = comboBoxContactType.SelectedItem;

            var day = numericUpDownDay.Text.Trim();
            var month = numericUpDownMonth.Text.Trim();
            var year = numericUpDownYear.Text.Trim();
            var hour = numericUpDownHour.Text.Trim();
            var minute = numericUpDownMinute.Text.Trim();

            int dayInt = 0, monthInt = 0, yearInt = 0, hourInt = 0, minuteInt = 0;

            if (string.IsNullOrEmpty(contactNumber))
            {
                errors.Add("Contact Number is required.");
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
            else if (!email.Contains("@") || !email.Contains("."))
            {
                errors.Add("Email format is invalid.");
            }

            if (contactType == null)
            {
                errors.Add("Contact Type is required.");
            }

            if (string.IsNullOrEmpty(day) || !int.TryParse(day, out dayInt) || dayInt < 1 || dayInt > 31)
            {
                errors.Add("Day must be a number between 1 and 31.");
            }

            if (string.IsNullOrEmpty(month) || !int.TryParse(month, out monthInt) || monthInt < 1 || monthInt > 12)
            {
                errors.Add("Month must be a number between 1 and 12.");
            }

            if (string.IsNullOrEmpty(year) || !int.TryParse(year, out yearInt) || yearInt < 1900 || yearInt > DateTime.Now.Year)
            {
                errors.Add($"Year must be a number between 1900 and {DateTime.Now.Year}.");
            }

            if (string.IsNullOrEmpty(hour) || !int.TryParse(hour, out hourInt) || hourInt < 0 || hourInt > 23)
            {
                errors.Add("Hour must be a number between 0 and 23.");
            }

            if (string.IsNullOrEmpty(minute) || !int.TryParse(minute, out minuteInt) || minuteInt < 0 || minuteInt > 59)
            {
                errors.Add("Minute must be a number between 0 and 59.");
            }

            if (errors.Count == 0)
            {
                var meetingDate = new bus.DateTimeCustom(monthInt, dayInt, yearInt, hourInt, minuteInt);
                current = new bus.Contact(contactNumber, firstName, lastName, email, (bus.EnumType)contactType, meetingDate);
            }

            return errors;
        }

        private void ClearInputFields()
        {
            textBoxContactNumber.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            comboBoxContactType.SelectedItem = null;
            numericUpDownDay.Value = 1;
            numericUpDownMonth.Value = 1;
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownHour.Value = 0;
            numericUpDownMinute.Value = 0;
        }

        private void RefreshContactList()
        {
            listViewContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                var item = new ListViewItem(contact.ContactNumber);
                item.SubItems.Add(contact.FirstName);
                item.SubItems.Add(contact.LastName);
                item.SubItems.Add(contact.Email);
                item.SubItems.Add(contact.ContactType.ToString());
                item.SubItems.Add(contact.MeetingDate.ToString());
                listViewContacts.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var errors = ValidateInput();

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            contacts.Add(current);
            RefreshContactList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selected != null && contacts.Contains(selected))
            {
                contacts.Remove(selected);
                selected = null;
                ClearInputFields();
                RefreshContactList();
            }
            else
            {
                MessageBox.Show("No contact selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var contactNumber = textBoxContactNumber.Text.Trim();
            var firstName = textBoxFirstName.Text.Trim();
            var lastName = textBoxLastName.Text.Trim();
            var email = textBoxEmail.Text.Trim();
            var contactType = comboBoxContactType.SelectedItem;

            var day = numericUpDownDay.Text.Trim();
            var month = numericUpDownMonth.Text.Trim();
            var year = numericUpDownYear.Text.Trim();
            var hour = numericUpDownHour.Text.Trim();
            var minute = numericUpDownMinute.Text.Trim();

            var results = contacts.AsEnumerable();

            if (!string.IsNullOrEmpty(contactNumber))
            {
                results = results.Where(c => c.ContactNumber.Contains(contactNumber));
                MessageBox.Show($"Searching for Contact Number containing: {contactNumber} and found {results.Count()} results", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listViewContacts.Items.Clear();
            foreach (var contact in results)
            {
                var item = new ListViewItem(contact.ContactNumber);
                item.SubItems.Add(contact.FirstName);
                item.SubItems.Add(contact.LastName);
                item.SubItems.Add(contact.Email);
                item.SubItems.Add(contact.ContactType.ToString());
                item.SubItems.Add(contact.MeetingDate.ToString());
                listViewContacts.Items.Add(item);
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            RefreshContactList();
        }

        private void buttonWriteXmlFile_Click(object sender, EventArgs e)
        {
            try
            {
                string dataDirectory = Path.Combine(Application.StartupPath, "data");
                if (!Directory.Exists(dataDirectory))
                {
                    Directory.CreateDirectory(dataDirectory);
                }

                string fileName = Path.Combine(dataDirectory, "contacts.xml");
                
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<bus.Contact>));
                using (var writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, contacts);
                }
                
                MessageBox.Show($"Contacts saved successfully to {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReadXmlFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Path.Combine(Application.StartupPath, "data", "contacts.xml");
                
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("No saved contacts file found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<bus.Contact>));
                using (var reader = new StreamReader(fileName))
                {
                    contacts = (List<bus.Contact>)serializer.Deserialize(reader);
                }
                
                MessageBox.Show("Contacts loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonDisplay_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewContacts.SelectedItems.Count > 0)
            {
                var selectedContactNumber = listViewContacts.SelectedItems[0].Text;
                selected = contacts.FirstOrDefault(c => c.ContactNumber == selectedContactNumber);
                if (selected != null)
                {
                    textBoxContactNumber.Text = selected.ContactNumber;
                    textBoxFirstName.Text = selected.FirstName;
                    textBoxLastName.Text = selected.LastName;
                    textBoxEmail.Text = selected.Email;
                    comboBoxContactType.SelectedItem = selected.ContactType;
                    numericUpDownDay.Value = selected.MeetingDate.Day;
                    numericUpDownMonth.Value = selected.MeetingDate.Month;
                    numericUpDownYear.Value = selected.MeetingDate.Year;
                    numericUpDownHour.Value = selected.MeetingDate.Hour;
                    numericUpDownMinute.Value = selected.MeetingDate.Minute;
                }
            }
        }
    }
}
