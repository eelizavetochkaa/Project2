namespace ProjectTwo
{
    partial class YourCollections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourCollections));
            collections = new Label();
            add2 = new Button();
            favs = new Button();
            back = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            two = new Button();
            six = new Button();
            SuspendLayout();
            // 
            // collections
            // 
            collections.AutoSize = true;
            collections.BackColor = Color.NavajoWhite;
            collections.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            collections.ForeColor = Color.FromArgb(136, 92, 64);
            collections.Location = new Point(237, 66);
            collections.Name = "collections";
            collections.Size = new Size(278, 46);
            collections.TabIndex = 8;
            collections.Text = "Ваши подборки";
            // 
            // add2
            // 
            add2.BackColor = Color.NavajoWhite;
            add2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add2.ForeColor = Color.FromArgb(136, 92, 64);
            add2.Location = new Point(268, 760);
            add2.Name = "add2";
            add2.Size = new Size(194, 52);
            add2.TabIndex = 10;
            add2.Text = "Создать подборку";
            add2.UseVisualStyleBackColor = false;
            add2.Click += add2_Click;
            // 
            // favs
            // 
            favs.BackColor = Color.FromArgb(136, 92, 64);
            favs.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            favs.ForeColor = Color.NavajoWhite;
            favs.Location = new Point(268, 181);
            favs.Name = "favs";
            favs.Size = new Size(194, 52);
            favs.TabIndex = 11;
            favs.Text = "Избранное";
            favs.UseVisualStyleBackColor = false;
            favs.Click += favs_Click;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.ForeColor = Color.NavajoWhite;
            back.Location = new Point(1, 2);
            back.Name = "back";
            back.Size = new Size(62, 78);
            back.TabIndex = 12;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // five
            // 
            five.BackColor = Color.FromArgb(136, 92, 64);
            five.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            five.ForeColor = Color.NavajoWhite;
            five.Location = new Point(268, 535);
            five.Name = "five";
            five.Size = new Size(194, 52);
            five.TabIndex = 21;
            five.UseVisualStyleBackColor = false;
            // 
            // four
            // 
            four.BackColor = Color.FromArgb(136, 92, 64);
            four.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            four.ForeColor = Color.NavajoWhite;
            four.Location = new Point(268, 451);
            four.Name = "four";
            four.Size = new Size(194, 52);
            four.TabIndex = 20;
            four.UseVisualStyleBackColor = false;
            // 
            // three
            // 
            three.BackColor = Color.FromArgb(136, 92, 64);
            three.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            three.ForeColor = Color.NavajoWhite;
            three.Location = new Point(268, 363);
            three.Name = "three";
            three.Size = new Size(194, 52);
            three.TabIndex = 19;
            three.UseVisualStyleBackColor = false;
            // 
            // two
            // 
            two.BackColor = Color.FromArgb(136, 92, 64);
            two.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            two.ForeColor = Color.NavajoWhite;
            two.Location = new Point(268, 280);
            two.Name = "two";
            two.Size = new Size(194, 52);
            two.TabIndex = 18;
            two.UseVisualStyleBackColor = false;
            // 
            // six
            // 
            six.BackColor = Color.FromArgb(136, 92, 64);
            six.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            six.ForeColor = Color.NavajoWhite;
            six.Location = new Point(268, 615);
            six.Name = "six";
            six.Size = new Size(194, 52);
            six.TabIndex = 22;
            six.UseVisualStyleBackColor = false;
            // 
            // YourCollections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 861);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(back);
            Controls.Add(favs);
            Controls.Add(add2);
            Controls.Add(collections);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "YourCollections";
            Load += YourCollections_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label collections;
        private Button add2;
        private Button favs;
        private Button back;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button six;
    }
}