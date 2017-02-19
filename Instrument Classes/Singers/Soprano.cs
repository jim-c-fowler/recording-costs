using System;
namespace RecordingCosts
{
	public class Soprano : InstDefault
	{
		public Soprano()
		{
			Candouble = false;
			Payband = PaymentBand.B;
			Inst = Instruments.Soprano;
		}
	}
}
