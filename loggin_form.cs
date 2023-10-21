using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FinalProject
{
    public partial class loggin_form : Form
    {
        public loggin_form()
        {
          InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Close();
                
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // development after change => tb_password.Text = "";   =>tb_userName.Text = "";
            //tb_password.Text = "Admin";
            //tb_userName.Text = "Skills@123";
            tb_password.Text = "";
            tb_userName.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "Skills@123" && tb_userName.Text == "Admin") {

                StudentRegistation studentRegistation = new StudentRegistation();
                this.Hide();
                studentRegistation.Show();
                studentRegistation.FormClosed += closeStudentRgister;
            }
            else
            {
                MessageBox.Show("Invalid Login crcredentials, please check Username and Password and try again ", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeStudentRgister(object sender, FormClosedEventArgs e)
        {
            this.Close();

        }


        

        private void loggin_form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
