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

namespace DZ
{
    public partial class Cafe : Form
    {

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
            Choosing1 choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Show();

        }


        private void description_Click(object sender, EventArgs e)
        {

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
        }

        private void Cafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Settings.Default.Save();
        }
    }
}
