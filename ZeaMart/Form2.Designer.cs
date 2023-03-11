namespace ZeaMart
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.undraw_Welcoming_re_x0qo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(266, 41);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(258, 23);
            tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(266, 87);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(258, 23);
            tb_password.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 95);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(449, 128);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(588, 192);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(label2);
            Controls.Add(tb_username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label label2;
        private Button btn_login;
    }
}