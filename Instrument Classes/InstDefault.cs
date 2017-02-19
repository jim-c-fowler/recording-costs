using System;
namespace RecordingCosts
{
	public class InstDefault
	{

		protected bool candouble = true;
		protected PaymentBand payband = PaymentBand.D;
		protected PorterageBand portband = PorterageBand.N;
		protected Player parent;
		protected Instruments inst;

		public bool Candouble
		{
			get { return candouble; }
			set { candouble = value; }
		}

		public PaymentBand Payband
		{
			get { return payband; }
			set { payband = value; }
		}

		public PorterageBand Portband
		{
			get { return portband; }
			set { portband = value; }
		}

		public Player Parent
		{
			get { return parent; }
			set { parent = value; }
		}

		public Instruments Inst
		{
			get { return inst; }
			set { inst = value; }
		}
	}





}
