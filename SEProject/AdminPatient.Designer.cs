namespace SEProject
{
    partial class AdminPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPatient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.add = new Guna.UI.WinForms.GunaAdvenceButton();
            this.username = new Guna.UI.WinForms.GunaLineTextBox();
            this.patientname = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.password = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.AnimationHoverSpeed = 0.07F;
            this.delete.AnimationSpeed = 0.03F;
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BaseColor = System.Drawing.Color.Brown;
            this.delete.BorderColor = System.Drawing.Color.Brown;
            this.delete.BorderSize = 2;
            this.delete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.delete.CheckedForeColor = System.Drawing.Color.White;
            this.delete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("delete.CheckedImage")));
            this.delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete.FocusedColor = System.Drawing.Color.Empty;
            this.delete.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Image = null;
            this.delete.ImageSize = new System.Drawing.Size(20, 20);
            this.delete.LineColor = System.Drawing.Color.Brown;
            this.delete.Location = new System.Drawing.Point(930, 224);
            this.delete.Name = "delete";
            this.delete.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.delete.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.delete.OnHoverForeColor = System.Drawing.Color.Brown;
            this.delete.OnHoverImage = null;
            this.delete.OnHoverLineColor = System.Drawing.Color.Brown;
            this.delete.OnPressedColor = System.Drawing.Color.Black;
            this.delete.Radius = 15;
            this.delete.Size = new System.Drawing.Size(157, 50);
            this.delete.TabIndex = 21;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.AnimationHoverSpeed = 0.07F;
            this.add.AnimationSpeed = 0.03F;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BaseColor = System.Drawing.Color.Brown;
            this.add.BorderColor = System.Drawing.Color.Brown;
            this.add.BorderSize = 2;
            this.add.CheckedBaseColor = System.Drawing.Color.Gray;
            this.add.CheckedBorderColor = System.Drawing.Color.Black;
            this.add.CheckedForeColor = System.Drawing.Color.White;
            this.add.CheckedImage = ((System.Drawing.Image)(resources.GetObject("add.CheckedImage")));
            this.add.CheckedLineColor = System.Drawing.Color.DimGray;
            this.add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add.FocusedColor = System.Drawing.Color.Empty;
            this.add.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = null;
            this.add.ImageSize = new System.Drawing.Size(20, 20);
            this.add.LineColor = System.Drawing.Color.Brown;
            this.add.Location = new System.Drawing.Point(758, 224);
            this.add.Name = "add";
            this.add.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.add.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.add.OnHoverForeColor = System.Drawing.Color.Brown;
            this.add.OnHoverImage = null;
            this.add.OnHoverLineColor = System.Drawing.Color.Brown;
            this.add.OnPressedColor = System.Drawing.Color.Black;
            this.add.Radius = 15;
            this.add.Size = new System.Drawing.Size(157, 50);
            this.add.TabIndex = 20;
            this.add.Text = "Add";
            this.add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.username.Location = new System.Drawing.Point(790, 128);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(297, 50);
            this.username.TabIndex = 17;
            this.username.Text = "User Name";
            // 
            // patientname
            // 
            this.patientname.BackColor = System.Drawing.Color.White;
            this.patientname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientname.FocusedLineColor = System.Drawing.Color.Gray;
            this.patientname.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientname.ForeColor = System.Drawing.Color.Brown;
            this.patientname.LineColor = System.Drawing.Color.Brown;
            this.patientname.LineSize = 5;
            this.patientname.Location = new System.Drawing.Point(439, 128);
            this.patientname.Name = "patientname";
            this.patientname.PasswordChar = '\0';
            this.patientname.SelectedText = "";
            this.patientname.Size = new System.Drawing.Size(297, 50);
            this.patientname.TabIndex = 16;
            this.patientname.Text = "Patient Name";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel1.Location = new System.Drawing.Point(645, 28);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(218, 59);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Patient";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(116, 678);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(8, 8);
            this.gunaElipsePanel1.TabIndex = 14;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaButton5);
            this.gunaPanel1.Controls.Add(this.gunaButton4);
            this.gunaPanel1.Controls.Add(this.gunaButton3);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(306, 724);
            this.gunaPanel1.TabIndex = 13;
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
            this.gunaButton4.Location = new System.Drawing.Point(0, 285);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton4.OnPressedDepth = 10;
            this.gunaButton4.Size = new System.Drawing.Size(303, 72);
            this.gunaButton4.TabIndex = 6;
            this.gunaButton4.Text = "Order Request";
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
            this.gunaButton3.Location = new System.Drawing.Point(0, 209);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.IndianRed;
            this.gunaButton3.OnPressedDepth = 10;
            this.gunaButton3.Size = new System.Drawing.Size(303, 72);
            this.gunaButton3.TabIndex = 5;
            this.gunaButton3.Text = "Patient";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Brown;
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
            this.gunaButton2.Text = "Medicine";
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
            this.gunaButton1.Location = new System.Drawing.Point(0, 59);
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
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(309, 315);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(884, 368);
            this.gunaDataGridView1.TabIndex = 23;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
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
            this.password.Location = new System.Drawing.Point(439, 224);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(297, 50);
            this.password.TabIndex = 24;
            this.password.Text = "Password";
            // 
            // AdminPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 695);
            this.Controls.Add(this.password);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.username);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPatient";
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton delete;
        private Guna.UI.WinForms.GunaAdvenceButton add;
        private Guna.UI.WinForms.GunaLineTextBox username;
        private Guna.UI.WinForms.GunaLineTextBox patientname;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaLineTextBox password;
    }
}