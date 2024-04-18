using Bars;
using DZ;
using ProjectTwo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project2
{

    public partial class Choosing1 : Form
    {
        public int restaurantId;
        public Choosing1()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            like.Click += like_Click;
            dislike.Click += dislike_Click;
            list.CellMouseDoubleClick += list_CellMouseDoubleClick;
        }

        //работа с БД
        private void LoadDataFromDatabase()
        {
            using (var context = new CafesContext())
            {
                try
                {
                    var bars = context.Bars.Where(b => b.Type == "для выбора").ToList();
                    list.DataSource = bars;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }

        public string GetSelectedData(int columnIndex)
        {
            if (list.SelectedCells.Count > 0)
            {
                int selectedRowIndex = list.SelectedCells[0].RowIndex;
                return list.Rows[selectedRowIndex].Cells[columnIndex].Value?.ToString();
            }
            return string.Empty;
        }
        //база данных при двойном щелчке по строке
        private void list_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex0 = 0;
                int columnIndex1 = 1;
                int columnIndex2 = 2;
                int columnIndex4 = 4;
                int columnIndex5 = 5;
                restaurantId = Convert.ToInt32(list.Rows[e.RowIndex].Cells[0].Value);

                string column0 = list.Rows[e.RowIndex].Cells[columnIndex1].Value?.ToString();
                string column1 = list.Rows[e.RowIndex].Cells[columnIndex1].Value?.ToString();
                string column2 = list.Rows[e.RowIndex].Cells[columnIndex2].Value?.ToString();
                string column4 = list.Rows[e.RowIndex].Cells[columnIndex4].Value?.ToString();
                string column5 = list.Rows[e.RowIndex].Cells[columnIndex5].Value?.ToString();

                name.Text = column1;
                description2.Text = column2;
                using (var context = new CafesContext())
                {
                    var entity = context.Bars.Find(restaurantId);

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

        private void dislike_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count > 0)
            {
                restaurantId = Convert.ToInt32(list.SelectedRows[0].Cells[0].Value);
                UpdateMark(restaurantId, 2);
            }
            else
            {
                MessageBox.Show("Ошибка: не выбрана строка.");
            }
        }

        private void like_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count > 0)
            {
                restaurantId = Convert.ToInt32(list.SelectedRows[0].Cells[0].Value);
                UpdateMark(restaurantId, 1);
            }
            else
            {
                MessageBox.Show("Ошибка: не выбрана строка.");
            }
        }

        private void UpdateMark(int restaurantId, int voteOption)
        {
            using (var context = new CafesContext())
            {
                var bar = context.Bars.FirstOrDefault(b => b.Id == restaurantId);
                if (bar != null)
                {
                    bar.Mark = voteOption;
                    context.SaveChanges();

                    if (voteOption == 2)
                    {
                        MessageBox.Show("Вы поставили 👎 этой позиции");
                    }
                    else if (voteOption == 1)
                    {
                        MessageBox.Show("Вы поставили 👍 этой позиции");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: не найдена запись с указанным ID.");
                }
            }

        }



        private void Choosing1_Load_1(object sender, EventArgs e)
        {
            like.FlatStyle = FlatStyle.Flat;
            like.FlatAppearance.BorderSize = 0;
            dislike.FlatStyle = FlatStyle.Flat;
            dislike.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            this.Hide();
            cafe.ShowDialog();
            this.Show();
        }

        private void show_Click_1(object sender, EventArgs e)
        {
            YourRecomendations recomends = new YourRecomendations();
            this.Hide();
            recomends.ShowDialog();
            this.Show();
        }

        private void yours_Click_1(object sender, EventArgs e)
        {
            YourCollections colls = new YourCollections();
            this.Hide();
            colls.ShowDialog();
            this.Show();
        }

        private void addtofav_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {
                if (addtofav.Checked && list.SelectedRows.Count > 0)
                {
                    var selectedRow = list.SelectedRows[0];
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
        private void DisplayImageFromDatabase()
        {
            using (var context = new CafesContext())
            {
                var entity = context.Bars.Find(1); 

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
