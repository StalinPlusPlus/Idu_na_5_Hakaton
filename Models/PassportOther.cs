namespace Hakaton.Models
{
    public class PassportOther : PassportRF
    {

        private DateTime _dateOfEnd;

        public DateTime DateOfEnd
        {
            get { return _dateOfEnd; }
            set { _dateOfEnd = value; }
        }

        private bool _lastPassport;

        public bool LastPassport
        {
            get { return _lastPassport; }
            set { _lastPassport = value; }
        }

    }
}
