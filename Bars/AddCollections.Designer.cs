﻿namespace ProjectTwo
{
    partial class AddCollections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCollections));
            back = new Button();
            EnterName = new Label();
            NameColl = new TextBox();
            createcoll = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.NavajoWhite;
            back.Location = new Point(1, 0);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(54, 58);
            back.TabIndex = 13;
            back.Text = "⇐";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // EnterName
            // 
            EnterName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EnterName.AutoSize = true;
            EnterName.BackColor = Color.NavajoWhite;
            EnterName.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            EnterName.ForeColor = Color.FromArgb(136, 92, 64);
            EnterName.Location = new Point(163, 104);
            EnterName.Name = "EnterName";
            EnterName.Size = new Size(360, 36);
            EnterName.TabIndex = 14;
            EnterName.Text = "Введите название подборки";
            // 
            // NameColl
            // 
            NameColl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameColl.BackColor = Color.FromArgb(136, 92, 64);
            NameColl.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NameColl.ForeColor = Color.NavajoWhite;
            NameColl.Location = new Point(137, 182);
            NameColl.Margin = new Padding(3, 2, 3, 2);
            NameColl.Name = "NameColl";
            NameColl.Size = new Size(406, 32);
            NameColl.TabIndex = 15;
            // 
            // createcoll
            // 
            createcoll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createcoll.BackColor = Color.NavajoWhite;
            createcoll.Font = new Font("Palatino Linotype", 15F, FontStyle.Regular, GraphicsUnit.Point);
            createcoll.ForeColor = Color.FromArgb(136, 92, 64);
            createcoll.Location = new Point(279, 493);
            createcoll.Margin = new Padding(3, 2, 3, 2);
            createcoll.Name = "createcoll";
            createcoll.Size = new Size(124, 40);
            createcoll.TabIndex = 16;
            createcoll.Text = "Создать подборку";
            createcoll.UseVisualStyleBackColor = false;
            createcoll.Click += createcoll_Click;
            // 
            // AddCollections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 562);
            Controls.Add(createcoll);
            Controls.Add(NameColl);
            Controls.Add(EnterName);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCollections";
            Load += AddCollections_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Label EnterName;
        private TextBox NameColl;
        private Button createcoll;
    }
}