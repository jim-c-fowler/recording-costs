using System;
using System.Collections.Generic;
using Gtk;


namespace RecordingCosts
{
	class MainClass
	{
		public static Project mainproj;

		public static void Main(string[] args)
		{
			Application.Init();
			SelectDays myDaySelect = new SelectDays();
			myDaySelect.Show();
			Application.Run();


			DisplayDaysWindow myDisplayDays = new DisplayDaysWindow();
			myDisplayDays.Show();
			Application.Run();

			/*Application.Init();
			MainWindow win = new MainWindow();2
			win.Show();
			Application.Run();*/
		}


	}
}