﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenQA.Selenium.Appium.Appium.Enums
{
	public sealed class MobileCapabilityType
	{
		#region App and platform

		/// <summary>
		/// Capability name used for the apllication setting.
		/// </summary>
		public static readonly string App = "app";

		/// <summary>
		/// Capability name used for the target platform name setting.
		/// </summary>
		public static readonly string PlatformName = "platformName";

		/// <summary>
		/// Capability name used for the target platform version setting.
		/// </summary>
		public static readonly string PlatformVersion = "platformVersion";

		/// <summary>
		/// Capability name used for the automation name (e.g. Appium, Selendroid and so on) setting.
		/// </summary>
		public static readonly string DeviceName = "deviceName";

		#endregion App and platform

		#region Common

		/// <summary>
		/// Time out for the waiting for a new command.
		/// </summary>
		public static readonly string NewCommandTimeout = "newCommandTimeout";

		/// <summary>
		/// Time out for the waiting for the device is ready.
		/// </summary>
		public static readonly string DeviceReadyTimeout = "deviceReadyTimeout";

		/// <summary>
		/// Time out for the waiting for the app is launched.
		/// </summary>
		public static readonly string LaunchTimeout = "launchTimeout";


		/// <summary>
		/// Capability name used for the automation name (e.g. Appium, Selendroid and so on) setting.
		/// </summary>
		public static readonly string AutomationName = "automationName";

		/// <summary>
		/// Capability name used for the automation name (e.g. Appium, Selendroid and so on) setting.
		/// </summary>
		public static readonly string AppiumVersion = "appium-version";

		#endregion Common

		#region ANDROID

		/// <summary>
		/// It is the required package name.
		/// </summary>
		public static readonly string AppPackage = "appPackage";

		/// <summary>
		/// It is the required activity name.
		/// </summary>
		public static readonly string AppActivity = "appActivity";

		// <summary>
		/// It is the name of the activity which is expected.
		/// </summary>
		public static readonly string AppWaitActivity = "appWaitActivity";

		// <summary>
		/// It is the name of the package which is expected.
		/// </summary>
		public static readonly string AppWaitPackage = "appWaitPackage";

		// <summary>
		/// It is Selendroid port.
		/// </summary>
		public static readonly string SelendroidPort = "selendroidPort";

		// <summary>
		/// true or false. 
		/// </summary>
		public static readonly string AutoWebview = "autoWebview";

		#endregion ANDROID

		//Some more setting names can be added below

	}
}