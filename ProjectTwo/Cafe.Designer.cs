namespace DZ
{
    partial class Cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cafe));
            welcome = new Label();
            description = new Label();
            start = new Button();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Palatino Linotype", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcome.ForeColor = Color.NavajoWhite;
            welcome.Location = new Point(484, 33);
            welcome.Name = "welcome";
            welcome.Size = new Size(878, 67);
            welcome.TabIndex = 0;
            welcome.Text = "Добро пожаловать в \"Ешь и Пей\"!";
            // 
            // description
            // 
            description.AutoSize = true;
            description.BackColor = Color.FromArgb(136, 92, 64);
            description.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description.ForeColor = Color.FromArgb(255, 255, 192);
            description.Location = new Point(881, 150);
            description.Name = "description";
            description.Size = new Size(471, 230);
            description.TabIndex = 1;
            description.Text = "Не знаете, где поужинать?\r\nКуда сходить на свидание?\r\nГде провести корпоратив?\r\n\"Ешь и Пей\" обязательно \r\nпоможет Вам определиться!";
            // 
            // start
            // 
            start.BackColor = Color.Moccasin;
            start.Font = new Font("Palatino Linotype", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            start.ForeColor = Color.FromArgb(132, 94, 72);
            start.Location = new Point(626, 605);
            start.Name = "start";
            start.Size = new Size(146, 56);
            start.TabIndex = 2;
            start.Text = "Начать";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // Cafe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1443, 750);
            Controls.Add(start);
            Controls.Add(description);
            Controls.Add(welcome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Cafe";
            Text = "Кафе и рестораны ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Label description;
        private Button start;
    }
}