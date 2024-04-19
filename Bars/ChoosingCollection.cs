using Bars;
using DZ;
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
    public partial class ChoosingCollection : Form
    {
        public ChoosingCollection()
        {
            InitializeComponent();
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
            Podborki podborkiForm = new Podborki();
            this.Hide();
            podborkiForm.podborka.Text = "Избранное";
            podborkiForm.ShowDialog();
            this.Show();
        }
    }
}
