using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dhruvafashionstore
{
    public partial class adminreg : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string select = "select max(reg_id) from login_tab";
            string regid = obj.sql_scalar(select);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;

            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;

            }
            string ins = "insert into admins_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ")";
            int i = obj.sql_nonquery(ins);
            //if (i == 1)
            //{
            //    Label5.Text = "inserted ";
            //}

            string inser = "insert into login_tab values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
            int j = obj.sql_nonquery(inser);

            if (j == 1)
            {
                HyperLink2.Visible = true;
            }

        }
    }
}