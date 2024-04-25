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
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // welcome
            // 
            resources.ApplyResources(welcome, "welcome");
            welcome.BackColor = Color.Transparent;
            welcome.ForeColor = Color.NavajoWhite;
            welcome.Name = "welcome";
            // 
            // description
            // 
            resources.ApplyResources(description, "description");
            description.BackColor = Color.FromArgb(136, 92, 64);
            description.ForeColor = Color.FromArgb(255, 255, 192);
            description.Name = "description";
            // 
            // start
            // 
            start.BackColor = Color.Moccasin;
            resources.ApplyResources(start, "start");
            start.ForeColor = Color.FromArgb(132, 94, 72);
            start.Name = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cafe
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(start);
            Controls.Add(description);
            Controls.Add(welcome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Cafe";
            FormClosing += Cafe_FormClosing;
            Load += Cafe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Label description;
        private Button start;
        private ComboBox comboBox1;
        private Button button1;
    }
}