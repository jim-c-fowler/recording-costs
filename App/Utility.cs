using System;
using System.Collections.Generic;
namespace RecordingCosts
{
	public class Utility
	{

		//Add selected sessions to each day
		public void AddSessions(Project proj)
		{
			foreach (Day dy in proj.Days)
			{
				dy.sessions.Add(new Session());
				dy.sessions.Add(new Session());
				dy.sessions.Add(new Session());
			}
		}

		//Add new Part names to global allparts list TODO call this for each instrument user selects in GUI and use it to draw the main interface
		public void CreateAvailableInstruments(Project proj, Instruments m)
		{
			proj.allinstruments.Add(m);
		}


		/*Create an Instrument, assign it to a Player, assign a doubling instrument. Add to a new Part and add that to the appropriate sessions.
		 *TODO  This is done based on user input on main interface and should be called for each allinstruments entry, either once the user has stopped editing or when they press refresh
		 **/

		public void AssignParts(Instruments maininst, Instruments doubinst, int usrPlyrs, bool usrDbl, Instruments insttype, Session s)
		{
			Part prt = new Part();

			//usrPlyrs is number of selected players per part, got from GUI
			//usrDbl is whether the player is doubling
			int i;

			for (i = 0; i < usrPlyrs; i++)
			{
				prt.players.Add(new Player(usrDbl));	
			}

			//Make Players and add Instruments
			foreach (Player p in prt.players)
			{
				p.instruments.Add(Functions.MakeInst(maininst));

				if (p.Hasdouble == true)
				{
					p.instruments.Add(Functions.MakeInst(doubinst));
				}
			}

			//Add Part (plus all its children) to Session
			s.parts.Add(prt);

		}
	}
}