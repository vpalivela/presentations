// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HelloWorld
{
	[Register ("HelloWorldViewController")]
	partial class HelloWorldViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel HelloLabel { get; set; }

		[Action ("sayHelloClicked:")]
		partial void sayHelloClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (HelloLabel != null) {
				HelloLabel.Dispose ();
				HelloLabel = null;
			}
		}
	}
}
