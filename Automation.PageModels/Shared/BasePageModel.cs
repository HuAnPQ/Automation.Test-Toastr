using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageModels.Shared
{
    public class BasePageModel
    {
        protected IWebDriver driver;

        public void Clear()
        {
            this.driver.Close();
            this.driver.Dispose();
        }

        public void TakeAPicture(string pictureName)
        {
            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile($@"C:\Screenshots\${pictureName}.jpg", ScreenshotImageFormat.Jpeg);
        }
    }
}
