namespace FinalProject
{
    partial class StudentRegistation
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
            this.ll_logout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_stuRegister = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.gb_parent = new System.Windows.Forms.GroupBox();
            this.tb_parentContact = new System.Windows.Forms.TextBox();
            this.tb_parentNIC = new System.Windows.Forms.TextBox();
            this.tb_parentName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_contactDetails = new System.Windows.Forms.GroupBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_homeNumber = new System.Windows.Forms.TextBox();
            this.tb_mobileNumber = new System.Windows.Forms.TextBox();
            this.tb_NIC = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.dtp_dof = new System.Windows.Forms.DateTimePicker();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_regNo = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gb_stuRegister.SuspendLayout();
            this.gb_parent.SuspendLayout();
            this.gb_contactDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll_logout
            // 
            this.ll_logout.AutoSize = true;
            this.ll_logout.Location = new System.Drawing.Point(12, 9);
            this.ll_logout.Name = "ll_logout";
            this.ll_logout.Size = new System.Drawing.Size(48, 16);
            this.ll_logout.TabIndex = 0;
            this.ll_logout.TabStop = true;
            this.ll_logout.Text = "Logout";
            this.ll_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_logout_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skills International";
            // 
            // gb_stuRegister
            // 
            this.gb_stuRegister.Controls.Add(this.linkLabel1);
            this.gb_stuRegister.Controls.Add(this.btn_clear);
            this.gb_stuRegister.Controls.Add(this.btn_delete);
            this.gb_stuRegister.Controls.Add(this.btn_update);
            this.gb_stuRegister.Controls.Add(this.btn_register);
            this.gb_stuRegister.Controls.Add(this.gb_parent);
            this.gb_stuRegister.Controls.Add(this.gb_contactDetails);
            this.gb_stuRegister.Controls.Add(this.groupBox1);
            this.gb_stuRegister.Controls.Add(this.label2);
            this.gb_stuRegister.Controls.Add(this.cb_regNo);
            this.gb_stuRegister.Location = new System.Drawing.Point(12, 48);
            this.gb_stuRegister.Name = "gb_stuRegister";
            this.gb_stuRegister.Size = new System.Drawing.Size(634, 706);
            this.gb_stuRegister.TabIndex = 2;
            this.gb_stuRegister.TabStop = false;
            this.gb_stuRegister.Text = "Student Registation";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(448, 643);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 31);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(529, 643);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(111, 644);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 31);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(29, 644);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 31);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // gb_parent
            // 
            this.gb_parent.Controls.Add(this.tb_parentContact);
            this.gb_parent.Controls.Add(this.tb_parentNIC);
            this.gb_parent.Controls.Add(this.tb_parentName);
            this.gb_parent.Controls.Add(this.label13);
            this.gb_parent.Controls.Add(this.label12);
            this.gb_parent.Controls.Add(this.label11);
            this.gb_parent.Location = new System.Drawing.Point(29, 493);
            this.gb_parent.Name = "gb_parent";
            this.gb_parent.Size = new System.Drawing.Size(576, 147);
            this.gb_parent.TabIndex = 4;
            this.gb_parent.TabStop = false;
            this.gb_parent.Text = "Parent Details";
            // 
            // tb_parentContact
            // 
            this.tb_parentContact.Location = new System.Drawing.Point(144, 99);
            this.tb_parentContact.Name = "tb_parentContact";
            this.tb_parentContact.Size = new System.Drawing.Size(249, 22);
            this.tb_parentContact.TabIndex = 3;
            // 
            // tb_parentNIC
            // 
            this.tb_parentNIC.Location = new System.Drawing.Point(144, 63);
            this.tb_parentNIC.Name = "tb_parentNIC";
            this.tb_parentNIC.Size = new System.Drawing.Size(249, 22);
            this.tb_parentNIC.TabIndex = 2;
            // 
            // tb_parentName
            // 
            this.tb_parentName.Location = new System.Drawing.Point(144, 25);
            this.tb_parentName.Name = "tb_parentName";
            this.tb_parentName.Size = new System.Drawing.Size(410, 22);
            this.tb_parentName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Contact Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Parent NIC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Parent Name";
            // 
            // gb_contactDetails
            // 
            this.gb_contactDetails.Controls.Add(this.tb_email);
            this.gb_contactDetails.Controls.Add(this.tb_homeNumber);
            this.gb_contactDetails.Controls.Add(this.tb_mobileNumber);
            this.gb_contactDetails.Controls.Add(this.tb_NIC);
            this.gb_contactDetails.Controls.Add(this.tb_address);
            this.gb_contactDetails.Controls.Add(this.label10);
            this.gb_contactDetails.Controls.Add(this.label9);
            this.gb_contactDetails.Controls.Add(this.label14);
            this.gb_contactDetails.Controls.Add(this.label8);
            this.gb_contactDetails.Controls.Add(this.label7);
            this.gb_contactDetails.Location = new System.Drawing.Point(29, 263);
            this.gb_contactDetails.Name = "gb_contactDetails";
            this.gb_contactDetails.Size = new System.Drawing.Size(576, 224);
            this.gb_contactDetails.TabIndex = 3;
            this.gb_contactDetails.TabStop = false;
            this.gb_contactDetails.Text = "Contact Details";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(144, 116);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(410, 22);
            this.tb_email.TabIndex = 5;
            // 
            // tb_homeNumber
            // 
            this.tb_homeNumber.Location = new System.Drawing.Point(399, 190);
            this.tb_homeNumber.Name = "tb_homeNumber";
            this.tb_homeNumber.Size = new System.Drawing.Size(155, 22);
            this.tb_homeNumber.TabIndex = 4;
            // 
            // tb_mobileNumber
            // 
            this.tb_mobileNumber.Location = new System.Drawing.Point(144, 190);
            this.tb_mobileNumber.Name = "tb_mobileNumber";
            this.tb_mobileNumber.Size = new System.Drawing.Size(132, 22);
            this.tb_mobileNumber.TabIndex = 3;
            // 
            // tb_NIC
            // 
            this.tb_NIC.Location = new System.Drawing.Point(144, 148);
            this.tb_NIC.Name = "tb_NIC";
            this.tb_NIC.Size = new System.Drawing.Size(410, 22);
            this.tb_NIC.TabIndex = 2;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(144, 36);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(410, 71);
            this.tb_address.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Home Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mobile Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "NIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_female);
            this.groupBox1.Controls.Add(this.rb_male);
            this.groupBox1.Controls.Add(this.dtp_dof);
            this.groupBox1.Controls.Add(this.tb_lastName);
            this.groupBox1.Controls.Add(this.tb_firstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Details";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(301, 161);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 5;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(162, 161);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(58, 20);
            this.rb_male.TabIndex = 4;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // dtp_dof
            // 
            this.dtp_dof.Location = new System.Drawing.Point(144, 119);
            this.dtp_dof.Name = "dtp_dof";
            this.dtp_dof.Size = new System.Drawing.Size(249, 22);
            this.dtp_dof.TabIndex = 3;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(144, 77);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(410, 22);
            this.tb_lastName.TabIndex = 2;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(144, 33);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(410, 22);
            this.tb_firstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg No";
            // 
            // cb_regNo
            // 
            this.cb_regNo.FormattingEnabled = true;
            this.cb_regNo.Location = new System.Drawing.Point(173, 22);
            this.cb_regNo.Name = "cb_regNo";
            this.cb_regNo.Size = new System.Drawing.Size(249, 24);
            this.cb_regNo.TabIndex = 0;
            this.cb_regNo.TextChanged += new System.EventHandler(this.cb_regNo_TextChanged);
            this.cb_regNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cb_regNo_MouseUp);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(600, 684);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // StudentRegistation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 766);
            this.Controls.Add(this.gb_stuRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ll_logout);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(676, 813);
            this.Name = "StudentRegistation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registation - studentRegistation";
            this.Load += new System.EventHandler(this.StudentRegistation_Load);
            this.gb_stuRegister.ResumeLayout(false);
            this.gb_stuRegister.PerformLayout();
            this.gb_parent.ResumeLayout(false);
            this.gb_parent.PerformLayout();
            this.gb_contactDetails.ResumeLayout(false);
            this.gb_contactDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_stuRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_regNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.DateTimePicker dtp_dof;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.GroupBox gb_contactDetails;
        private System.Windows.Forms.TextBox tb_homeNumber;
        private System.Windows.Forms.TextBox tb_mobileNumber;
        private System.Windows.Forms.TextBox tb_NIC;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_parent;
        private System.Windows.Forms.TextBox tb_parentContact;
        private System.Windows.Forms.TextBox tb_parentNIC;
        private System.Windows.Forms.TextBox tb_parentName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label14;
    }
}