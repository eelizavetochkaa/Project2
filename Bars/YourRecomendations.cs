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
        public int restaurantId2;
        public YourRecomendations()
        {
            InitializeComponent();
            dbContext = new CafesContext();
            list2.CellMouseDoubleClick += list2_CellMouseDoubleClick;

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
            if (list2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = list2.SelectedRows[0];
                using (var choosing = new ChoosingCollection())
                {
                    choosing.SelectedRow = selectedRow;
                    this.Hide();
                    choosing.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку в DataGridView.");
            }
            
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
            var items = dbContext.Bars.ToList();
            foreach (var item in items)
            {
                item.Mark = null;
            }

            dbContext.SaveChanges();

            MessageBox.Show("Ваши предпочтения сброшены");
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
                    MessageBox.Show("Добавлено в избранное");
                }
                else
                {
                    MessageBox.Show("Не получилось доавбить в избранное. Проверьте, что точно дважды кликнули по строке из таблицы");
                }
            }
        }
        private void list2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex1 = 1;
                int columnIndex2 = 2;
                int columnIndex4 = 4;
                int columnIndex5 = 5;
                restaurantId2 = Convert.ToInt32(list2.Rows[e.RowIndex].Cells[0].Value);

                string column1 = list2.Rows[e.RowIndex].Cells[columnIndex1].Value?.ToString();
                string column2 = list2.Rows[e.RowIndex].Cells[columnIndex2].Value?.ToString();
                string column4 = list2.Rows[e.RowIndex].Cells[columnIndex4].Value?.ToString();
                string column5 = list2.Rows[e.RowIndex].Cells[columnIndex5].Value?.ToString();

                name.Text = column1;
                description2.Text = column2;
                using (var context = new CafesContext())
                {
                    var entity = context.Bars.Find(restaurantId2);

                    if (entity != null && entity.Photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(entity.Photo))
                        {
                            Image image = Image.FromStream(ms);
                            photo.Image = image;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Изображение не найдено или недоступно.");
                    }
                }
            }
        }
        
    }
}
