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
            change = new Button();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            buttonVK = new Button();
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
            description.ForeColor = Color.NavajoWhite;
            description.Name = "description";
            // 
            // start
            // 
            start.BackColor = Color.NavajoWhite;
            resources.ApplyResources(start, "start");
            start.ForeColor = Color.FromArgb(132, 94, 72);
            start.Name = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.NavajoWhite;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.ForeColor = Color.Sienna;
            comboBox1.FormattingEnabled = true;
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // change
            // 
            change.BackColor = Color.NavajoWhite;
            resources.ApplyResources(change, "change");
            change.ForeColor = Color.Sienna;
            change.Name = "change";
            change.UseVisualStyleBackColor = false;
            change.Click += button1_Click;
            // 
            // loginBox
            // 
            loginBox.BackColor = Color.NavajoWhite;
            resources.ApplyResources(loginBox, "loginBox");
            loginBox.Name = "loginBox";
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.NavajoWhite;
            resources.ApplyResources(passwordBox, "passwordBox");
            passwordBox.ForeColor = Color.FromArgb(128, 64, 0);
            passwordBox.Name = "passwordBox";
            // 
            // buttonVK
            // 
            buttonVK.BackColor = Color.CornflowerBlue;
            resources.ApplyResources(buttonVK, "buttonVK");
            buttonVK.ForeColor = Color.White;
            buttonVK.Name = "buttonVK";
            buttonVK.UseVisualStyleBackColor = false;
            buttonVK.Click += buttonVK_Click;
            // 
            // Cafe
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(buttonVK);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(change);
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
        private Button change;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button buttonVK;
    }
}