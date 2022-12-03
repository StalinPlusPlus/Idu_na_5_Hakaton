namespace Hakaton.Models
{
    public class AdressOfRegistrationParent
    {
		private int _index;

		public int Index
		{
			get { return _index; }
			set { _index = value; }
		}

		private string _country;

		public string Conutry
		{
			get { return _country; }
			set { _country = value; }
		}

		private string _region;

		public string Region
		{
			get { return _region; }
			set { _region = value; }
		}

		private string _district;

		public string District
		{
			get { return _district; }
			set { _district = value; }
		}

		private string _town;

		public string Town
		{
			get { return _town; }
			set { _town = value; }
		}

		private string _street;

		public string Street
		{
			get { return _street; }
			set { _street = value; }
		}

		private int _numberOfHouse;

		public int NumberOfHouse
		{
			get { return _numberOfHouse; }
			set { _numberOfHouse = value; }
		}

		private int _korpus;

		public int Korpus
		{
			get { return _korpus; }
			set { _korpus = value; }
		}

		private int _apartment;

		public int Apartment
		{
			get { return _apartment; }
			set { _apartment = value; }
		}

	}
}
