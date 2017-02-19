using System;
using System.Collections.Generic;

namespace RecordingCosts
{
	public class Player
	{

		protected Part parent;
		private bool hasdouble;
		public List<InstDefault> instruments = new List<InstDefault>();

		public Player(bool x)
		{
			if (x == true)
			{ Hasdouble = true; }
			else { Hasdouble = false;}
		}


		public bool Hasdouble
		{
			get { return hasdouble; }
			set { hasdouble = value; }
		}

		public Part Parent
		{
			get { return parent; }
			set { parent = value; }
		}
	}
}
