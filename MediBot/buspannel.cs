using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediBot
{
    public partial class buspannel : Form
    {
        String user = "";
        
        public buspannel()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public buspannel(String username)
        {
            InitializeComponent();
            
            user = username;
           viewuser1 a = new viewuser1();
            a.ID = ID;

        }
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
          ;
            uC_adduser1.Visible = true;
            uC_adduser1.BringToFront();
            loadgif.Visible = false;
           //uC_dashboard1.Visible = false;
            Welcomemesg.Visible = false;

        }

        

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            //Form1 guna1 = new Form1();
            //guna1.Show();
            //this.Hide();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //uC_dashboard1.Visible = true;
            //uC_dashboard1.BringToFront();
            loadgif.Visible = false;
            Welcomemesg.Visible = false;
        }

        private void medpannel_Load(object sender, EventArgs e)
        {
           // uC_dashboard1.Visible=false;
            uC_adduser1.Visible=false;
            adminlog1.Visible=false;
            loadgif.Visible=true; loadgif.BringToFront();
            Welcomemesg.Visible = true;Welcomemesg.BringToFront();


        }

        private void viewuserbtn_Click(object sender, EventArgs e)
        {
            viewuser1.Visible=true;
            viewuser1.BringToFront();
            uC_adduser1.Visible = false;
            loadgif.Visible=false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            reserve1.Visible=true;
            reserve1.BringToFront();
            uC_adduser1.Visible=false;
            loadgif.Visible=false;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            viewreserve1.Visible=true;
            viewreserve1.BringToFront(); uC_adduser1.Visible=false; loadgif.Visible=false;
            viewuser1.Visible = false;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            buy1.Visible = true;
            buy1.BringToFront();
            uC_adduser1.Visible=false;
            loadgif.Visible=false;
            viewreserve1.Visible = false;
        }
    }
}
