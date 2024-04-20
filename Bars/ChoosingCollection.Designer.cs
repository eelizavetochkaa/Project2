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
            back = new Button();
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
            choose2.AutoSize = true;
            choose2.BackColor = Color.NavajoWhite;
            choose2.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            choose2.ForeColor = Color.FromArgb(136, 92, 64);
            choose2.Location = new Point(219, 64);
            choose2.Name = "choose2";
            choose2.Size = new Size(345, 46);
            choose2.TabIndex = 1;
            choose2.Text = "Выберите подборку:";
            choose2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tip
            // 
            tip.AutoSize = true;
            tip.BackColor = Color.NavajoWhite;
            tip.Font = new Font("Palatino Linotype", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tip.ForeColor = Color.FromArgb(136, 92, 64);
            tip.Location = new Point(177, 660);
            tip.Name = "tip";
            tip.Size = new Size(429, 99);
            tip.TabIndex = 8;
            tip.Text = "Не нашли подходящую подборку?\r\nВы можете создать новую в разделе\r\n \"Ваши подборки\"\r\n";
            tip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.ForeColor = Color.NavajoWhite;
            back.Location = new Point(1, 2);
            back.Name = "back";
            back.Size = new Size(62, 78);
            back.TabIndex = 13;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // favs1
            // 
            favs1.BackColor = Color.FromArgb(136, 92, 64);
            favs1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            favs1.ForeColor = Color.NavajoWhite;
            favs1.Location = new Point(288, 180);
            favs1.Name = "favs1";
            favs1.Size = new Size(194, 52);
            favs1.TabIndex = 12;
            favs1.Text = "Избранное";
            favs1.UseVisualStyleBackColor = false;
            favs1.Click += favs_Click;
            // 
            // two1
            // 
            two1.BackColor = Color.FromArgb(136, 92, 64);
            two1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            two1.ForeColor = Color.NavajoWhite;
            two1.Location = new Point(288, 262);
            two1.Name = "two1";
            two1.Size = new Size(194, 52);
            two1.TabIndex = 14;
            two1.UseVisualStyleBackColor = false;
            // 
            // three1
            // 
            three1.BackColor = Color.FromArgb(136, 92, 64);
            three1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            three1.ForeColor = Color.NavajoWhite;
            three1.Location = new Point(288, 345);
            three1.Name = "three1";
            three1.Size = new Size(194, 52);
            three1.TabIndex = 15;
            three1.UseVisualStyleBackColor = false;
            // 
            // four1
            // 
            four1.BackColor = Color.FromArgb(136, 92, 64);
            four1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            four1.ForeColor = Color.NavajoWhite;
            four1.Location = new Point(288, 423);
            four1.Name = "four1";
            four1.Size = new Size(194, 52);
            four1.TabIndex = 16;
            four1.UseVisualStyleBackColor = false;
            // 
            // five1
            // 
            five1.BackColor = Color.FromArgb(136, 92, 64);
            five1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            five1.ForeColor = Color.NavajoWhite;
            five1.Location = new Point(288, 499);
            five1.Name = "five1";
            five1.Size = new Size(194, 52);
            five1.TabIndex = 17;
            five1.UseVisualStyleBackColor = false;
            five1.Click += five_Click;
            // 
            // six1
            // 
            six1.BackColor = Color.FromArgb(136, 92, 64);
            six1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            six1.ForeColor = Color.NavajoWhite;
            six1.Location = new Point(288, 576);
            six1.Name = "six1";
            six1.Size = new Size(194, 52);
            six1.TabIndex = 18;
            six1.UseVisualStyleBackColor = false;
            // 
            // ChoosingCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 860);
            Controls.Add(six1);
            Controls.Add(five1);
            Controls.Add(four1);
            Controls.Add(three1);
            Controls.Add(two1);
            Controls.Add(back);
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
        private Button back;
        private Button favs1;
        private Button two1;
        private Button three1;
        private Button four1;
        private Button five1;
        private Button six1;
    }
}