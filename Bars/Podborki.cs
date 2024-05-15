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
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

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

        private void back3_Click(object sender, EventArgs e)
        {
            var choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Close();
            logger.Info("User opened last Choosing1 form and clicked to back button");
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

                logger.Info("The informaton was loaded from database");
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
                        using (var ms = new MemoryStream(entity.Photo))
                        {
                            var image = Image.FromStream(ms);
                            photo.Image = image;
                        }
                        logger.Info("The image was loaded ");
                    }
                    else
                    {
                        MessageBox.Show("Изображение не найдено или недоступно");
                        logger.Info("The image wasn't loaded");
                    }
                }

                logger.Info("The information about chosen position was shown");
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

                            logger.Info("Opened matching was deleted");
                        }
                        else
                        {
                            MessageBox.Show("Подборка не найдена в базе данных");

                            logger.Warn("Opened matching wasn't found in database");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");

                    logger.Error($"Deleting error: {ex}");
                }
            }
            else
            {
                MessageBox.Show("Подборку избранное удалить нельзя!");

                logger.Warn("User tried to delete favourites");
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

        //private async void mail_Click(object sender, EventArgs e)
        //{
        //    if (!System.String.IsNullOrEmpty(EmaiBox.Text))
        //    {
        //        var titles = new List<string>();
        //        foreach (DataGridViewRow row in list3.Rows)
        //            titles.Add(row.Cells[1].Value.ToString());
        //        MailAddress from = new MailAddress , "Ешь и пей");
        //        MailAddress to = new MailAddress(EmaiBox.Text);
        //        MailMessage m = new MailMessage(from, to);

        //        m.Subject = "Подборка заведений";
        //        m.Body = "Добрый день! Отправляем вам свежую подборку заведений";
        //        try
        //        {
        //            // Метод File.WriteAllLines записывает все строки в файл
        //            File.WriteAllLines("VishList.txt", titles);
        //            Console.WriteLine($"Файл VishList.txt успешно создан.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Произошла ошибка при создании файла: {ex.Message}");
        //        }
        //        m.Attachments.Add(new Attachment(@"C:\Users\user\source\repos\Project2\Bars\bin\Debug\net7.0-windows\VishList.txt"));
        //        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 465);
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Credentials = new NetworkCredential(");
        //        smtp.EnableSsl = true;
        //        smtp.Send(m);
        //        Console.WriteLine("Письмо отправлено");
        //    }
        //}
        private async void mail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmaiBox.Text))
            {
                var titles = new List<string>();
                foreach (DataGridViewRow row in list3.Rows)
                {
                    if (row.Cells[1].Value != null) // Проверка на null
                    {
                        titles.Add(row.Cells[1].Value.ToString());
                    }
                }

                MailAddress from = new MailAddress("lafille5905@gmail.com", "Ешь и пей");
                MailAddress to = new MailAddress(EmaiBox.Text);
                MailMessage m = new MailMessage(from, to);

                m.Subject = "Подборка заведений";
                m.Body = "Добрый день! Отправляем вам свежую подборку заведений.";

                try
                {
                    // Метод File.WriteAllLines записывает все строки в файл
                    string filePath = "VishList.txt";
                    File.WriteAllLines(filePath, titles);
                    Console.WriteLine($"Файл {filePath} успешно создан.");

                    // Добавляем файл в качестве вложения
                    m.Attachments.Add(new Attachment(filePath));

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("lafille5905@gmail.com", "fogel2019");
                    smtp.EnableSsl = true;

                    await smtp.SendMailAsync(m);
                    MessageBox.Show("Письмо отправлено");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите адрес электронной почты.");
            }
        }
        //private void mail_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(EmaiBox.Text))
        //    {

        //        var titles = new List<string>();
        //        foreach (DataGridViewRow row in list3.Rows)
        //        {
        //            if (row.Cells[1].Value != null) // Проверка на null
        //            {
        //                titles.Add(row.Cells[1].Value.ToString());
        //            }
        //        }
        //        MailAddress from = new MailAddress("lafille5905@xmail.ru", "Ешь и Пей");
        //        MailAddress to = new MailAddress(EmaiBox.Text);
        //        MailMessage m = new MailMessage(from, to);

        //        m.Subject = "Подборка заведений";
        //        m.Body = "Добрый день! Отправляем вам свежую подборку заведений";
        //        m.IsBodyHtml = true;
        //        try
        //        {
        //            string filePath = "VishList.txt";
        //            File.WriteAllLines(filePath, titles);
        //            Console.WriteLine($"Файл {filePath} успешно создан.");

        //            m.Attachments.Add(new Attachment(filePath));              
        //            SmtpClient smtp = new SmtpClient("smtp.xmail.ru", 587);
        //            smtp.Credentials = new NetworkCredential("lafille5905@xmail.ru", "vRVYaKuPwzYqXfDBSN6W");
        //            smtp.EnableSsl = true;
        //            smtp.Send(m);
        //            MessageBox.Show("Письмо отправлено");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        //            MessageBox.Show($"Произошла ошибка: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Пожалуйста, введите адрес электронной почты.");
        //    }
        //}           
    }
}
