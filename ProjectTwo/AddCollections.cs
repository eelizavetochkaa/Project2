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
    public partial class AddCollections : Form
    {
        public AddCollections()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            YourCollections colls = new YourCollections();
            this.Hide();
            colls.ShowDialog();
            this.Show();
        }

        private void createcoll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подборка добавлена в ваши подборки!");
            YourCollections colls = new YourCollections();
            this.Hide();
            colls.ShowDialog();
            this.Show();
        }

        private void AddCollections_Load(object sender, EventArgs e)
        {
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
        }
    }
}
