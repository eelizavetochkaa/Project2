using Project2;
using System;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace Bars
{
    public partial class VK : Form
    {
        private VkApi api; //двухфакторная аутентификация 

        public VK()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginVK.Text;
            string password = passwordVK.Text;
            try
            {
                api = new VkApi();
                api.Authorize(new ApiAuthParams
                {
                    ApplicationId = 51921764,
                    Login = login,
                    Password = password,
                    Settings = Settings.All,
                    TwoFactorAuthorization = () =>
                    {
                        // запрос кода подтверждения у пользователя
                        string code = Microsoft.VisualBasic.Interaction.InputBox("Enter Code:", "Two-Factor Authentication", "");
                        return code;
                    }
                });
                MessageBox.Show("Авторизация прошла успешно!");
                var choose1Form = new Choosing1();
                choose1Form.labelAc.Text = "Аккаунт ВК";
                this.Hide();
                choose1Form.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Авторизация не прошла: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
