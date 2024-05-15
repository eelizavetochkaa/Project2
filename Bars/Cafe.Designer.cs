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
            comboBox1 = new ComboBox();
            change = new Button();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            buttonVK = new Button();
            start = new Button();
            label1 = new Label();
            label2 = new Label();
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
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.BackColor = Color.NavajoWhite;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Sienna;
            comboBox1.FormattingEnabled = true;
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // change
            // 
            resources.ApplyResources(change, "change");
            change.BackColor = Color.NavajoWhite;
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
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // buttonVK
            // 
            resources.ApplyResources(buttonVK, "buttonVK");
            buttonVK.BackColor = Color.CornflowerBlue;
            buttonVK.ForeColor = Color.White;
            buttonVK.Name = "buttonVK";
            buttonVK.UseVisualStyleBackColor = false;
            buttonVK.Click += buttonVK_Click;
            // 
            // start
            // 
            resources.ApplyResources(start, "start");
            start.BackColor = Color.NavajoWhite;
            start.ForeColor = Color.FromArgb(132, 94, 72);
            start.Name = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.NavajoWhite;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.NavajoWhite;
            label2.Name = "label2";
            // 
            // Cafe
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(start);
            Controls.Add(loginBox);
            Controls.Add(passwordBox);
            Controls.Add(buttonVK);
            Controls.Add(change);
            Controls.Add(comboBox1);
            Controls.Add(description);
            Controls.Add(welcome);
            Name = "Cafe";
            FormClosing += Cafe_FormClosing;
            Load += Cafe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Label description;
        private ComboBox comboBox1;
        private Button change;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button buttonVK;
        private Button start;
        private Label label1;
        private Label label2;
    }
}