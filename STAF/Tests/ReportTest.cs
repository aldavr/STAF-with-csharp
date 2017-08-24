﻿using AventStack.ExtentReports;
using NUnit.Framework;
using STAF.Framework.BaseClasses;
using STAF.Framework.HelperClasses;

namespace STAF.Tests
{
    [TestFixture]
    class ReportTest : BaseSetup
    {
        [Test]
        public void ReportTest01()
        {
            _test.Info("Step 1: Do something.");
            _test.Info("Step 2: Do something.");
            _test.Info("Step 3: Do something.");

        }
        [Test]
        public void ReportTest02()
        {
            _test.Info("<span class=\"label white-text blue\">Step 1: </span>Login with valid username and password.");
            _test.Warning("details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\daliyev\OneDrive - DSS\Projects\Git\STA-framework-with-csharp\Reports\screenshots\" + ScreenshotHelper.TakeScreenshot()).Build());
            _test.Info("<span class=\"label white-text blue\">Step 2: Login with valid username and password.</span>");
            _test.Warning("details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\daliyev\OneDrive - DSS\Projects\Git\STA-framework-with-csharp\Reports\screenshots\" + ScreenshotHelper.TakeScreenshot()).Build());
            _test.Info("<span class=\"label white-text blue\">Step 3: Login with valid username and password.</span>");
            _test.Warning("details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\daliyev\OneDrive - DSS\Projects\Git\STA-framework-with-csharp\Reports\screenshots\" + ScreenshotHelper.TakeScreenshot()).Build());


        }
        [Test]
        public void ReportTest03()
        {
            _test.Pass("Test 3");
        }

    }
}
