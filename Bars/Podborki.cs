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
                    list3.DataSource = bars;
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

        private void Podborki_Load(object sender, EventArgs e)
        {

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
                            Choosing1 choose1Form = new Choosing1();
                            this.Hide();
                            choose1Form.ShowDialog();
                            this.Show();
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
    }
}
