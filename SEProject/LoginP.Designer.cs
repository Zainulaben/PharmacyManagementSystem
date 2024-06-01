namespace SEProject
{
    partial class LoginP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginP));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.DisabledLinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(140, 421);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(99, 29);
            this.gunaLinkLabel1.TabIndex = 4;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Admin";
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Brown;
            this.password.HintForeColor = System.Drawing.Color.Transparent;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Brown;
            this.password.LineIdleColor = System.Drawing.Color.Brown;
            this.password.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.password.LineThickness = 4;
            this.password.Location = new System.Drawing.Point(58, 247);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(269, 50);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.Brown;
            this.username.HintForeColor = System.Drawing.Color.Transparent;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.Brown;
            this.username.LineIdleColor = System.Drawing.Color.Brown;
            this.username.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.username.LineThickness = 4;
            this.username.Location = new System.Drawing.Point(58, 153);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(269, 50);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login
            // 
            this.login.AnimationHoverSpeed = 0.07F;
            this.login.AnimationSpeed = 0.03F;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BaseColor = System.Drawing.Color.Brown;
            this.login.BorderColor = System.Drawing.Color.Brown;
            this.login.BorderSize = 2;
            this.login.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.login.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.login.CheckedForeColor = System.Drawing.Color.White;
            this.login.CheckedImage = ((System.Drawing.Image)(resources.GetObject("login.CheckedImage")));
            this.login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login.FocusedColor = System.Drawing.Color.Empty;
            this.login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Image = null;
            this.login.ImageSize = new System.Drawing.Size(20, 20);
            this.login.LineColor = System.Drawing.Color.Brown;
            this.login.Location = new System.Drawing.Point(58, 341);
            this.login.Name = "login";
            this.login.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.login.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.login.OnHoverForeColor = System.Drawing.Color.Brown;
            this.login.OnHoverImage = null;
            this.login.OnHoverLineColor = System.Drawing.Color.Brown;
            this.login.OnPressedColor = System.Drawing.Color.Black;
            this.login.Radius = 15;
            this.login.Size = new System.Drawing.Size(269, 66);
            this.login.TabIndex = 42;
            this.login.Text = "Login";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.login);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Guna.UI.WinForms.GunaAdvenceButton login;
    }
}