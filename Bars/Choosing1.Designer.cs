namespace Project2
{
    partial class Choosing1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choosing1));
            choose1 = new Label();
            list = new DataGridView();
            show = new Button();
            yours = new Button();
            like = new Button();
            dislike = new Button();
            mark = new Label();
            name = new Label();
            photo = new PictureBox();
            description2 = new Label();
            addtofav = new CheckBox();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            SuspendLayout();
            // 
            // choose1
            // 
            choose1.AutoSize = true;
            choose1.BackColor = Color.NavajoWhite;
            choose1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            choose1.ForeColor = Color.FromArgb(136, 92, 64);
            choose1.Location = new Point(153, 29);
            choose1.Name = "choose1";
            choose1.Size = new Size(445, 92);
            choose1.TabIndex = 0;
            choose1.Text = "Выберите понравившиеся \r\nзаведения";
            choose1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // list
            // 
            list.BackgroundColor = Color.FromArgb(136, 92, 64);
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(105, 144);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(528, 507);
            list.TabIndex = 1;
            // 
            // show
            // 
            show.BackColor = Color.NavajoWhite;
            show.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            show.ForeColor = Color.FromArgb(136, 92, 64);
            show.Location = new Point(105, 676);
            show.Name = "show";
            show.Size = new Size(236, 52);
            show.TabIndex = 2;
            show.Text = "Показать рекомендации";
            show.UseVisualStyleBackColor = false;
            show.Click += show_Click_1;
            // 
            // yours
            // 
            yours.BackColor = Color.NavajoWhite;
            yours.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yours.ForeColor = Color.FromArgb(136, 92, 64);
            yours.Location = new Point(388, 676);
            yours.Name = "yours";
            yours.Size = new Size(245, 52);
            yours.TabIndex = 3;
            yours.Text = "Ваши подборки";
            yours.UseVisualStyleBackColor = false;
            yours.Click += yours_Click_1;
            // 
            // like
            // 
            like.BackColor = Color.FromArgb(136, 92, 64);
            like.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            like.ForeColor = Color.NavajoWhite;
            like.Location = new Point(1297, 605);
            like.Name = "like";
            like.Size = new Size(56, 46);
            like.TabIndex = 4;
            like.Text = "👍";
            like.UseVisualStyleBackColor = false;
            like.Click += like_Click;
            // 
            // dislike
            // 
            dislike.BackColor = Color.FromArgb(136, 92, 64);
            dislike.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dislike.ForeColor = Color.NavajoWhite;
            dislike.Location = new Point(1235, 605);
            dislike.Name = "dislike";
            dislike.Size = new Size(56, 46);
            dislike.TabIndex = 5;
            dislike.Text = "👎";
            dislike.UseVisualStyleBackColor = false;
            dislike.Click += dislike_Click;
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
            mark.Location = new Point(940, 605);
            mark.Name = "mark";
            mark.Size = new Size(437, 46);
            mark.TabIndex = 6;
            mark.Text = "Оценкаㅤㅤㅤㅤㅤㅤㅤㅤㅤ";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.NavajoWhite;
            name.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name.ForeColor = Color.FromArgb(136, 92, 64);
            name.Location = new Point(1060, 53);
            name.Name = "name";
            name.Size = new Size(171, 46);
            name.TabIndex = 7;
            name.Text = "Название";
            // 
            // photo
            // 
            photo.BackColor = Color.FromArgb(136, 92, 64);
            photo.BackgroundImageLayout = ImageLayout.Stretch;
            photo.Location = new Point(940, 144);
            photo.Name = "photo";
            photo.Size = new Size(437, 224);
            photo.SizeMode = PictureBoxSizeMode.Zoom;
            photo.TabIndex = 8;
            photo.TabStop = false;
            photo.Click += photo_Click;
            // 
            // description2
            // 
            description2.AutoEllipsis = true;
            description2.BackColor = Color.NavajoWhite;
            description2.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Location = new Point(940, 371);
            description2.Name = "description2";
            description2.Size = new Size(437, 231);
            description2.TabIndex = 9;
            description2.Text = "Описание";
            description2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addtofav
            // 
            addtofav.AutoSize = true;
            addtofav.BackColor = Color.FromArgb(136, 92, 64);
            addtofav.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addtofav.ForeColor = Color.NavajoWhite;
            addtofav.Location = new Point(940, 676);
            addtofav.Name = "addtofav";
            addtofav.RightToLeft = RightToLeft.Yes;
            addtofav.Size = new Size(355, 45);
            addtofav.TabIndex = 10;
            addtofav.Text = "Добавить в избранное";
            addtofav.UseVisualStyleBackColor = false;
            addtofav.CheckedChanged += addtofav_CheckedChanged;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.ForeColor = Color.NavajoWhite;
            back.Location = new Point(2, 2);
            back.Name = "back";
            back.Size = new Size(62, 78);
            back.TabIndex = 11;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click_1;
            // 
            // Choosing1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1443, 750);
            Controls.Add(back);
            Controls.Add(addtofav);
            Controls.Add(description2);
            Controls.Add(photo);
            Controls.Add(name);
            Controls.Add(dislike);
            Controls.Add(like);
            Controls.Add(yours);
            Controls.Add(show);
            Controls.Add(list);
            Controls.Add(choose1);
            Controls.Add(mark);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Choosing1";
            Load += Choosing1_Load_1;
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label choose1;
        private DataGridView list;
        private Button show;
        private Button yours;
        private Button like;
        private Button dislike;
        private Label mark;
        private Label name;
        private PictureBox photo;
        private Label description2;
        private CheckBox addtofav;
        private Button back;
    }
}