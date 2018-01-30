using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace SMS_Desktop
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        services.DesktopEndpointClient _client = new services.DesktopEndpointClient();
        private void Customer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _client.Load_Group();
            
        }
    }
}
