using System;
using System.Collections.Generic;

namespace RecordingCosts
{
	public class Session
	{
		public Times time;
		public bool conductor;
		public List<Part> parts = new List<Part>();
		public Day parent;

	}
}
