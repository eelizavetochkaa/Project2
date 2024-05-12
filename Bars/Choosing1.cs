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
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using NLog;

namespace Project2
{

    public partial class Choosing1 : Form
    {
        public int restaurantId;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Choosing1()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        //работа с БД
        public void LoadDataFromDatabase()
        {
            using (var context = new CafesContext())
            {
                try
                {
                    var bars = context.Bars.Where(b => b.Type == "для выбора").ToList();
                    list.DataSource = bars;
                    logger.Info("Data from Database was loaded");
                    var firstRow = context.authorization.FirstOrDefault();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                    logger.Error($"Data from database wasn't loaded because of next exception: {ex}");
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
        private void list_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
                            logger.Info("The image was loaded");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Изображение не найдено или недоступно.");
                        logger.Warn("The image wasn't loaded");
                    }
                }
                logger.Info("The information about chosen positions was shown");

            }
        }

        private void dislike_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count > 0)
            {
                restaurantId = Convert.ToInt32(list.SelectedRows[0].Cells[0].Value);
                UpdateMark(restaurantId, 2);
                logger.Info("User disliked the chosen position");
            }
            else
            {
                MessageBox.Show("Ошибка: не выбрана строка");
                logger.Warn("User tried to dislike the position but didn't choose the line");
            }
        }

        private void like_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count > 0)
            {
                restaurantId = Convert.ToInt32(list.SelectedRows[0].Cells[0].Value);
                UpdateMark(restaurantId, 1);
                logger.Info("User liked the chosen position");
            }
            else
            {
                MessageBox.Show("Ошибка: не выбрана строка.");
                logger.Warn("User tried to like the position but didn't choose the line");
            }
        }

        public void UpdateMark(int restaurantId, int voteOption)
        {
            using (var context = new CafesContext())
            {
                var bar = context.Bars.FirstOrDefault(b => b.Id == restaurantId);
                if (voteOption == 2)
                {
                    MessageBox.Show("Вы поставили 👎 этой позиции");
                    logger.Info("User saw message about his mark");
                }
                else if (voteOption == 1)
                {
                    MessageBox.Show("Вы поставили 👍 этой позиции");
                    logger.Info("User saw message about his mark");
                }
                bar.Mark = voteOption;
                context.SaveChanges();

                logger.Info("The information in database was updated");
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
            description2.AutoEllipsis = true;
            foreach (DataGridViewColumn column in list.Columns)
            {
                column.Visible = false;
            }

            list.Columns[1].Visible = true;
            list.Columns[2].Visible = true;
            list.Columns[4].Visible = true;
            list.Columns[6].Visible = true;
            list.Columns[7].Visible = true;
            list.Columns[8].Visible = true;
            logger.Info("The Choosing1 form was loaded");
        }
        public void back_Click_1(object sender, EventArgs e)
        {
            var cafe = new Cafe();
            this.Hide();
            cafe.ShowDialog();
            this.Close();
            logger.Info("User opened last Cafe form and click to back button");
        }
        public void show_Click_1(object sender, EventArgs e)
        {
            var recomends = new YourRecomendations();
            this.Hide();
            recomends.ShowDialog();
            this.Close();
            logger.Info("User opened next YourRecomendations form and click to show button");
        }

        public void yours_Click_1(object sender, EventArgs e)
        {
            var colls = new YourCollections();
            this.Hide();
            colls.ShowDialog();
            this.Close();
            logger.Info("User opened next YourCollections form and click to yours button");
        }

        private void addtofav_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {
                if (addtofav.Checked && list.SelectedRows.Count > 0)
                {
                    var selectedRow = list.SelectedRows[0];
                    var bar = (Bar)selectedRow.DataBoundItem;

                    if (context.Entry(bar).State == EntityState.Detached)
                    {
                        context.Bars.Attach(bar);
                    }
                    bar.Matching = 1;

                    context.SaveChanges();

                    MessageBox.Show("Добавлено в избранное");
                    logger.Info("User add the position to the favourites");
                }
                else
                {
                    MessageBox.Show("Не получилось добавить в избранное. Проверьте, что вы точно дважды кликнули по строке из таблицы.");
                    logger.Warn("User tried to add the position to the favourites but didnt' choose the line");
                }
            }
        }
    }
}
