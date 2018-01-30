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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        services.DesktopEndpointClient _client = new services.DesktopEndpointClient();
        services.DTO_Account _account = new services.DTO_Account();

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            GetInformation();
        }
        private void GetInformation()
        {
            _account.email = txt_email.Text;
            _account.Name = txt_fullName.Text;
            _account.Phone = txt_mobile.Text;
            _account.Password = txt_password.Text;
            _account.state = txt_state.Text;
            _account.street = txt_number.Text + " " + txt_street.Text;
            _account.city = txt_suburb.Text;
            _account.create_date = DateTime.Now;
            if(txt_postcode.Text!="")
            {
                _account.zip = Convert.ToInt16(txt_postcode.Text);
            }
           
            

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            _account.ID = _client.RandomID();
            txt_ID.Text = _account.ID;
        }


        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
