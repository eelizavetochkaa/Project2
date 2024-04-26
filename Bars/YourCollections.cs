using Bars;
using NLog;
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

namespace ProjectTwo
{

    public partial class YourCollections : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public YourCollections()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void YourCollections_Load(object sender, EventArgs e)
        {
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {
            var choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Close();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            var addcolls = new AddCollections();
            this.Hide();
            addcolls.ShowDialog();
            this.Show();
        }


        private void favs_Click(object sender, EventArgs e)
        {

            using (var context = new CafesContext())
            {

                var favs = context.Bars.Where(entity => entity.Matching == 1).ToList();
                Podborki podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = "Избранное";
                podborkiForm.list3.DataSource = favs;
                podborkiForm.ShowDialog();
                this.Close();
            }
        }
        private void UpdateButtonText()
        {
            using (var context = new CafesContext())
            {
                var matching = context.Matchings.FirstOrDefault(m => m.Id == 2);
                if (matching != null)
                {
                    two.Text = matching.Title;
                }
                else
                {
                    two.Text = string.Empty;
                }
                var matching3 = context.Matchings.FirstOrDefault(m => m.Id == 3);
                var matching4 = context.Matchings.FirstOrDefault(m => m.Id == 4);
                var matching5 = context.Matchings.FirstOrDefault(m => m.Id == 5);
                var matching6 = context.Matchings.FirstOrDefault(m => m.Id == 6);
                if (matching3 != null)
                {
                    three.Text = matching3.Title;
                }
                else
                {
                    three.Text = string.Empty;
                }
                if (matching4 != null)
                {
                    four.Text = matching4.Title;
                }
                else
                {
                    four.Text = string.Empty;
                }
                if (matching5 != null)
                {
                    five.Text = matching5.Title;
                }
                else
                {
                    five.Text = string.Empty;
                }
                if (matching6 != null)
                {
                    six.Text = matching6.Title;
                }
                else
                {
                    six.Text = string.Empty;
                }
            }
        }
        private void two_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {

                var two2 = context.Bars.Where(entity => entity.Matching == 2).ToList();
                var podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = two.Text;
                podborkiForm.list3.DataSource = two2;
                podborkiForm.ShowDialog();
                this.Close();
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {

                var two3 = context.Bars.Where(entity => entity.Matching == 3).ToList();
                var podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = three.Text;
                podborkiForm.list3.DataSource = two3;
                podborkiForm.ShowDialog();
                this.Close();

            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {

                var two4 = context.Bars.Where(entity => entity.Matching == 4).ToList();
                var podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = four.Text;
                podborkiForm.list3.DataSource = two4;
                podborkiForm.ShowDialog();
                this.Close();

            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {

                var two5 = context.Bars.Where(entity => entity.Matching == 5).ToList();
                var podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = five.Text;
                podborkiForm.list3.DataSource = two5;
                podborkiForm.ShowDialog();
                this.Close();
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {

                var two6 = context.Bars.Where(entity => entity.Matching == 6).ToList();
                var podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = six.Text;
                podborkiForm.list3.DataSource = two6;
                podborkiForm.ShowDialog();
                this.Close();
            }
        }
    }
}
