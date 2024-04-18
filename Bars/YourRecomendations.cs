using Bars;
using Project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectTwo
{

    public partial class YourRecomendations : Form
    {
        private CafesContext dbContext;
        private string _lastClickedValue;
        private int _clickCount;
        public YourRecomendations()
        {
            InitializeComponent();
            dbContext = new CafesContext();

        }

        private void LoadDataFromDatabase()
        {
            using (var context = new CafesContext())
            {
                try
                {
                    var doskiBar = context.Bars.FirstOrDefault(b => b.Name == "DOSKI" && b.Mark == 1);
                    var sky8 = context.Bars.FirstOrDefault(b => b.Name == "Sky8" && b.Mark == 1);
                    var moremore = context.Bars.FirstOrDefault(b => b.Name == "More&More" && b.Mark == 1);

                    var cheseria = context.Bars.FirstOrDefault(b => b.Name == "Cheseria" && b.Mark == 1);
                    var saltbar = context.Bars.FirstOrDefault(b => b.Name == "Соль" && b.Mark == 1);
                    var friendsbar = context.Bars.FirstOrDefault(b => b.Name == "Friends" && b.Mark == 1);

                    List<Bar> barsToDisplay = new List<Bar>();

                    if (doskiBar != null)
                    {
                        var iq = context.Bars.FirstOrDefault(b => b.Name == "IQ");
                        if (iq != null)
                        {
                            barsToDisplay.Add(iq);
                        }
                    }

                    if (sky8 != null)
                    {
                        var roofBar = context.Bars.FirstOrDefault(b => b.Name == "На крыше");
                        if (roofBar != null)
                        {
                            barsToDisplay.Add(roofBar);
                        }
                    }
                    if (moremore != null)
                    {
                        var marus = context.Bars.FirstOrDefault(b => b.Name == "Марусовка");
                        if (marus != null)
                        {
                            barsToDisplay.Add(marus);
                        }
                    }

                    if (cheseria != null)
                    {
                        var syr = context.Bars.FirstOrDefault(b => b.Name == "Сыроварня ");
                        if (syr != null)
                        {
                            barsToDisplay.Add(syr);
                        }
                    }

                    if (saltbar != null)
                    {
                        var shtof = context.Bars.FirstOrDefault(b => b.Name == "Штофъ");
                        if (shtof != null)
                        {
                            barsToDisplay.Add(shtof);
                        }
                    }
                    if (friendsbar != null)
                    {
                        var green = context.Bars.FirstOrDefault(b => b.Name == "Green Bottles");
                        if (green != null)
                        {
                            barsToDisplay.Add(green);
                        }
                    }
                    if (barsToDisplay.Count > 0)
                    {
                        list2.DataSource = barsToDisplay;
                        list2.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            ChoosingCollection choosing = new ChoosingCollection();
            this.Hide();
            choosing.ShowDialog();
            this.Show();
        }

        private void YourRecomendations_Load(object sender, EventArgs e)
        {
            like.FlatStyle = FlatStyle.Flat;
            like.FlatAppearance.BorderSize = 0;
            dislike.FlatStyle = FlatStyle.Flat;
            dislike.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
            LoadDataFromDatabase();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Choosing1 choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Show();
        }

        private void throwoff_Click(object sender, EventArgs e)
        {
            Choosing1 choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Show();
        }

        private void spisok_Click(object sender, EventArgs e)
        {

        }
        private void list2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mark_Click(object sender, EventArgs e)
        {
            

        }

        private void addtofav_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {
                if (addtofav.Checked && list2.SelectedRows.Count > 0)
                {
                    var selectedRow = list2.SelectedRows[0];
                    var bar = (Bar)selectedRow.DataBoundItem;
                    bar.Matching = 1;
                    context.SaveChanges();
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("Not succesful");
                }
            }
        }
    }
}
