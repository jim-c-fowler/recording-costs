using System;
namespace RecordingCosts
{
	public class IRoom
	{
		protected Rooms room;
		protected Studios parent;

		public Rooms Room
		{
			get { return room; }
			set { room = value; }
		}

		public Studios Parent
		{
			get { return parent; }
			set { parent = value; }
		}
	}
}
