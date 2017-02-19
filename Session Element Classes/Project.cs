using System;
using System.Collections.Generic;

namespace RecordingCosts
{
	public class Project
	{
		private List<Day> days = new List<Day>();

		//List of all selected Parts - used to draw the table of available musicians
		public List<Instruments> allinstruments = new List<Instruments>();

		//daysUsr is the number of days set by the user and stored when they click OK

		public Project()
		{
		}

		public List<Day> Days
		{
			get { return days; }
			set { days = value; }
		}

	}
}