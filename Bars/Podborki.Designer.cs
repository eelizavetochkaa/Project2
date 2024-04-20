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
            back = new Button();
            description2 = new Label();
            photo = new PictureBox();
            name = new Label();
            list3 = new DataGridView();
            podborka = new Label();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)list3).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.ForeColor = Color.NavajoWhite;
            back.Location = new Point(53, 18);
            back.Name = "back";
            back.Size = new Size(62, 78);
            back.TabIndex = 27;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // description2
            // 
            description2.BackColor = Color.NavajoWhite;
            description2.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Location = new Point(953, 353);
            description2.Name = "description2";
            description2.Size = new Size(437, 296);
            description2.TabIndex = 22;
            description2.Text = "Описание";
            description2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // photo
            // 
            photo.BackColor = Color.FromArgb(136, 92, 64);
            photo.Location = new Point(953, 126);
            photo.Name = "photo";
            photo.Size = new Size(437, 224);
            photo.SizeMode = PictureBoxSizeMode.Zoom;
            photo.TabIndex = 21;
            photo.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.NavajoWhite;
            name.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name.ForeColor = Color.FromArgb(136, 92, 64);
            name.Location = new Point(1070, 60);
            name.Name = "name";
            name.Size = new Size(171, 46);
            name.TabIndex = 20;
            name.Text = "Название";
            // 
            // list3
            // 
            list3.BackgroundColor = Color.FromArgb(136, 92, 64);
            list3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list3.Location = new Point(175, 142);
            list3.Name = "list3";
            list3.RowHeadersWidth = 51;
            list3.Size = new Size(528, 507);
            list3.TabIndex = 17;
            list3.CellContentClick += list2_CellContentClick;
            // 
            // podborka
            // 
            podborka.AutoSize = true;
            podborka.BackColor = Color.NavajoWhite;
            podborka.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            podborka.ForeColor = Color.FromArgb(136, 92, 64);
            podborka.Location = new Point(353, 72);
            podborka.Name = "podborka";
            podborka.Size = new Size(106, 46);
            podborka.TabIndex = 28;
            podborka.Text = "label1";
            // 
            // Podborki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1443, 750);
            Controls.Add(podborka);
            Controls.Add(back);
            Controls.Add(description2);
            Controls.Add(photo);
            Controls.Add(name);
            Controls.Add(list3);
            Name = "Podborki";
            Load += Podborki_Load;
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
    }
}