using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageModels.BaseModel
{
    //https://agiletestingalliance.org/aat.html
    internal class ToastPageBase
    {
        [FindsBy(How = How.Id, Using = "title")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement Message { get; set; }

        [FindsBy(How = How.Id, Using = "closeButton")]
        public IWebElement CheckCloseButton { get; set; }

        [FindsBy(How = How.Id, Using = "addBehaviorOnToastClick")]
        public IWebElement CheckAddBehaviorOnToastClick { get; set; }

        [FindsBy(How = How.Id, Using = "debugInfo")]
        public IWebElement CheckDebugInfo { get; set; }

        [FindsBy(How = How.Id, Using = "showtoast")]
        public IWebElement ButtonShowtoast { get; set; }

        [FindsBy(How = How.Id, Using = "cleartoasts")]
        public IWebElement ButtonCleartoasts { get; set; }

        [FindsBy(How = How.Id, Using = "clearlasttoast")]
        public IWebElement ButtonClearlasttoast { get; set; }

        [FindsBy(How = How.Id, Using = "toast-container")]
        public IWebElement ToastContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "toast-title")]
        public IWebElement ToastTitle { get; set; }

        [FindsBy(How = How.ClassName, Using = "toast-message")]
        public IWebElement ToastMessage { get; set; }

    }
}
