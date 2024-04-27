using NLog;
using Project2;
using System;
using System.Collections;
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
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private CafesContext context;
        public int restaurantId;
        public Podborki()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            list3.CellMouseDoubleClick += list2_CellMouseDoubleClick;
            context = new CafesContext();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Close();
        }

        private void LoadDataFromDatabase()
        {
            using (var context = new CafesContext())
            {
                string matchingTitle = podborka.Text;
                var matching = context.Matchings.FirstOrDefault(m => m.Title == matchingTitle);
                if (matching != null)
                {
                    restaurantId = matching.Id;
                }
                var bars = (from b in context.Bars
                            join m in context.Matchings on b.Matching equals m.Id
                            where m.Title == matchingTitle
                            select b).ToList();

                list3.DataSource = bars;
            }
        }
        private void list2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex0 = 0;
                int columnIndex1 = 1;
                int columnIndex2 = 2;
                int columnIndex4 = 4;
                int columnIndex5 = 5;
                restaurantId = Convert.ToInt32(list3.Rows[e.RowIndex].Cells[0].Value);

                string column0 = list3.Rows[e.RowIndex].Cells[columnIndex1].Value?.ToString();
                string column1 = list3.Rows[e.RowIndex].Cells[columnIndex1].Value?.ToString();
                string column2 = list3.Rows[e.RowIndex].Cells[columnIndex2].Value?.ToString();
                string column4 = list3.Rows[e.RowIndex].Cells[columnIndex4].Value?.ToString();
                string column5 = list3.Rows[e.RowIndex].Cells[columnIndex5].Value?.ToString();

                name.Text = column1;
                description2.Text = column2;
                using (var context = new CafesContext())
                {
                    var entity = context.Bars.Find(restaurantId);

                    if (entity != null && entity.Photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(entity.Photo))
                        {
                            var image = Image.FromStream(ms);
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

        private void delete_Click(object sender, EventArgs e)
        {
            string title = podborka.Text;
            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить подборку '{title}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && podborka.Text != "Избранное")
            {
                try
                {
                    using (var context = new CafesContext())
                    {
                        var matching = context.Matchings.FirstOrDefault(m => m.Title == title);

                        if (matching != null)
                        {
                            var relatedEntities = context.Bars.Where(re => re.Matching == matching.Id);
                            context.Bars.RemoveRange(relatedEntities);
                            context.Matchings.Remove(matching);
                            context.SaveChanges();
                            MessageBox.Show("Подборка успешно удалена");
                            var choose1Form = new Choosing1();
                            this.Hide();
                            choose1Form.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Подборка не найдена в базе данных");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Подборку избранное удалить нельзя!");
            }
        }

        private void Podborki_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();

            try
            {
                foreach (DataGridViewColumn column in list3.Columns)
                {
                    column.Visible = false;
                }

                list3.Columns[1].Visible = true;
                list3.Columns[2].Visible = true;
                list3.Columns[4].Visible = true;
                list3.Columns[6].Visible = true;
                list3.Columns[7].Visible = true;
                list3.Columns[8].Visible = true;
                logger.Info("User tried to load Podborki form");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке {ex}");
                logger.Error("The error with trying to load this form");
            }
            logger.Info("The Podborki form was loaded");
        }
    }
}
