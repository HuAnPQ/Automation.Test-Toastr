using Automation.Infrastructure;
using Automation.PageModels.BaseModel;
using Automation.PageModels.Shared;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageModels
{
    public class ToastPage : BasePageModel
    {
        private ToastPageBase toastPageBase;

        public ToastPage(DriverFactory driverFactory)
        {
            this.driver = driverFactory.BuildWebDriver();
            this.driver.Navigate().GoToUrl(@"https://codeseven.github.io/toastr/demo.html");
            this.toastPageBase = new ToastPageBase();
            PageFactory.InitElements(driver, toastPageBase);
        }

        public void WriteDownTitle(string title)
        {
            this.toastPageBase.Title.SendKeys(title);
        }

        public void WriteDownMessage(string message)
        {
            this.toastPageBase.Message.SendKeys(message);
        }

        public void ClickShowToast(string title)
        {
            this.toastPageBase.ButtonShowtoast.Click();
        }

        public bool CorrectTextToast(string message)
        {
            return this.toastPageBase.ToastMessage.Text.Contains(message);
        }
    }
}
