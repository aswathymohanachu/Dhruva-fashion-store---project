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
    public partial class casual_shirt : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {

            string str = "select * from products_tab";
            // SqlDataAdapter da = new SqlDataAdapter(str, con);
            //  DataSet ds = new DataSet();
            // da.Fill(ds);

            DataSet ds = obj.fn_DataSet(str);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}