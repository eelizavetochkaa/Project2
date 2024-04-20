using Bars;
using DZ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ProjectTwo
{
    public partial class ChoosingCollection : Form
    {
        public DataGridViewRow SelectedRow { get; set; }
        public ChoosingCollection()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void ChoosingCollection_Load(object sender, EventArgs e)
        {

            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {
            YourRecomendations recs = new YourRecomendations();
            this.Hide();
            recs.ShowDialog();
            this.Show();
        }

        private void favs_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                SelectedRow.Cells["Matching"].Value = 1;
                var entity = (Bar)SelectedRow.DataBoundItem;
                entity.Matching = 1;

                using (var context = new CafesContext())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Modified;

                        context.SaveChanges();

                        MessageBox.Show("Вы успешно добавили позицию в избранное");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
            }
        }

        
        private void UpdateButtonText()
        {
            using (var context = new CafesContext())
            {
                var matching = context.Matchings.FirstOrDefault(m => m.Id == 2);
                if (matching != null)
                {
                    two1.Text = matching.Title;
                }
                else
                {
                    two1.Text = "";
                }
                var matching3 = context.Matchings.FirstOrDefault(m => m.Id == 3);
                var matching4 = context.Matchings.FirstOrDefault(m => m.Id == 4);
                var matching5 = context.Matchings.FirstOrDefault(m => m.Id == 5);
                var matching6 = context.Matchings.FirstOrDefault(m => m.Id == 6);
                if (matching3 != null)
                {
                    three1.Text = matching3.Title;
                }
                else
                {
                    three1.Text = "";
                }
                if (matching4 != null)
                {
                    four1.Text = matching4.Title;
                }
                else
                {
                    four1.Text = "";
                }
                if (matching5 != null)
                {
                    five1.Text = matching5.Title;
                }
                else
                {
                    five1.Text = "";
                }
                if (matching6 != null)
                {
                    six1.Text = matching6.Title;
                }
                else
                {
                    six1.Text = "";
                }
            }
        }

        private void two1_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                SelectedRow.Cells["Matching"].Value = 2;
                var entity = (Bar)SelectedRow.DataBoundItem;
                entity.Matching = 2;

                using (var context = new CafesContext())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Modified;

                        context.SaveChanges();

                        MessageBox.Show("Вы успешно добавили позицию в подборку");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
            }

        }

        private void three1_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                SelectedRow.Cells["Matching"].Value = 3;
                var entity = (Bar)SelectedRow.DataBoundItem;
                entity.Matching = 3;

                using (var context = new CafesContext())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Modified;

                        context.SaveChanges();

                        MessageBox.Show("Вы успешно добавили позицию в подборку");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
            }
        }

        private void four1_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                SelectedRow.Cells["Matching"].Value = 4;
                var entity = (Bar)SelectedRow.DataBoundItem;
                entity.Matching = 4;

                using (var context = new CafesContext())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Modified;

                        context.SaveChanges();

                        MessageBox.Show("Вы успешно добавили позицию в подборку");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
            }
        }
        private void five_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                SelectedRow.Cells["Matching"].Value = 5;
                var entity = (Bar)SelectedRow.DataBoundItem;
                entity.Matching = 5;

                using (var context = new CafesContext())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Modified;

                        context.SaveChanges();

                        MessageBox.Show("Вы успешно добавили позицию в подборку");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
            }
        }
        private void six1_Click(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                SelectedRow.Cells["Matching"].Value = 6;
                var entity = (Bar)SelectedRow.DataBoundItem;
                entity.Matching = 6;

                using (var context = new CafesContext())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Modified;

                        context.SaveChanges();

                        MessageBox.Show("Вы успешно добавили позицию в подборку");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
            }
        }
        
    }
}
