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
            resources.ApplyResources(choose1, "choose1");
            choose1.BackColor = Color.NavajoWhite;
            choose1.ForeColor = Color.FromArgb(136, 92, 64);
            choose1.Name = "choose1";
            // 
            // list
            // 
            resources.ApplyResources(list, "list");
            list.BackgroundColor = Color.FromArgb(136, 92, 64);
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Name = "list";
            // 
            // show
            // 
            resources.ApplyResources(show, "show");
            show.BackColor = Color.NavajoWhite;
            show.ForeColor = Color.FromArgb(136, 92, 64);
            show.Name = "show";
            show.UseVisualStyleBackColor = false;
            show.Click += show_Click_1;
            // 
            // yours
            // 
            resources.ApplyResources(yours, "yours");
            yours.BackColor = Color.NavajoWhite;
            yours.ForeColor = Color.FromArgb(136, 92, 64);
            yours.Name = "yours";
            yours.UseVisualStyleBackColor = false;
            yours.Click += yours_Click_1;
            // 
            // like
            // 
            resources.ApplyResources(like, "like");
            like.BackColor = Color.FromArgb(136, 92, 64);
            like.ForeColor = Color.NavajoWhite;
            like.Name = "like";
            like.UseVisualStyleBackColor = false;
            like.Click += like_Click;
            // 
            // dislike
            // 
            resources.ApplyResources(dislike, "dislike");
            dislike.BackColor = Color.FromArgb(136, 92, 64);
            dislike.ForeColor = Color.NavajoWhite;
            dislike.Name = "dislike";
            dislike.UseVisualStyleBackColor = false;
            dislike.Click += dislike_Click;
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
            description2.AutoEllipsis = true;
            description2.BackColor = Color.NavajoWhite;
            description2.ForeColor = Color.FromArgb(136, 92, 64);
            description2.Name = "description2";
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
            back.Click += back_Click_1;
            // 
            // Choosing1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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