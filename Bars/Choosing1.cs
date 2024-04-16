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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project2
{
   
    public partial class Choosing1 : Form
    {
        private int restaurantId;
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
            string connectionString = "Data Source=D:\\ProjectTwo2\\Bars\\Cafes.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM bars";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            list.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }
        private void Choosing1_Load(object sender, EventArgs e)
        {
            like.FlatStyle = FlatStyle.Flat;
            like.FlatAppearance.BorderSize = 0;
            dislike.FlatStyle = FlatStyle.Flat;
            dislike.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
        }

        private void photo_Click(object sender, EventArgs e)
        {

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
                int columnIndex1 = 1;
                int columnIndex2 = 2;
                int columnIndex4 = 4;
                int columnIndex5 = 5;
                int restaurantID = Convert.ToInt32(list.Rows[e.RowIndex].Cells[0].Value);

                string column1 = list.Rows[e.RowIndex].Cells[columnIndex1].Value.ToString();
                string column2 = list.Rows[e.RowIndex].Cells[columnIndex2].Value.ToString();
                string column4 = list.Rows[e.RowIndex].Cells[columnIndex4].Value.ToString();
                string column5 = list.Rows[e.RowIndex].Cells[columnIndex5].Value.ToString();

                name.Text = column1;
                description2.Text = column2;

            }
        }
        //кнопка показать рекомендации
        private void show_Click(object sender, EventArgs e)
        {
            YourRecomendations recomends = new YourRecomendations();
            this.Hide();
            recomends.ShowDialog();
            this.Show();
        }
        //кнопка ваши подборки
        private void yours_Click(object sender, EventArgs e)
        {
            YourCollections colls = new YourCollections();
            this.Hide();
            colls.ShowDialog();
            this.Show();
        }
        //кнопка назад
        private void back_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            this.Hide();
            cafe.ShowDialog();
            this.Show();
        }

        private void list_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Choosing1_Load_1(object sender, EventArgs e)
        {

        }
        //кнопка дизлайк
        private void dislike_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count >= 0)
            {
                UpdateMark(restaurantId, 2);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        //кнопка лайк
        private void like_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count >= 0)
            {
                UpdateMark(restaurantId, 1);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void UpdateMark(int restaurantId, int voteOption)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = D:\\ProjectTwo2\\Bars\\Cafes.db; Version = 3; "))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE bars SET Mark = @Mark WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Mark", voteOption);
                    command.Parameters.AddWithValue("@Id", restaurantId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
