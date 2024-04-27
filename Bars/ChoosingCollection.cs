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
using NLog;

namespace ProjectTwo
{
    public partial class ChoosingCollection : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public DataGridViewRow SelectedRow { get; set; }
        public ChoosingCollection()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void ChoosingCollection_Load(object sender, EventArgs e)
        {
            back2.FlatStyle = FlatStyle.Flat;
            back2.FlatAppearance.BorderSize = 0;
            logger.Info("The Choosing1 form was loaded");
        }

        private void back2_Click(object sender, EventArgs e)
        {
            var recs = new YourRecomendations();
            this.Hide();
            recs.ShowDialog();
            this.Close();
            logger.Info("User clicked back button and came back to YourRecomendation form");
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
                        logger.Info("User added the position to the favourites");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");

                        logger.Error("The error in trying add the position to the favourites");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
                logger.Warn("User tried to add the position to the favourites but didn't choose the line");
            }
        }

        
        private void UpdateButtonText()
        {
            using (var context = new CafesContext())
            {
                var matching2 = context.Matchings.FirstOrDefault(m => m.Id == 2);
                var matching3 = context.Matchings.FirstOrDefault(m => m.Id == 3);
                var matching4 = context.Matchings.FirstOrDefault(m => m.Id == 4);
                var matching5 = context.Matchings.FirstOrDefault(m => m.Id == 5);
                var matching6 = context.Matchings.FirstOrDefault(m => m.Id == 6);
                if (matching2 != null)
                {
                    two1.Text = matching2.Title;

                    logger.Info("The label was renamed");
                }
                else
                {
                    two1.Text = "";
                }
                if (matching3 != null)
                {
                    three1.Text = matching3.Title;
                    logger.Info("The label was renamed");
                }
                else
                {
                    three1.Text = "";
                }
                if (matching4 != null)
                {
                    four1.Text = matching4.Title;
                    logger.Info("The label was renamed");
                }
                else
                {
                    four1.Text = "";
                }
                if (matching5 != null)
                {
                    five1.Text = matching5.Title;
                    logger.Info("The label was renamed");
                }
                else
                {
                    five1.Text = "";
                }
                if (matching6 != null)
                {
                    six1.Text = matching6.Title;
                    logger.Info("The label was renamed");
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
                        logger.Info("User added the position to the first matching");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                        logger.Error("The error in saving changes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
                logger.Warn("User tried to add the position to the matching but it wasn't succesful");
            }
            logger.Info("User clicked to the two1 button");

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
                        logger.Info("User added the position to the second matching");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                        logger.Error("The error in saving changes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
                logger.Warn("User tried to add the position to the matching but it wasn't succesful");
            }
            logger.Info("User clicked to the three1 button");
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
                        logger.Info("User added the position to the third matching");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                        logger.Error("The error in saving changes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
                logger.Warn("User tried to add the position to the matching but it wasn't succesful");
            }
            logger.Info("User clicked to the four1 button");
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
                        logger.Info("User added the position to the fourth matching");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                        logger.Error("The error in saving changes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
                logger.Warn("User tried to add the position to the matching but it wasn't succesful");
            }
            logger.Info("User clicked to the five1 button");
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

                        logger.Info("User added the position to the fifth matching");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                        logger.Error("The error in saving changes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки для обновления.");
                logger.Warn("User tried to add the position to the matching but it wasn't succesful");
            }
            logger.Info("User clicked to the six1 button");
        }
        
    }
}
