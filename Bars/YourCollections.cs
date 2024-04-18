using Bars;
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
            Podborki podborkiForm = new Podborki();
            this.Hide();
            podborkiForm.podborka.Text = "Избранное";
            podborkiForm.ShowDialog();
            this.Show();
        }

    }
}
