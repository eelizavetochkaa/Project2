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
    public partial class AddCollections : Form
    {
        private CafesContext context;
        public AddCollections()
        {
            InitializeComponent();
            context = new CafesContext();
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
            
            string collectionTitle = NameColl.Text;

            if (!string.IsNullOrWhiteSpace(collectionTitle))
            {
                int maxId = context.Matchings.Max(m => m.Id);
                if (maxId < 6)
                {
                    var newCollection = new Matching
                    {
                        Id = maxId + 1,
                        Title = collectionTitle
                    };

                    context.Matchings.Add(newCollection);

                    context.SaveChanges();

                    MessageBox.Show("Подборка успешно добавлена.");
                    YourCollections colls = new YourCollections();
                    this.Hide();
                    colls.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Извините, нельзя создать больше 5 подборок");
                }
            }
            else
            {
                MessageBox.Show("Введите название подборки.");
            }
        }

        private void AddCollections_Load(object sender, EventArgs e)
        {
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
            
        }
    }

}
