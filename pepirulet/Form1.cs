using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using pepiAttendance.Controllers;

namespace pepiAttendance
{
    public partial class Form1 : Form
    {
        public static ChromeDriver? Driver { get; set; }
        public static readonly string SEARCH_URI = "https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=0&ie=utf8&query=%EC%95%84%ED%82%A4%EC%97%90%EC%9D%B4%EC%A7%80";

        public Form1()
        {
            InitializeComponent();
        }

        // 버튼 클릭할때 async 을 사용하지만 void 를 쓸수박에 없어서 Void를 사용함.
        private void button1_Click(object sender, EventArgs e)
        {
            string userId = UserId.Text;
            string password = Password.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                return;
            }

            try
            {
                using (Driver = BrowserInit())
                {
                    if (Driver == null)
                    {
                        return;
                    }
                    Driver.Navigate().GoToUrl(SEARCH_URI);
                    ChromeUtils.DelayRandom(3, 5);

                    var element = Driver.FindElements(By.ClassName("info_group"))[4].FindElement(By.TagName("dd")).FindElements(By.TagName("a"));
                    element[1].Click();
                    Driver.SwitchTo().Window(Driver.WindowHandles.Last());
                    Driver.FindElement(By.ClassName("xlgames-login")).Click();
                    ChromeUtils.DelayRandom(1, 2);
                    Driver.FindElement(By.Name("j_username")).SendKeys("");
                    Driver.FindElement(By.Name("j_username")).Click();
                    Driver.FindElement(By.Name("j_username")).Clear();
                    Driver.FindElement(By.Name("j_username")).SendKeys(OpenQA.Selenium.Keys.Backspace);
                    Driver.FindElement(By.Name("j_username")).SendKeys(OpenQA.Selenium.Keys.Control + OpenQA.Selenium.Keys.Backspace);
                    Driver.FindElement(By.Name("j_username")).SendKeys(OpenQA.Selenium.Keys.Control + OpenQA.Selenium.Keys.Delete);
                    char[] charUserId = userId.ToCharArray();
                    for (int x = 0; x < charUserId.Length; x++)
                    {
                        Driver.FindElement(By.Name("j_username")).SendKeys(charUserId[x].ToString());
                        Thread.Sleep(100);
                    }

                    Driver.FindElement(By.Name("j_password")).SendKeys("");
                    Driver.FindElement(By.Name("j_password")).Click();
                    Driver.FindElement(By.Name("j_password")).Clear();
                    Driver.FindElement(By.Name("j_password")).SendKeys(OpenQA.Selenium.Keys.Backspace);
                    Driver.FindElement(By.Name("j_password")).SendKeys(OpenQA.Selenium.Keys.Control + OpenQA.Selenium.Keys.Backspace);
                    Driver.FindElement(By.Name("j_password")).SendKeys(OpenQA.Selenium.Keys.Control + OpenQA.Selenium.Keys.Delete);
                    char[] charPassword = password.ToCharArray();
                    for (int x = 0; x < charPassword.Length; x++)
                    {
                        Driver.FindElement(By.Name("j_password")).SendKeys(charPassword[x].ToString());
                        Thread.Sleep(100);
                    }
                    Driver.FindElement(By.Name("j_password")).SendKeys(OpenQA.Selenium.Keys.Enter);
                    ChromeUtils.DelayRandom(3, 5);

                    Driver.FindElement(By.ClassName("wing-banner")).Click();
                    ChromeUtils.DelayRandom(1, 2);
                    Driver.SwitchTo().Frame("eventFrame");
                    Driver.FindElement(By.ClassName("link-gift")).Click();
                    Driver.Quit();
                    MessageBox.Show("출책을 완료하였습니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"출석하는데 문제가 발생되었습니다! 에러 메세지 {ex.Message.ToString()}");
            }
        }

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