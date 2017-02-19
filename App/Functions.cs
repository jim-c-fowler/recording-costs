using System;
using System.Collections.Generic;
namespace RecordingCosts
{
	public static class Functions
	{

		public static void MakeDays(int daysUsr)
		{
			int i;

			for (i = 0; i < daysUsr; i++)
			{
				MainClass.mainproj.Days.Add(new Day());
			}
		}
		
		public static InstDefault MakeInst(Instruments insttype )
		{
			switch (insttype)
			{

				case Instruments.Piccolo:
					return new Piccolo();

				case Instruments.Flute:
					return new Flute();

				case Instruments.AltoFlute:
					return new AltoFlute();
					
				case Instruments.BassFlute:
					return new BassFlute();
					
				case Instruments.Oboe:
					return new Oboe();
					
				case Instruments.CorAnglais:
					return new CorAnglais();

				case Instruments.BassOboe:
					return new BassOboe();
					
				case Instruments.EbClarinet:
					return new EbClarinet();

				case Instruments.BbClarinet:
					return new BbClarinet();
					
				case Instruments.BassClarinet:
					return new BassClarinet();

				case Instruments.ContrabassClarinet:
					return new ContrabassClarinet();
	
				case Instruments.Bassoon:
					return new Bassoon();
					
				case Instruments.Contrabassoon:
					return new ContraBassoon();
					
				case Instruments.Horn:
					return new Horn();

				case Instruments.WagnerTuba:
					return new WagnerTuba();

				case Instruments.BbTrumpet:
					return new BbTrumpet();

				case Instruments.FlugelHorn:
					return new FlugelHorn();
					
				case Instruments.TenorBone:
					return new TenorTrombone();

				case Instruments.BassBone:
					return new BassTrombone();

				case Instruments.ContrabassBone:
					return new ContrabassTrombone();

				case Instruments.Tuba:
					return new Tuba();

				case Instruments.Cimbasso:
					return new Cimbasso();

				case Instruments.Timpani:
					return new Timpani();

				case Instruments.Percussionist:
					return new Percussionist();

				case Instruments.Piano:
					return new Piano();

				case Instruments.Harp:
					return new Harp();

				case Instruments.Soprano:
					return new Soprano();

				case Instruments.Alto:
					return new Alto();
					
				case Instruments.Tenor:
					return new Tenor();

				case Instruments.Bass:
					return new Bass();

				case Instruments.Violin:
					return new Violin();

				case Instruments.Viola:
					return new Viola();

				case Instruments.Cello:
					return new Cello();
					
				case Instruments.DblBass:
					return new DoubleBass();

				default:
					return new InstDefault();

			}

		}

	}
}
