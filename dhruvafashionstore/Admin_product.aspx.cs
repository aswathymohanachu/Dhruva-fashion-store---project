using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dhruvafashionstore
{
    public partial class Admin_product : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/category/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));


            string ins = "insert into products_tab values(" + txtcat_id.Text + ",'" + txt_name.Text + "','" + p + "'," + txt_price.Text + ",'" +txt_dis.Text + "','" + txt_stat.Text + "','" + txt_stock.Text + "')";
            int i = obj.sql_nonquery(ins);
            if (i == 1)
            {
                Label9.Text = "Product Added";
                HyperLink3.Visible = true;
                 
            }

        }
    }
}