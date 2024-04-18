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
            favs = new Button();
            back = new Button();
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
            // favs
            // 
            favs.BackColor = Color.FromArgb(136, 92, 64);
            favs.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            favs.ForeColor = Color.NavajoWhite;
            favs.Location = new Point(288, 180);
            favs.Name = "favs";
            favs.Size = new Size(194, 52);
            favs.TabIndex = 12;
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
            back.TabIndex = 13;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // ChoosingCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 860);
            Controls.Add(back);
            Controls.Add(favs);
            Controls.Add(tip);
            Controls.Add(choose2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChoosingCollection";
            Text = "ChoosingCollection";
            Load += ChoosingCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label choose2;
        private Label tip;
        private Button favs;
        private Button back;
    }
}