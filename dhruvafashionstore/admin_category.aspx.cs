using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dhruvafashionstore
{
    public partial class admin_category : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/category/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));


            string ins = "insert into categorys_tab values('" + txt_cat_name.Text + "','" +p + "','" + txt_cat_dis.Text + "','" + txt_cat_sta.Text + "')";
            int i = obj.sql_nonquery(ins);
            if (i == 1)
            {
                Label8.Text = "Category added";
              //  HyperLink1.Visible = true;
            }


        }
    }
}