using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Data.SqlClient;

namespace dhruvafashionstore
{
    public partial class userpage1 : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            string str = "select * from categorys_tab";
            // SqlDataAdapter da = new SqlDataAdapter(str, con);
            //  DataSet ds = new DataSet();
            // da.Fill(ds);

            DataSet ds = obj.fn_DataSet(str);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            }
          
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
                  }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            // string sel = "select * from products_tab where cat_id =" + id + "";
            Session["cat_id"] = id;
            Label3.Text = Convert.ToString(Session["cat_id"]) ;
            Response.Redirect("productview.aspx");
          

        }
    }
}