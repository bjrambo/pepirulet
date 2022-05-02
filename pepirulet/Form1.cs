namespace pepirulet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = UserId.Text;
            string password = Password.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                return;
            }


        }
    }
}