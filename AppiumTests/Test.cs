using NUnit.Framework;
using System;

//using Appium.Samples.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Appium.Appium.Enums;

using OpenQA.Selenium;
using System.Threading;

namespace AppiumTests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
		}

		private AppiumDriver driver;
		private bool allPassed = true;

		public static DesiredCapabilities getIos71Caps (string app)
		{

			DesiredCapabilities capabilities = new DesiredCapabilities ();
			capabilities.SetCapability (CapabilityType.BrowserName, "");


			capabilities.SetCapability (MobileCapabilityType.AppiumVersion, "1.0");

			capabilities.SetCapability (MobileCapabilityType.PlatformName, "iOS");
			capabilities.SetCapability (MobileCapabilityType.PlatformVersion, "8.1");
			capabilities.SetCapability (MobileCapabilityType.DeviceName, "iPhone Simulator");
			capabilities.SetCapability (MobileCapabilityType.App, app);

			return capabilities;
		}

		[TestFixtureSetUp]
		public void BeforeAll ()
		{
//			var path = "/Users/nh8589/Library/Developer/CoreSimulator/Devices/66B1547F-8709-4425-8743-6C843F332303/data/Containers/Bundle/Application/01E7A519-BAA5-494E-8E47-87354C0B7811/AppiumProofOfConcept.app";
//			var path = "/Users/nh8589/Projects/AppiumProofOfConcept/AppiumProofOfConcept/bin/iPhoneSimulator/Release/AppiumProofOfConcept.app";
			var path = "/Users/nh8589/Projects/AppiumProofOfConcept/AppiumProofOfConcept/bin/iPhoneSimulator/Debug/AppiumProofOfConcept.app";
			DesiredCapabilities capabilities = getIos71Caps (path); 

			Uri serverUri = new Uri ("http://127.0.0.1:4723/wd/hub");

			driver = new AppiumDriver (serverUri, capabilities);//, /*timeout*/TimeSpan.Zero);	
			driver.Manage ().Timeouts ().ImplicitlyWait (/*timeout*/TimeSpan.Zero);
		}

		[TestFixtureTearDown]
		public void AfterAll ()
		{
			try {
				((IJavaScriptExecutor)driver).ExecuteScript ("sauce:job-result=" + (allPassed ? "passed" : "failed"));
			} finally {
				driver.Quit ();
			}
		}

		[TearDown]
		public void AfterEach ()
		{
			allPassed = allPassed && (TestContext.CurrentContext.Result.State == TestState.Success);
		}


		[Test ()]
		public void ComputeSumTestCase ()
		{
			const string DesiredText = "hello appium";
			var textField = driver.FindElementByName ("ExampleTextField");
			textField.Clear ();
			textField.SendKeys (DesiredText);

			Assert.AreEqual (textField.Text, DesiredText);
		}
	}
}

