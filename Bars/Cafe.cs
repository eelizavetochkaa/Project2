using Bars;
using Bars.Properties;
using Project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

using System;
using System.Globalization;
using System.Windows.Forms;
using NLog;

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
        }

        private void start_Click(object sender, EventArgs e)
        {
            var choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Close();
            logger.Info("The start button to open the next form was clicked");

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
    }
}