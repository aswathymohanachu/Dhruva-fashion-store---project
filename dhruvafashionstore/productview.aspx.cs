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
    public partial class productview : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             int id = Convert.ToInt32(Session["cat_id"]);


            string str = "select * from products_tab where cat_id= " + id + " ";
          
            DataSet ds = obj.fn_DataSet(str);
            DataList1.DataSource = ds;
            DataList1.DataBind();

            }

               
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {

            int id = Convert.ToInt32(e.CommandArgument);
            
             Session["pro_id"] = id;
             Response.Redirect("product_details.aspx");
        }
    }
}