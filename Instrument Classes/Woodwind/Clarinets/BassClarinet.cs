using System;
namespace RecordingCosts
{
	public class BassClarinet : BbClarinet
	{
		public BassClarinet()
		{
			portband = PorterageBand.C;
			Inst = Instruments.BassClarinet;
		}
	}
}
