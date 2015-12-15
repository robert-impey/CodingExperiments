using System;
using System.Net.Http;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		goFetchButton.Clicked += new EventHandler (DisplayWebsiteLength);

		outputTextView.Buffer.Text = "Hello, GTK#!";
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected async void DisplayWebsiteLength (object sender, EventArgs e)
	{
		outputTextView.Buffer.Text = "Fetching...";
		using (var client = new HttpClient ()) {
			outputTextView.Buffer.Text = await client.GetStringAsync (inputTextView.Buffer.Text);
		}
	}
}
