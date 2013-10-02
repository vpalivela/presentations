
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloViews
{
	public partial class TapViewController : UIViewController
	{
		public TapViewController () : base ("TapViewController", null)
		{
			this.TabBarItem = new UITabBarItem(UITabBarSystemItem.Favorites, 1);
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
			Title = string.Format("Tap ({0})", this.NavigationController.ViewControllers.Length);

			var rightButton = new UIBarButtonItem("Push", UIBarButtonItemStyle.Bordered, this, new MonoTouch.ObjCRuntime.Selector("pushButton"));
			this.NavigationItem.RightBarButtonItem = rightButton;
		}

		[Export("pushButton")]
		public void whatever()
		{
			var newController = new TapViewController();
			this.NavigationController.PushViewController(newController, true);
		}
	}
}

