using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediBot
{
    public partial class reserve : UserControl
    {function1 fn= new function1();
        String query;
        public reserve()
        {
            InitializeComponent();
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            if (traveldob.Text != "" && passangertxtbox.Text != "" && tocombo.Text != "" && fromcombo.Text != "" && seatnmbr.Text != "" && totalseat.Text != "" )
            {
                String name = passangertxtbox.Text;
                String from = fromcombo.Text;
                String to = tocombo.Text;
                String dob = traveldob.Text;
                String seatnbr = seatnmbr.Text;
                Int64 totalseat1 = Int64.Parse(totalseat.Text);

                try
                {
                    query = "insert into reserve (Name,from1,to1,Traveldob,Seatnumbr,Totalseat) values('" + name + "','" + from + "','" + to + "','" + dob + "','" + seatnbr + "'," + totalseat1 + ")";
                    fn.setdata(query, "Reserve Successful.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Seat already Reserved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Enter all the information to SignUp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            passangertxtbox.Clear();
            fromcombo.SelectedIndex = -1;
            tocombo.SelectedIndex = -1;
            traveldob.ResetText();
            seatnmbr.Clear();
            totalseat.Clear();
        }
    }
}
