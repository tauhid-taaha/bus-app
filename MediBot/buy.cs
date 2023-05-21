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
    public partial class buy : UserControl
    {
        function1 fn = new function1();
        String query;
        DataSet ds;
        public buy()
        {
            InitializeComponent();
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            Int64 a = Int64.Parse(amounthave.Text);
            Int64 b= Int64.Parse(Totaltk.Text);
            if (a > b) { MessageBox.Show("You have to pay " + Totaltk.Text);
                Int64 c = a - b;
                query = "update users set ammount =" + c + " where username ='" + searchuser.Text + "'";
                fn.setdata(query, "Ticket Bought!");
            }
            else { MessageBox.Show("you don't have enough money!"); }
        }

        private void buy_Load(object sender, EventArgs e)
        {
            userlist.Items.Clear();
            query = "select username from users where  ammount >'0'";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                userlist.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void searchuser_TextChanged(object sender, EventArgs e)
        {
            userlist.Items.Clear();
            query = "select username from users where username like '" + searchuser.Text + "%' and ammount>'0'";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                userlist.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void userlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            String name = userlist.GetItemText(userlist.SelectedItem);
            passangertxtbox.Text = name;
            query = "select ammount from users where username='" + name + "'";
            ds = fn.GetData(query);
            amounthave.Text = ds.Tables[0].Rows[0][0].ToString();

        }

       
        

        private void totalseat_TextChanged_1(object sender, EventArgs e)
        {
            if (totalseat.Text != "")
            {
                Int64 a = Int64.Parse(totalseat.Text);
                Int64 noOfUnit = Int64.Parse(Unitprice.Text);
                Int64 total = a * noOfUnit;
                Totaltk.Text = total.ToString();
            }
            else
            {
                Totaltk.Clear();
            }

        }
    }
}
