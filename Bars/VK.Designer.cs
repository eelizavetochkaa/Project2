namespace Bars
{
    partial class VK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VK));
            loginVK = new TextBox();
            passwordVK = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginVK
            // 
            loginVK.Location = new Point(66, 122);
            loginVK.Name = "loginVK";
            loginVK.Size = new Size(136, 23);
            loginVK.TabIndex = 0;
            // 
            // passwordVK
            // 
            passwordVK.Location = new Point(66, 181);
            passwordVK.Name = "passwordVK";
            passwordVK.PasswordChar = '*';
            passwordVK.Size = new Size(136, 23);
            passwordVK.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(91, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(66, 97);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 4;
            label1.Text = "Введите логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(66, 156);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль:";
            label2.Click += label2_Click;
            // 
            // VK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(254, 306);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(passwordVK);
            Controls.Add(loginVK);
            Name = "VK";
            Text = "VK";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginVK;
        private TextBox passwordVK;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}