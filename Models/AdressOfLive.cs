namespace Hakaton.Models
{
    public class AdressOfLive : AdressOfRegistrationParent
    {
		private bool _equalReg;

		public bool EqualReg
		{
			get { return _equalReg; }
			set { _equalReg = value; }
		}

	}
}
