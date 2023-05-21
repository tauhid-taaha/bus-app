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
    public partial class viewreserve : UserControl
    {
        function1 fn = new function1();
        String query;
        public viewreserve()
        {
            InitializeComponent();
        }
        String username;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch { }
        }

        private void searchuser_TextChanged(object sender, EventArgs e)
        {
            query = "select * from reserve where Name like'" + searchuser.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void viewreserve_Load(object sender, EventArgs e)
        {
            query = "select * from reserve";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void reservedltbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from reserve where Name='" + username + "'";
                fn.setdata(query, "User Record Deleted.");
                viewreserve_Load(this, null);
            }
        }
    }
}
