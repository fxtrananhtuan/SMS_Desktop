using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        services.DesktopEndpointClient _client = new services.DesktopEndpointClient();

        private void cmd_signin_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text.Trim()=="")
            {
                ErrorPro.SetError(txt_pass, "please check your password!");
            }
            else
            {
                ErrorPro.Clear();
            }
            if (txt_User.Text.Trim() == "")
            {
                ErrorPro.SetError(txt_pass, "please check your user name!");
            }
            else
            {
                ErrorPro.Clear();
            }
            string sql = "select * from Account where password='"+txt_pass.Text.Trim()+"' and email='"+txt_User.Text.Trim()+"' ";
            try
            {
               
                if(_client.CheckSignin(sql))
                {
                    GlobalVarible._Account = _client.GetID(sql);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address == email)
                    return true;
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void cmd_SignUp_Click(object sender, EventArgs e)
        {
            GlobalVarible._CheckSignUp = true;
            this.Close();
        }
    }
}
