using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

using HelloRest.Models;

namespace HelloRest.iOS
{
	public partial class PeepsViewController : UIViewController
	{
		private PeepRestApi peepsApi;
		private List<Person> peeps;
		private UITableView table;

		public PeepsViewController () : base ("PeepsViewController", null)
		{
			peepsApi = new PeepRestApi();
			peeps = new List<Person>();
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			Title = "Peeps";
			this.View.BackgroundColor = UIColor.White;

			var rightButton = new UIBarButtonItem("+",UIBarButtonItemStyle.Bordered, this, 
			                                      new MonoTouch.ObjCRuntime.Selector("CreatePeep"));

			this.NavigationItem.RightBarButtonItem = rightButton;



			table = new UITableView(this.View.Bounds);
			table.Source = new PeepsTableSource(peeps);

			PullPeepsData();

			this.View.AddSubview(table);
		}

		private void PullPeepsData()
		{
			peeps.Clear ();
			peeps.AddRange (peepsApi.GetPeeps());
			table.ReloadData ();
		}

		[Export("CreatePeep")]
		public void RightButtonPush ()
		{
			peepsApi.CreatePeep (new Person { Name = "NDDNUG Name" });
			PullPeepsData ();
		}
	}
}

