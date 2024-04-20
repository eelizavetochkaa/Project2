﻿using Bars;
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
            Choosing1 choose1Form = new Choosing1();
            this.Hide();
            choose1Form.ShowDialog();
            this.Show();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            AddCollections addcolls = new AddCollections();
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
                this.Show();
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
                    two.Text = "";
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
                    three.Text = "";
                }
                if (matching4 != null)
                {
                    four.Text = matching4.Title;
                }
                else
                {
                    four.Text = "";
                }
                if (matching5 != null)
                {
                    five.Text = matching5.Title;
                }
                else
                {
                    five.Text = "";
                }
                if (matching6 != null)
                {
                    six.Text = matching6.Title;
                }
                else
                {
                    six.Text = "";
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext()) ;
        }

        private void two_Click(object sender, EventArgs e)
        {
            using (var context = new CafesContext())
            {

                var two2 = context.Bars.Where(entity => entity.Matching == 2).ToList();
                Podborki podborkiForm = new Podborki();
                this.Hide();
                podborkiForm.podborka.Text = two.Text;
                podborkiForm.list3.DataSource = two2;
                podborkiForm.ShowDialog();
                this.Show();

            }
        }
    }
}
