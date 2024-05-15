using Bars.Properties;
using Project2;
using NLog;
using System.Data.SQLite;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Bars;

namespace DZ
{
    public partial class Cafe : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Cafe()
        {
            if (!String.IsNullOrEmpty(Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Settings.Default.Language);
            }
            InitializeComponent();
            var table = new TableLayoutPanel();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
        }

        public void start_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {
                string login = loginBox.Text;
                string password = passwordBox.Text;

                var user = context.authorization.FirstOrDefault(u => u.login == login && u.password == password);

                if (user != null)
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    var choose1Form = new Choosing1();
                    choose1Form.labelAc.Text = "Встроенный аккаунт";
                    this.Hide();
                    choose1Form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }
        public void buttonVK_Click(object sender, EventArgs e)
        {
            var VKForm = new VK();
            this.Hide();
            VKForm.ShowDialog();
            this.Close();
        }
        private void Cafe_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
                System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
            };

            comboBox1.DisplayMember = "NativeName";
            comboBox1.ValueMember = "Name";
            if (!String.IsNullOrEmpty(Settings.Default.Language))
            {
                comboBox1.SelectedValue = Settings.Default.Language;
            }
            logger.Info("The Cafe form was opened");
        }

        private void Cafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Settings.Default.Save();
            logger.Info("The Cafe form was closed");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            change.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Info($"Language changed to {comboBox1.SelectedItem}");
            Application.Restart();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}