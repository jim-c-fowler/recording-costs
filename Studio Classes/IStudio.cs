using System;
using System.Collections.Generic;

namespace RecordingCosts
{
	public class IStudio
	{
		protected Studios studio;
		protected List<IRoom> rooms = new List<IRoom>();

		public Studios Studio
		{
			get { return studio; }
			set { studio = value; }
		}
			
		public List<IRoom> Rooms
		{
			get { return rooms; }
			set { rooms = value; }
		}
	}
}
