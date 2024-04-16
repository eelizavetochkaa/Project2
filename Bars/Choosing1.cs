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
                restaurantId = Convert.ToInt32(list.Rows[e.RowIndex].Cells[0].Value);

                string column1 = list.Rows[e.RowIndex].Cells[columnIndex1].Value?.ToString();
                string column2 = list.Rows[e.RowIndex].Cells[columnIndex2].Value?.ToString();
                string column4 = list.Rows[e.RowIndex].Cells[columnIndex4].Value?.ToString();
                string column5 = list.Rows[e.RowIndex].Cells[columnIndex5].Value?.ToString();

                name.Text = column1;
                description2.Text = column2;
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
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=D:\\ProjectTwo2\\Bars\\Cafes.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE bars SET Mark = @Mark WHERE Id = @Id";
                    command.Parameters.Add("@Mark", DbType.Int32).Value = voteOption;
                    command.Parameters.Add("@Id", DbType.Int32).Value = restaurantId;
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0 && voteOption==2)
                    {
                        MessageBox.Show("Вы поставили 👎 этой позиции");
                    }
                    else if(rowsAffected > 0 && voteOption==1)
                    {
                        MessageBox.Show("Вы поставили 👍 этой позиции");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при обновлении значения в столбце Mark.");
                    }
                }
                connection.Close();
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
    }
}
