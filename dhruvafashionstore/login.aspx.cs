using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dhruvafashionstore
{
    public partial class login : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(reg_id) from login_tab where username='" + TextBox1.Text + "' and password ='" + TextBox2.Text + "'";
            string i = obj.sql_scalar(str);
            if (i == "1")
            {
                string str1 = "select log_id from login_tab where username='" + TextBox1.Text + "' and password ='" + TextBox2.Text + "'";
                string k = obj.sql_scalar(str1);
                int l = Convert.ToInt32(k);
                Session["userid"] = l;

                string str2 = "select log_type from login_tab where log_id=" + Session["userid"] + "";
                string ty = obj.sql_scalar(str2);
                if (ty == "admin")
                {
                    Response.Redirect("ADMIN_page1.aspx");
                }
                else if (ty == "user")
                {
                    Response.Redirect("userpage.aspx");
                }


            }

        }
    }
}
