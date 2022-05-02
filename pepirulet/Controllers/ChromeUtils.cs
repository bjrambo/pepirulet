using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pepiAttendance.Controllers
{
    public class ChromeUtils
    {
        private static readonly Random RANDOM = new Random();
        public static void DelayRandom(int min, int max)
        {
            int mins = min * 1000;
            int maxs = (max + 1) * 1000;
            Thread.Sleep(RANDOM.Next(mins, maxs));
        }

        public static void ScrollTo(ChromeDriver driver)
        {
            int y = 0;

            while (true)
            {

                driver.ExecuteScript("window.scrollTo(0," + y + ");");
                y += 100;

                if (2000 < y)
                    break;
                Thread.Sleep(20);
            }
        }
    }
}
