namespace Hakaton.Models
{
    public class PassportRF
    {
		private int _serial;

		public int Serial
		{
			get { return _serial; }
			set { _serial = value; }
		}

		private int _number;

		public int Number
		{
			get { return _number; }
			set { _number = value; }
		}

		private DateTime _dateOfIssue;

		public DateTime DateOfIssue
		{
			get { return _dateOfIssue; }
			set { _dateOfIssue = value; }
		}

		private string _organization;

		public string Organization
		{
			get { return _organization; }
			set { _organization = value; }
		}


	}
}
