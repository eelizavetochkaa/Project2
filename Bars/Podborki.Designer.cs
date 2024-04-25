namespace Bars
{
    partial class Podborki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podborki));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            back = new Button();
            description2 = new Label();
            photo = new PictureBox();
            name = new Label();
            list3 = new DataGridView();
            podborka = new Label();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)list3).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            resources.ApplyResources(back, "back");
            back.ForeColor = Color.NavajoWhite;
            back.Name = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // description2
            // 
            description2.BackColor = Color.NavajoWhite;
            resources.ApplyResources(description2, "description2");
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Name = "description2";
            // 
            // photo
            // 
            photo.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(photo, "photo");
            photo.Name = "photo";
            photo.TabStop = false;
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.BackColor = Color.NavajoWhite;
            name.ForeColor = Color.FromArgb(136, 92, 64);
            name.Name = "name";
            // 
            // list3
            // 
            list3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            list3.BackgroundColor = Color.FromArgb(136, 92, 64);
            list3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list3.GridColor = Color.Tan;
            resources.ApplyResources(list3, "list3");
            list3.Name = "list3";
            list3.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            list3.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            // 
            // podborka
            // 
            resources.ApplyResources(podborka, "podborka");
            podborka.BackColor = Color.NavajoWhite;
            podborka.ForeColor = Color.FromArgb(136, 92, 64);
            podborka.Name = "podborka";
            // 
            // delete
            // 
            delete.BackColor = Color.NavajoWhite;
            resources.ApplyResources(delete, "delete");
            delete.ForeColor = Color.FromArgb(136, 92, 64);
            delete.Name = "delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Podborki
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delete);
            Controls.Add(podborka);
            Controls.Add(back);
            Controls.Add(description2);
            Controls.Add(photo);
            Controls.Add(name);
            Controls.Add(list3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Podborki";
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)list3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label description2;
        private PictureBox photo;
        private Label name;
        public Label podborka;
        public DataGridView list3;
        private Button delete;
    }
}