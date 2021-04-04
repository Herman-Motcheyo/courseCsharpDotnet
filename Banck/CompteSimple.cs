using System;

namespace metier
{
	public class CompteSimple :Compte
	{
		private float decouvert;
		public CompteSimple(float dec) : base()
        {
			this.decouvert = dec;
        }
		public CompteSimple(float s, float dec) : base(s)
		{
			this.decouvert = dec;
		}
	}
}

