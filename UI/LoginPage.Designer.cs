namespace UI
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            labErrorLogin = new Label();
            btnClose = new PictureBox();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._11;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(labErrorLogin);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 500);
            panel1.TabIndex = 0;
            // 
            // labErrorLogin
            // 
            labErrorLogin.AutoSize = true;
            labErrorLogin.BackColor = Color.Transparent;
            labErrorLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labErrorLogin.ForeColor = Color.OrangeRed;
            labErrorLogin.Location = new Point(495, 302);
            labErrorLogin.Name = "labErrorLogin";
            labErrorLogin.Size = new Size(59, 23);
            labErrorLogin.TabIndex = 4;
            labErrorLogin.Text = "label1";
            labErrorLogin.TextAlign = ContentAlignment.MiddleCenter;
            labErrorLogin.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.InitialImage = (Image)resources.GetObject("btnClose.InitialImage");
            btnClose.Location = new Point(673, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 48);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(139, 134, 137);
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.DarkOrange;
            btnLogin.Location = new Point(499, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(152, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.TextAlign = ContentAlignment.TopCenter;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseMove += btnLogin_MouseMove;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.FromArgb(139, 134, 137);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.DarkOrange;
            txtUsername.Location = new Point(459, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 34);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Kullanıcı Adı";
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged_1;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(139, 134, 137);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DarkOrange;
            txtPassword.Location = new Point(459, 184);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 34);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Şifre";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPassword_TextChanged_1;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // LoginPage
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "R.I.P";
            Load += LoginPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox btnClose;
        private Label labErrorLogin;
    }
}