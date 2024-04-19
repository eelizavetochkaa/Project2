using Project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bars
{
    public partial class Podborki : Form
    {
        public Podborki()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Choosing1 choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Show();
        }

        private void LoadDataFromDatabase()
        {
            using (var context = new CafesContext())
            {
                try
                {
                    var bars = context.Bars.Where(b => b.Matching == 1).ToList();
                    list2.DataSource = bars;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }

        private void list2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
