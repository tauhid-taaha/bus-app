using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediBot
{
    public partial class viewuser : UserControl
    {
        function1 fn = new function1();
        String query;
        
        public viewuser()
        {
            InitializeComponent();
        }

        private void viewuser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void searchuser_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like'" + searchuser.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void userdltbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from users where username='" + username + "'";
                fn.setdata(query, "User Record Deleted.");
                viewuser_Load(this, null);
            }
        }
        String username;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch { }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            viewuser_Load(this, null);
        }
    } 
}
