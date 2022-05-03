using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using pepiAttendance.Controllers;

namespace pepiAttendance
{
    public partial class Form1 : Form
    {
        public static ChromeDriver? Driver { get; set; }
        public static readonly string SEARCH_NAME = "��Ű������";

        public Form1()
        {
            InitializeComponent();
        }

        // ��ư Ŭ���Ҷ� async �� ��������� void �� �����ڿ� ��� Void�� �����.
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
                    Driver.Navigate().GoToUrl("https://www.naver.com/");
                    Driver.FindElement(By.Id("query")).SendKeys("");
                    Driver.FindElement(By.Id("query")).Click();
                    Driver.FindElement(By.Id("query")).Clear();
                    Driver.FindElement(By.Id("query")).SendKeys(OpenQA.Selenium.Keys.Backspace);
                    Driver.FindElement(By.Id("query")).SendKeys(OpenQA.Selenium.Keys.Control + OpenQA.Selenium.Keys.Backspace);
                    Driver.FindElement(By.Id("query")).SendKeys(OpenQA.Selenium.Keys.Control + OpenQA.Selenium.Keys.Delete);
                    char[] keyword = SEARCH_NAME.ToCharArray();
                    for (int x = 0; x < keyword.Length; x++)
                    {
                        Driver.FindElement(By.Id("query")).SendKeys(keyword[x].ToString());
                        Thread.Sleep(100);
                    }
                    Driver.FindElement(By.Id("query")).SendKeys(OpenQA.Selenium.Keys.Enter);
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
                    MessageBox.Show("��å�� �Ϸ��Ͽ����ϴ�");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�⼮�ϴµ� ������ �߻��Ǿ����ϴ�! ���� �޼��� {ex.Message.ToString()}");
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