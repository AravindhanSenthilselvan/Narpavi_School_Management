namespace N
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            pictureBoxLoginpage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginpage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(228, 13);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(441, 91);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(152, 23);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(442, 131);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(152, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = SystemColors.ControlDarkDark;
            labelUserName.Font = new Font("Segoe UI", 12F);
            labelUserName.ForeColor = SystemColors.ButtonHighlight;
            labelUserName.Location = new Point(343, 92);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(88, 21);
            labelUserName.TabIndex = 4;
            labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.ControlDarkDark;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.ForeColor = SystemColors.ButtonHighlight;
            labelPassword.Location = new Point(344, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(442, 167);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(151, 34);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBoxLoginpage
            // 
            pictureBoxLoginpage.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLoginpage.Image = (Image)resources.GetObject("pictureBoxLoginpage.Image");
            pictureBoxLoginpage.Location = new Point(-70, 54);
            pictureBoxLoginpage.Name = "pictureBoxLoginpage";
            pictureBoxLoginpage.Size = new Size(604, 470);
            pictureBoxLoginpage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoginpage.TabIndex = 1;
            pictureBoxLoginpage.TabStop = false;
            pictureBoxLoginpage.Click += pictureBoxLoginpage_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(621, 253);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBoxLoginpage);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginpage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUserName;
        private Label labelPassword;
        private Button buttonLogin;
        private PictureBox pictureBoxLoginpage;
    }
}
