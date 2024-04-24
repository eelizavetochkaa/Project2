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
            resources.ApplyResources(spisok, "spisok");
            spisok.BackColor = Color.NavajoWhite;
            spisok.ForeColor = Color.FromArgb(136, 92, 64);
            spisok.Name = "spisok";
            // 
            // list2
            // 
            resources.ApplyResources(list2, "list2");
            list2.BackgroundColor = Color.FromArgb(136, 92, 64);
            list2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list2.Name = "list2";
            // 
            // throwoff
            // 
            resources.ApplyResources(throwoff, "throwoff");
            throwoff.BackColor = Color.NavajoWhite;
            throwoff.ForeColor = Color.FromArgb(136, 92, 64);
            throwoff.Name = "throwoff";
            throwoff.UseVisualStyleBackColor = false;
            throwoff.Click += throwoff_Click;
            // 
            // add
            // 
            resources.ApplyResources(add, "add");
            add.BackColor = Color.NavajoWhite;
            add.ForeColor = Color.FromArgb(136, 92, 64);
            add.Name = "add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.BackColor = Color.NavajoWhite;
            name.ForeColor = Color.FromArgb(136, 92, 64);
            name.Name = "name";
            // 
            // photo
            // 
            resources.ApplyResources(photo, "photo");
            photo.BackColor = Color.FromArgb(136, 92, 64);
            photo.Name = "photo";
            photo.TabStop = false;
            // 
            // description2
            // 
            resources.ApplyResources(description2, "description2");
            description2.BackColor = Color.NavajoWhite;
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Name = "description2";
            // 
            // mark
            // 
            resources.ApplyResources(mark, "mark");
            mark.AllowDrop = true;
            mark.AutoEllipsis = true;
            mark.BackColor = Color.FromArgb(136, 92, 64);
            mark.ForeColor = Color.Moccasin;
            mark.Name = "mark";
            // 
            // dislike
            // 
            resources.ApplyResources(dislike, "dislike");
            dislike.BackColor = Color.FromArgb(136, 92, 64);
            dislike.ForeColor = Color.NavajoWhite;
            dislike.Name = "dislike";
            dislike.UseVisualStyleBackColor = false;
            // 
            // like
            // 
            resources.ApplyResources(like, "like");
            like.BackColor = Color.FromArgb(136, 92, 64);
            like.ForeColor = Color.NavajoWhite;
            like.Name = "like";
            like.UseVisualStyleBackColor = false;
            // 
            // addtofav
            // 
            resources.ApplyResources(addtofav, "addtofav");
            addtofav.BackColor = Color.FromArgb(136, 92, 64);
            addtofav.ForeColor = Color.NavajoWhite;
            addtofav.Name = "addtofav";
            addtofav.UseVisualStyleBackColor = false;
            addtofav.CheckedChanged += addtofav_CheckedChanged;
            // 
            // back
            // 
            resources.ApplyResources(back, "back");
            back.BackColor = Color.Transparent;
            back.ForeColor = Color.NavajoWhite;
            back.Name = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // YourRecomendations
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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