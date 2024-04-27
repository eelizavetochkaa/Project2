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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            spisok = new Label();
            list2 = new DataGridView();
            throwoff = new Button();
            add = new Button();
            name = new Label();
            photo = new PictureBox();
            description2 = new Label();
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
            list2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            list2.BackgroundColor = Color.FromArgb(136, 92, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            list2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            list2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            list2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(list2, "list2");
            list2.Name = "list2";
            list2.ReadOnly = true;
            list2.CellMouseDoubleClick += list2_CellMouseDoubleClick_1;
            // 
            // throwoff
            // 
            throwoff.BackColor = Color.NavajoWhite;
            resources.ApplyResources(throwoff, "throwoff");
            throwoff.ForeColor = Color.FromArgb(136, 92, 64);
            throwoff.Name = "throwoff";
            throwoff.UseVisualStyleBackColor = false;
            throwoff.Click += throwoff_Click;
            // 
            // add
            // 
            add.BackColor = Color.NavajoWhite;
            resources.ApplyResources(add, "add");
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
            photo.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(photo, "photo");
            photo.Name = "photo";
            photo.TabStop = false;
            // 
            // description2
            // 
            description2.BackColor = Color.NavajoWhite;
            resources.ApplyResources(description2, "description2");
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
            back.BackColor = Color.Transparent;
            resources.ApplyResources(back, "back");
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
        private CheckBox addtofav;
        private Button back;
    }
}