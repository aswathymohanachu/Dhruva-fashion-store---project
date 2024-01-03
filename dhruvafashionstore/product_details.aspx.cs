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
    public partial class product_details : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                int id = Convert.ToInt32(Session["pro_id"]);


                string str = "select * from products_tab where pro_id= " + id + " ";
                SqlDataReader dr = obj.Fn_DataReader(str);



                while (dr.Read())
                {
                    Label1.Text = dr["pro_name"].ToString();
                    Label2.Text = dr["pro_discrip"].ToString();
                    Label3.Text = dr["pro_price"].ToString();
                    Label4.Text = dr["pro_status"].ToString();

                    Image2.ImageUrl = dr["pro_img"].ToString();
                }






            }





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string select = "select max(cart_id) from cart_tab";
            string cart = obj.sql_scalar(select);
            int cart_id = 0;
            if (cart == "")
            {
                cart_id = 1;

            }
            else
            {
                int newcartid = Convert.ToInt32(cart);
                cart_id = newcartid + 1;

            }
            int total = (Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(Label3.Text));

            // Label9.Text = Convert.ToString(total);


            string ins = "insert into cart_tab values(" + cart_id + "," + Session["pro_id"] + "," + Session["userid"] + "," + TextBox1.Text + "," + total + ")";
            int i = obj.sql_nonquery(ins);
            if (i == 1)
            {
                HyperLink1.Visible = true;
            }


        }
    }
}