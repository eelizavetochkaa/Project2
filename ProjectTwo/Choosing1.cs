using DZ;
using ProjectTwo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Choosing1 : Form
    {
        public Choosing1()
        {
            InitializeComponent();
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

        private void show_Click(object sender, EventArgs e)
        {
            YourRecomendations recomends = new YourRecomendations();
            this.Hide();
            recomends.ShowDialog();
            this.Show();
        }

        private void yours_Click(object sender, EventArgs e)
        {
            YourCollections colls = new YourCollections();
            this.Hide();
            colls.ShowDialog();
            this.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            this.Hide();
            cafe.ShowDialog();
            this.Show();
        }
    }
}
