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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GlobalVarible._login.ShowDialog();
            if(GlobalVarible._CheckSignUp)
            {
                CGlobalFunction.openFormCenter(this, GlobalVarible._signup);
            }
            else if(GlobalVarible._Account!="")
            {
                               
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
