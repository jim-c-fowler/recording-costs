using System;
namespace RecordingCosts
{
	public partial class DisplayDaysWindow : Gtk.Window
	{
		string temp = "I have made a project with BLANK days";

		string temptwo = Convert.ToString(MainClass.mainproj.Days.Count);


		public DisplayDaysWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			temp.Replace("BLANK", temptwo);

			this.Build();
			textview1.Buffer.Text = temptwo;
		}
	}
}
