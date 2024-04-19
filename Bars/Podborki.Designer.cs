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
            addtofav = new CheckBox();
            like = new Button();
            dislike = new Button();
            mark = new Label();
            description2 = new Label();
            photo = new PictureBox();
            name = new Label();
            add = new Button();
            throwoff = new Button();
            list2 = new DataGridView();
            podborka = new Label();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)list2).BeginInit();
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
            // addtofav
            // 
            addtofav.AutoSize = true;
            addtofav.BackColor = Color.FromArgb(136, 92, 64);
            addtofav.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addtofav.ForeColor = Color.NavajoWhite;
            addtofav.Location = new Point(1002, 680);
            addtofav.Name = "addtofav";
            addtofav.RightToLeft = RightToLeft.Yes;
            addtofav.Size = new Size(355, 45);
            addtofav.TabIndex = 26;
            addtofav.Text = "Добавить в избранное";
            addtofav.UseVisualStyleBackColor = false;
            // 
            // like
            // 
            like.BackColor = Color.FromArgb(136, 92, 64);
            like.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            like.ForeColor = Color.NavajoWhite;
            like.Location = new Point(1334, 587);
            like.Name = "like";
            like.Size = new Size(56, 46);
            like.TabIndex = 25;
            like.Text = "👍";
            like.UseVisualStyleBackColor = false;
            // 
            // dislike
            // 
            dislike.BackColor = Color.FromArgb(136, 92, 64);
            dislike.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dislike.ForeColor = Color.NavajoWhite;
            dislike.Location = new Point(1272, 587);
            dislike.Name = "dislike";
            dislike.Size = new Size(56, 46);
            dislike.TabIndex = 24;
            dislike.Text = "👎";
            dislike.UseVisualStyleBackColor = false;
            // 
            // mark
            // 
            mark.AllowDrop = true;
            mark.AutoEllipsis = true;
            mark.AutoSize = true;
            mark.BackColor = Color.FromArgb(136, 92, 64);
            mark.Enabled = false;
            mark.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mark.ForeColor = Color.Moccasin;
            mark.Location = new Point(953, 587);
            mark.Name = "mark";
            mark.Size = new Size(437, 46);
            mark.TabIndex = 23;
            mark.Text = "Оценкаㅤㅤㅤㅤㅤㅤㅤㅤㅤ";
            // 
            // description2
            // 
            description2.BackColor = Color.NavajoWhite;
            description2.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Location = new Point(953, 353);
            description2.Name = "description2";
            description2.Size = new Size(437, 231);
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
            // add
            // 
            add.BackColor = Color.NavajoWhite;
            add.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add.ForeColor = Color.FromArgb(136, 92, 64);
            add.Location = new Point(467, 680);
            add.Name = "add";
            add.Size = new Size(236, 52);
            add.TabIndex = 19;
            add.Text = "Добавить в подборку";
            add.UseVisualStyleBackColor = false;
            // 
            // throwoff
            // 
            throwoff.BackColor = Color.NavajoWhite;
            throwoff.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            throwoff.ForeColor = Color.FromArgb(136, 92, 64);
            throwoff.Location = new Point(175, 680);
            throwoff.Name = "throwoff";
            throwoff.Size = new Size(236, 52);
            throwoff.TabIndex = 18;
            throwoff.Text = "Сбросить предпочтения";
            throwoff.UseVisualStyleBackColor = false;
            // 
            // list2
            // 
            list2.BackgroundColor = Color.FromArgb(136, 92, 64);
            list2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list2.Location = new Point(175, 142);
            list2.Name = "list2";
            list2.RowHeadersWidth = 51;
            list2.Size = new Size(528, 507);
            list2.TabIndex = 17;
            list2.CellContentClick += list2_CellContentClick;
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
            Controls.Add(addtofav);
            Controls.Add(like);
            Controls.Add(dislike);
            Controls.Add(mark);
            Controls.Add(description2);
            Controls.Add(photo);
            Controls.Add(name);
            Controls.Add(add);
            Controls.Add(throwoff);
            Controls.Add(list2);
            Name = "Podborki";
            Text = "Подборки";
            Load += Podborki_Load;
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)list2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private CheckBox addtofav;
        private Button like;
        private Button dislike;
        private Label mark;
        private Label description2;
        private PictureBox photo;
        private Label name;
        private Button add;
        private Button throwoff;
        private DataGridView list2;
        public Label podborka;
    }
}