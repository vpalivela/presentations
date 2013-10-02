using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloViews
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			var controller = new TapViewController();
			var otherController = new UIViewController();
			otherController.Title = "Other";
			otherController.View.BackgroundColor = UIColor.Purple;

			var navController = new UINavigationController(controller);
			var tabController = new UITabBarController();
			tabController.ViewControllers = new UIViewController[]{
				navController, otherController
			};

			window.RootViewController = tabController;
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

