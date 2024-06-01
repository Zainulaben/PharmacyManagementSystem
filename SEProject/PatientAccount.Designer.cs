namespace SEProject
{
    partial class PatientAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAccount));
            this.username = new Guna.UI.WinForms.GunaLineTextBox();
            this.edit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.password = new Guna.UI.WinForms.GunaLineTextBox();
            this.name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.FocusedLineColor = System.Drawing.Color.Gray;
            this.username.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Brown;
            this.username.LineColor = System.Drawing.Color.Brown;
            this.username.LineSize = 5;
            this.username.Location = new System.Drawing.Point(540, 213);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(388, 50);
            this.username.TabIndex = 43;
            this.username.Text = "Username";
            // 
            // edit
            // 
            this.edit.AnimationHoverSpeed = 0.07F;
            this.edit.AnimationSpeed = 0.03F;
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BaseColor = System.Drawing.Color.Brown;
            this.edit.BorderColor = System.Drawing.Color.Brown;
            this.edit.BorderSize = 2;
            this.edit.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.edit.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.edit.CheckedForeColor = System.Drawing.Color.White;
            this.edit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("edit.CheckedImage")));
            this.edit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.edit.FocusedColor = System.Drawing.Color.Empty;
            this.edit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Image = null;
            this.edit.ImageSize = new System.Drawing.Size(20, 20);
            this.edit.LineColor = System.Drawing.Color.Brown;
            this.edit.Location = new System.Drawing.Point(771, 385);
            this.edit.Name = "edit";
            this.edit.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.edit.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.edit.OnHoverForeColor = System.Drawing.Color.Brown;
            this.edit.OnHoverImage = null;
            this.edit.OnHoverLineColor = System.Drawing.Color.Brown;
            this.edit.OnPressedColor = System.Drawing.Color.Black;
            this.edit.Radius = 15;
            this.edit.Size = new System.Drawing.Size(157, 50);
            this.edit.TabIndex = 40;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.FocusedLineColor = System.Drawing.Color.Gray;
            this.password.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Brown;
            this.password.LineColor = System.Drawing.Color.Brown;
            this.password.LineSize = 5;
            this.password.Location = new System.Drawing.Point(540, 288);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(388, 50);
            this.password.TabIndex = 39;
            this.password.Text = "Password";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FocusedLineColor = System.Drawing.Color.Gray;
            this.name.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Brown;
            this.name.LineColor = System.Drawing.Color.Brown;
            this.name.LineSize = 5;
            this.name.Location = new System.Drawing.Point(540, 139);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(388, 50);
            this.name.TabIndex = 38;
            this.name.Text = "Name";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel1.Location = new System.Drawing.Point(491, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(559, 59);
            this.gunaLabel1.TabIndex = 37;
            this.gunaLabel1.Text = "Patient Information";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaButton5);
            this.gunaPanel1.Controls.Add(this.gunaButton4);
            this.gunaPanel1.Controls.Add(this.gunaButton3);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Location = new System.Drawing.Point(6, -17);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(308, 729);
            this.gunaPanel1.TabIndex = 36;
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.White;
            this.gunaButton5.BorderColor = System.Drawing.Color.Brown;
            this.gunaButton5.BorderSize = 3;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.Brown;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(0, 594);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton5.OnPressedDepth = 10;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(303, 72);
            this.gunaButton5.TabIndex = 7;
            this.gunaButton5.Text = "Logout";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.White;
            this.gunaButton4.BaseColor = System.Drawing.Color.White;
            this.gunaButton4.BorderColor = System.Drawing.Color.Brown;
            this.gunaButton4.BorderSize = 3;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.Brown;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(0, 283);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton4.OnPressedDepth = 10;
            this.gunaButton4.Size = new System.Drawing.Size(303, 72);
            this.gunaButton4.TabIndex = 6;
            this.gunaButton4.Text = "Message";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Brown;
            this.gunaButton3.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton3.BorderColor = System.Drawing.Color.Brown;
            this.gunaButton3.BorderSize = 3;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(0, 208);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton3.OnPressedDepth = 10;
            this.gunaButton3.Size = new System.Drawing.Size(303, 72);
            this.gunaButton3.TabIndex = 5;
            this.gunaButton3.Text = "Account";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.White;
            this.gunaButton2.BaseColor = System.Drawing.Color.White;
            this.gunaButton2.BorderColor = System.Drawing.Color.Brown;
            this.gunaButton2.BorderSize = 3;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Brown;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(0, 134);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton2.OnPressedDepth = 10;
            this.gunaButton2.Size = new System.Drawing.Size(303, 72);
            this.gunaButton2.TabIndex = 4;
            this.gunaButton2.Text = "Order Medicine";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.White;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Brown;
            this.gunaButton1.BorderSize = 3;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Brown;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 60);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton1.OnPressedDepth = 10;
            this.gunaButton1.Size = new System.Drawing.Size(303, 72);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Dashboard";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // PatientAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 695);
            this.Controls.Add(this.username);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox username;
        private Guna.UI.WinForms.GunaAdvenceButton edit;
        private Guna.UI.WinForms.GunaLineTextBox password;
        private Guna.UI.WinForms.GunaLineTextBox name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}