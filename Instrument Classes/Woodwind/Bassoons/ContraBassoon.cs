using System;
namespace RecordingCosts
{
	public class ContraBassoon : Bassoon
	{
		public ContraBassoon()
		{
			Candouble = false;
			Portband = PorterageBand.C;
			Inst = Instruments.Contrabassoon;
		}
	}
}
