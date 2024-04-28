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
            back5 = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            two = new Button();
            six = new Button();
            SuspendLayout();
            // 
            // collections
            // 
            resources.ApplyResources(collections, "collections");
            collections.BackColor = Color.NavajoWhite;
            collections.ForeColor = Color.FromArgb(136, 92, 64);
            collections.Name = "collections";
            // 
            // add2
            // 
            add2.BackColor = Color.NavajoWhite;
            resources.ApplyResources(add2, "add2");
            add2.ForeColor = Color.FromArgb(136, 92, 64);
            add2.Name = "add2";
            add2.UseVisualStyleBackColor = false;
            add2.Click += add2_Click;
            // 
            // favs
            // 
            favs.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(favs, "favs");
            favs.ForeColor = Color.NavajoWhite;
            favs.Name = "favs";
            favs.UseVisualStyleBackColor = false;
            favs.Click += favs_Click;
            // 
            // back5
            // 
            back5.BackColor = Color.Transparent;
            resources.ApplyResources(back5, "back5");
            back5.ForeColor = Color.NavajoWhite;
            back5.Name = "back5";
            back5.UseVisualStyleBackColor = false;
            back5.Click += back5_Click;
            // 
            // five
            // 
            five.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(five, "five");
            five.ForeColor = Color.NavajoWhite;
            five.Name = "five";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // four
            // 
            four.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(four, "four");
            four.ForeColor = Color.NavajoWhite;
            four.Name = "four";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // three
            // 
            three.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(three, "three");
            three.ForeColor = Color.NavajoWhite;
            three.Name = "three";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // two
            // 
            two.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(two, "two");
            two.ForeColor = Color.NavajoWhite;
            two.Name = "two";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // six
            // 
            six.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(six, "six");
            six.ForeColor = Color.NavajoWhite;
            six.Name = "six";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // YourCollections
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(back5);
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
        private Button back5;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button six;
    }
}