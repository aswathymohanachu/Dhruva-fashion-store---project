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
    public partial class cart_page : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(! IsPostBack)
            {
                grid();


            }
        }


        void grid()
        {
            string str = "select cart_tab.cart_id, products_tab.pro_img, products_tab.pro_name,cart_tab.cart_quantity,cart_tab.cat_item_total_price from products_tab join cart_tab on products_tab.pro_id=cart_tab.pro_id ";

            DataSet ds = obj.fn_DataSet(str);
           
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;//i=2;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);


            string del = "delete from cart_tab where cart_id=" + id + "";

            int k = obj.sql_nonquery(del);

            grid();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;//i=2;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtquan = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            // TextBox txtaddre = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];

            string select = "select * from cart_tab where cart_id=" + id + "";
            SqlDataReader cart = obj.Fn_DataReader(select);

            while (cart.Read())
            {
                Label1.Text = cart["pro_id"].ToString();
            }
                int proid = Convert.ToInt32(Label1.Text);



            string sel = "select * from products_tab where pro_id=" + proid + "";
            SqlDataReader price = obj.Fn_DataReader(sel);

            while (price.Read())
            {
                Label1.Text = price["pro_price"].ToString();
            }


            int pric = Convert.ToInt32(Label1.Text);

            //string sel= "select pro_price from products_tab where pro_id=" +proid + "";
            // int pri = obj.sql_nonquery(sel);

            // int prr = (Convert.ToInt32(txtquan.Text) * Convert.ToInt32(pri));

            int quan = Convert.ToInt32(txtquan.Text);
            int prr = quan * pric;



              string strr = "update cart_tab set cart_quantity=" + txtquan.Text + ",cat_item_total_price=" + prr + " where cart_id=" + id + "";


             int k = obj.sql_nonquery(strr);


            GridView1.EditIndex = -1;
            grid();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {





        }
    }
}









