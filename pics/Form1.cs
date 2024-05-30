using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register_Blue_BG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            pn_register.Visible = false;
            guna2Transition1.HideSync(pn_register);
         
         

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pn_register.Visible = true;
            guna2Transition1.ShowSync(pn_register);
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxshowpass.Checked) 
            {
                ConPassword.PasswordChar = '\0';
                password.PasswordChar = '\0';
            }
            else
            {
                ConPassword.PasswordChar = '*';
                password.PasswordChar = '*';
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassWord.PasswordChar = '\0';
                
            }
            else
            {
                txtPassWord.PasswordChar = '*';
                
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConPassword.Focus();
            }
        }

        private void ConPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegButton.PerformClick();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (reglogin.Text == "" && password.Text == "" && ConPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Fialed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text == ConPassword.Text)
            {
                MessageBox.Show("Your account Succesfully Created","Registration Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                ConPassword.Text = "";
                password.Focus();
            }
        }

        private void reglogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Focus();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin.PerformClick();
            }
        }
    }
}
