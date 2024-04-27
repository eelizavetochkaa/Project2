namespace ProjectTwo
{
    partial class ChoosingCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosingCollection));
            choose2 = new Label();
            tip = new Label();
            back2 = new Button();
            favs1 = new Button();
            two1 = new Button();
            three1 = new Button();
            four1 = new Button();
            five1 = new Button();
            six1 = new Button();
            SuspendLayout();
            // 
            // choose2
            // 
            resources.ApplyResources(choose2, "choose2");
            choose2.BackColor = Color.NavajoWhite;
            choose2.ForeColor = Color.FromArgb(136, 92, 64);
            choose2.Name = "choose2";
            // 
            // tip
            // 
            resources.ApplyResources(tip, "tip");
            tip.BackColor = Color.NavajoWhite;
            tip.ForeColor = Color.FromArgb(136, 92, 64);
            tip.Name = "tip";
            // 
            // back2
            // 
            back2.BackColor = Color.Transparent;
            resources.ApplyResources(back2, "back2");
            back2.ForeColor = Color.NavajoWhite;
            back2.Name = "back2";
            back2.UseVisualStyleBackColor = false;
            back2.Click += back2_Click;
            // 
            // favs1
            // 
            favs1.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(favs1, "favs1");
            favs1.ForeColor = Color.NavajoWhite;
            favs1.Name = "favs1";
            favs1.UseVisualStyleBackColor = false;
            favs1.Click += favs_Click;
            // 
            // two1
            // 
            two1.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(two1, "two1");
            two1.ForeColor = Color.NavajoWhite;
            two1.Name = "two1";
            two1.UseVisualStyleBackColor = false;
            two1.Click += two1_Click;
            // 
            // three1
            // 
            three1.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(three1, "three1");
            three1.ForeColor = Color.NavajoWhite;
            three1.Name = "three1";
            three1.UseVisualStyleBackColor = false;
            three1.Click += three1_Click;
            // 
            // four1
            // 
            four1.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(four1, "four1");
            four1.ForeColor = Color.NavajoWhite;
            four1.Name = "four1";
            four1.UseVisualStyleBackColor = false;
            four1.Click += four1_Click;
            // 
            // five1
            // 
            five1.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(five1, "five1");
            five1.ForeColor = Color.NavajoWhite;
            five1.Name = "five1";
            five1.UseVisualStyleBackColor = false;
            five1.Click += five_Click;
            // 
            // six1
            // 
            six1.BackColor = Color.FromArgb(136, 92, 64);
            resources.ApplyResources(six1, "six1");
            six1.ForeColor = Color.NavajoWhite;
            six1.Name = "six1";
            six1.UseVisualStyleBackColor = false;
            six1.Click += six1_Click;
            // 
            // ChoosingCollection
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(six1);
            Controls.Add(five1);
            Controls.Add(four1);
            Controls.Add(three1);
            Controls.Add(two1);
            Controls.Add(back2);
            Controls.Add(favs1);
            Controls.Add(tip);
            Controls.Add(choose2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChoosingCollection";
            Load += ChoosingCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label choose2;
        private Label tip;
        private Button back2;
        private Button favs1;
        private Button two1;
        private Button three1;
        private Button four1;
        private Button five1;
        private Button six1;
    }
}