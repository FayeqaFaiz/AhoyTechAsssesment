using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Threading;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests.Helpers;
using TestProject.SDK.Tests;
using TestProject.Common.Attributes;
using TestProject.Common.Enums;

namespace TestProject.Generated.Tests.MyFirstProject
{
	
	public class Techtask2 : IAndroidTest
	{
		public ExecutionResult Execute(AndroidTestHelper helper)
		{
			var driver = helper.Driver;
			var report = helper.Reporter;
			bool boolResult;
			By by;
			
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 25000;
			
			 // 1. Reset App
			// Clear application data and restart (Auto-generated)
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ResetApp();
			report.Step("Reset App", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 2. Click 'Home'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.widget.TextView[@content-desc = 'Home']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Home'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 3. Make a Swipe gesture 
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().SwipeGesture(976, 1743, 937, 1264, 300);
			report.Step("Make a Swipe gesture from ('976','1743') to ('937','1264')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 4. Click 'Furniture'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.HorizontalScrollView[1]/android.view.ViewGroup[1]/android.view.ViewGroup[3]//android.widget.ImageView");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'iScaledImage0'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 5. check for title
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.widget.TextView[@text = 'Wooden Console Table - 124x33x76 cms']");
			boolResult = driver.TestProject().ContainsText(by, "Wooden Console Table - 124x33x76 cms");
			report.Step("Does 'Wooden Console Table - 124x33x76 cms' contain 'Wooden Console Table - 124x33x76 cms'?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 6. Click 'on first product'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'ANDROID.WIDGET.IMAGEVIEW1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 7. compare product title'?
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.widget.TextView[@content-desc = 'txtProductTitle']");
			boolResult = driver.TestProject().ContainsText(by, "Wooden Console Table - 124x33x76 cms");
			report.Step("Does 'txtProductTitle' contain 'Wooden Console Table - 124x33x76 cms'?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 8. Make a Swipe gesture 
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().SwipeGesture(858, 1828, 796, 1535, 300);
			report.Step("Make a Swipe gesture from ('858','1828') to ('796','1535')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 9. Click Add to basket'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.view.ViewGroup[@content-desc = 'btnAddToBasketButton']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'btnAddToBasketButton'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 10. Click 'CheckoutNow'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.widget.TextView[@content-desc = 'txtCheckoutNow']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'txtCheckoutNow'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 11. Click 'RemoveButton'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.widget.TextView[@content-desc = 'ttlRemoveButton']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'ttlRemoveButton'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 12. Click 'StartShopping'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//android.widget.TextView[@content-desc = 'ttlStartShopping']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'ttlStartShopping'", boolResult, TakeScreenshotConditionType.Failure);
			
			return ExecutionResult.Passed;
		}
	}
}