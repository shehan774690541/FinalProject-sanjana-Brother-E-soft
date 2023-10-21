namespace FinalProject
{
    partial class loggin_form
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
            this.pb_logo1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo1)).BeginInit();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_logo1
            // 
            this.pb_logo1.Image = global::FinalProject.Properties.Resources.empty;
            this.pb_logo1.Location = new System.Drawing.Point(225, 64);
            this.pb_logo1.Name = "pb_logo1";
            this.pb_logo1.Size = new System.Drawing.Size(207, 161);
            this.pb_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo1.TabIndex = 0;
            this.pb_logo1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(181, 255);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(295, 39);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Skills International";
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.btn_login);
            this.gb_login.Controls.Add(this.btn_clear);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.tb_userName);
            this.gb_login.Controls.Add(this.lbl_password);
            this.gb_login.Controls.Add(this.lbl_userName);
            this.gb_login.Location = new System.Drawing.Point(108, 312);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(441, 200);
            this.gb_login.TabIndex = 2;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(343, 148);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 33);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(29, 148);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 33);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(158, 100);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(260, 26);
            this.tb_password.TabIndex = 2;
            // 
            // tb_userName
            // 
            this.tb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userName.Location = new System.Drawing.Point(158, 45);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(260, 26);
            this.tb_userName.TabIndex = 1;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(25, 100);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(83, 20);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(25, 45);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(86, 20);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.Location = new System.Drawing.Point(13, 589);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 34);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // loggin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 635);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gb_login);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pb_logo1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(682, 682);
            this.Name = "loggin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.loggin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo1)).EndInit();
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}

