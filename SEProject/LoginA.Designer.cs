namespace SEProject
{
    partial class LoginA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginA));
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLinkLabel1.DisabledLinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(136, 389);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(110, 29);
            this.gunaLinkLabel1.TabIndex = 9;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Patient";
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.Brown;
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(100, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
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
            this.password.Location = new System.Drawing.Point(59, 168);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(269, 50);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.login.Location = new System.Drawing.Point(59, 298);
            this.login.Name = "login";
            this.login.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.login.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.login.OnHoverForeColor = System.Drawing.Color.Brown;
            this.login.OnHoverImage = null;
            this.login.OnHoverLineColor = System.Drawing.Color.Brown;
            this.login.OnPressedColor = System.Drawing.Color.Black;
            this.login.Radius = 15;
            this.login.Size = new System.Drawing.Size(269, 66);
            this.login.TabIndex = 41;
            this.login.Text = "Login";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Guna.UI.WinForms.GunaAdvenceButton login;
    }
}