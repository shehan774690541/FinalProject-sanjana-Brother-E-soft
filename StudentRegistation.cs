using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.sql;
using MySql.Data.MySqlClient;

namespace FinalProject 
{
    public partial class StudentRegistation : Form
    {

        public StudentRegistation()
        {
            InitializeComponent();
        }

        private void StudentRegistation_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_address.Text = "";
            tb_firstName.Text = "";
            tb_homeNumber.Text = "";
            tb_lastName.Text = "";
            tb_mobileNumber.Text = "";
            tb_NIC.Text = "";
            tb_parentContact.Text = "";
            tb_parentName.Text = "";
            tb_parentNIC.Text = "";
            rb_female.Checked = false;
            rb_male.Checked = false;
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ll_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loggin_form loggin_Form = new loggin_form();
            loggin_Form.Show();
            this.Close();
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            //ConnectionsVariable connectionsVariable = new ConnectionsVariable();
            connections connections = new connections();
            connections.CheckConnection();
        }
    }
}
