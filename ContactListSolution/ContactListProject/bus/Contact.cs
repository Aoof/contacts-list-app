namespace ContactListProject.bus
{
    public class Contact
    {
        private string contactNumber = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string email = string.Empty;
        private EnumType contactType = EnumType.Other;
        private DateTimeCustom meetingDate = new DateTimeCustom();

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public EnumType ContactType
        {
            get { return contactType; }
            set { contactType = value; }
        }

        public DateTimeCustom MeetingDate
        {
            get { return meetingDate; }
            set { meetingDate = value; }
        }

        public Contact() { }

        public Contact(string contactNumber, string firstName, string lastName, string email, EnumType contactType, DateTimeCustom meetingDate)
        {
            ContactNumber = contactNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ContactType = contactType;
            MeetingDate = meetingDate;
        }

        public override string ToString()
        {
            return $"{ContactNumber}, {FirstName}, {LastName}, {Email}, {ContactType}, {MeetingDate}";
        }
    }
}
