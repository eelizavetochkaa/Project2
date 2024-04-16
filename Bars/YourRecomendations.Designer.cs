namespace ProjectTwo
{
    partial class YourRecomendations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourRecomendations));
            spisok = new Label();
            list2 = new DataGridView();
            throwoff = new Button();
            add = new Button();
            name = new Label();
            photo = new PictureBox();
            description2 = new Label();
            mark = new Label();
            dislike = new Button();
            like = new Button();
            addtofav = new CheckBox();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)list2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            SuspendLayout();
            // 
            // spisok
            // 
            spisok.AutoSize = true;
            spisok.BackColor = Color.NavajoWhite;
            spisok.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            spisok.ForeColor = Color.FromArgb(136, 92, 64);
            spisok.Location = new Point(186, 43);
            spisok.Name = "spisok";
            spisok.Size = new Size(385, 46);
            spisok.TabIndex = 1;
            spisok.Text = "Список рекомендаций";
            spisok.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // list2
            // 
            list2.BackgroundColor = Color.FromArgb(136, 92, 64);
            list2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list2.Location = new Point(122, 125);
            list2.Name = "list2";
            list2.RowHeadersWidth = 51;
            list2.Size = new Size(528, 507);
            list2.TabIndex = 2;
            // 
            // throwoff
            // 
            throwoff.BackColor = Color.NavajoWhite;
            throwoff.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            throwoff.ForeColor = Color.FromArgb(136, 92, 64);
            throwoff.Location = new Point(122, 663);
            throwoff.Name = "throwoff";
            throwoff.Size = new Size(236, 52);
            throwoff.TabIndex = 3;
            throwoff.Text = "Сбросить предпочтения";
            throwoff.UseVisualStyleBackColor = false;
            throwoff.Click += throwoff_Click;
            // 
            // add
            // 
            add.BackColor = Color.NavajoWhite;
            add.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add.ForeColor = Color.FromArgb(136, 92, 64);
            add.Location = new Point(414, 663);
            add.Name = "add";
            add.Size = new Size(236, 52);
            add.TabIndex = 4;
            add.Text = "Добавить в подборку";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.NavajoWhite;
            name.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name.ForeColor = Color.FromArgb(136, 92, 64);
            name.Location = new Point(1017, 43);
            name.Name = "name";
            name.Size = new Size(171, 46);
            name.TabIndex = 8;
            name.Text = "Название";
            // 
            // photo
            // 
            photo.BackColor = Color.FromArgb(136, 92, 64);
            photo.Location = new Point(900, 109);
            photo.Name = "photo";
            photo.Size = new Size(437, 224);
            photo.TabIndex = 9;
            photo.TabStop = false;
            // 
            // description2
            // 
            description2.AutoSize = true;
            description2.BackColor = Color.NavajoWhite;
            description2.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Location = new Point(1017, 393);
            description2.Name = "description2";
            description2.Size = new Size(181, 46);
            description2.TabIndex = 10;
            description2.Text = "Описание";
            description2.TextAlign = ContentAlignment.MiddleCenter;
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
            mark.Location = new Point(900, 570);
            mark.Name = "mark";
            mark.Size = new Size(437, 46);
            mark.TabIndex = 11;
            mark.Text = "Оценкаㅤㅤㅤㅤㅤㅤㅤㅤㅤ";
            // 
            // dislike
            // 
            dislike.BackColor = Color.FromArgb(136, 92, 64);
            dislike.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dislike.ForeColor = Color.NavajoWhite;
            dislike.Location = new Point(1219, 570);
            dislike.Name = "dislike";
            dislike.Size = new Size(56, 46);
            dislike.TabIndex = 12;
            dislike.Text = "👎";
            dislike.UseVisualStyleBackColor = false;
            // 
            // like
            // 
            like.BackColor = Color.FromArgb(136, 92, 64);
            like.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            like.ForeColor = Color.NavajoWhite;
            like.Location = new Point(1281, 570);
            like.Name = "like";
            like.Size = new Size(56, 46);
            like.TabIndex = 13;
            like.Text = "👍";
            like.UseVisualStyleBackColor = false;
            // 
            // addtofav
            // 
            addtofav.AutoSize = true;
            addtofav.BackColor = Color.FromArgb(136, 92, 64);
            addtofav.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addtofav.ForeColor = Color.NavajoWhite;
            addtofav.Location = new Point(949, 663);
            addtofav.Name = "addtofav";
            addtofav.RightToLeft = RightToLeft.Yes;
            addtofav.Size = new Size(355, 45);
            addtofav.TabIndex = 14;
            addtofav.Text = "Добавить в избранное";
            addtofav.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.ForeColor = Color.NavajoWhite;
            back.Location = new Point(0, 1);
            back.Name = "back";
            back.Size = new Size(62, 78);
            back.TabIndex = 15;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // YourRecomendations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1443, 750);
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
            Controls.Add(spisok);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "YourRecomendations";
            Text = "YourRecomendations";
            Load += YourRecomendations_Load;
            ((System.ComponentModel.ISupportInitialize)list2).EndInit();
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label spisok;
        private DataGridView list2;
        private Button throwoff;
        private Button add;
        private Label name;
        private PictureBox photo;
        private Label description2;
        private Label mark;
        private Button dislike;
        private Button like;
        private CheckBox addtofav;
        private Button back;
    }
}