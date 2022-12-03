namespace Hakaton.Models
{
    public class Person
    {
        private int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _nationality;

        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _patronymic;

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        private DateTime _birthDay;

        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        private int _doc;

        public int Doc
        {
            get { return _doc; }
            set { _doc = value; }
        }

        private PassportRF _passportRF;

        public PassportRF PassportRF
        {
            get { return _passportRF; }
            set { _passportRF = value; }
        }

        private PassportOther _passportOther;

        public PassportOther PassportOther
        {
            get { return _passportOther; }
            set { _passportOther = value; }
        }


        private string _snils;

        public string Snils
        {
            get { return _snils; }
            set { _snils = value; }
        }

        private int _phoneNumber;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _eMail;

        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }



    }
}
