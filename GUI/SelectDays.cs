using System;
using Gtk;
namespace RecordingCosts
{
	public partial class SelectDays : Gtk.Window
	{

		public SelectDays() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		protected void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
			a.RetVal = true;
		}

		protected void OnCancel(object sender, EventArgs e)
		{
			Application.Quit();
		}


		protected void OnOKClick(object sender, EventArgs e)
		{

			//int daysUsr = Convert.ToInt32(spinbutton1.Value);

			MainClass.mainproj = new Project();
			Functions.MakeDays(Convert.ToInt32(spinbutton1.Value));
			Application.Quit();
 		}
	}
}
