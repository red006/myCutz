﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace myCutz.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
	//	UIWindow window;
	//	public static UIStoryboard Storyboard = UIStoryboard.FromName("LogInSignUp", null);
	//	public static UIViewController initialViewController;

	//	//public override bool FinishedLaunching(UIApplication app, NSDictionary options)
	//	//{
	//	//	window = new UIWindow(UIScreen.MainScreen.Bounds);

	//		initialViewController = Storyboard.InstantiateInitialViewController() as UIViewController;

	//		window.RootViewController = initialViewController;
	//		window.MakeKeyAndVisible();
	//		return true;
	//	}

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

