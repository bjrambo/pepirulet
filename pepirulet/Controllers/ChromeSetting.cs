using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pepirulet.Controllers
{
    public class ChromeSetting
    {
        public static ChromeDriver BrowserInit()
        {
            string useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.41 Safari/537.36";
            ChromeOptions option = new ChromeOptions();
            option.AddExcludedArgument("enable-automation");
            option.AddArgument("disable-infobars");
            option.AddArgument("--window-size=1600,1000");
            option.AddArgument("--user-agent=" + useragent);

            ChromeDriver chromeDriver = new ChromeDriver(option);
            chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            return chromeDriver;
        }
    }
}
