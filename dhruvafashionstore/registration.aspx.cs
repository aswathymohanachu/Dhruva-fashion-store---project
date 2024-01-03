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
    public partial class registration : System.Web.UI.Page
    {
        connectclass obj = new connectclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                string s = "select * from state";
                 DataSet ds = obj.fn_DataSet(s);

                  DropDownList1.DataSource = ds;
           

                DropDownList1.DataTextField = "state_name";
                DropDownList1.DataValueField = "state_id";
                DropDownList1.DataBind();


               

            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select * from district where state_id=" + DropDownList1.SelectedValue+ "";
            DataSet ds = obj.fn_DataSet(s);
            DropDownList2.DataSource = ds;


            DropDownList2.DataTextField = "dis_name";
            //DropDownList1.DataValueField = "state_id";
            DropDownList2.DataBind();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = "select * from district where state_id= " + DropDownList1.SelectedValue+ " ";
            DataSet dst = obj.fn_DataSet(st);
            DropDownList2.DataSource = dst;


            DropDownList2.DataTextField = "dis_name";
            //DropDownList1.DataValueField = "d_id";
            DropDownList2.DataBind();


            //    string s = "select * from district where state_id="+DropDownList1.SelectedItem.Value+" ";
            //    DataSet ds = obj.fn_DataSet(s);
            //    DropDownList2.DataSource = ds;


            //    DropDownList2.DataTextField = "dis_name";
            //    //DropDownList1.DataValueField = "d_id";
            //    DropDownList2.DataBind();


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
            string ins = "insert into users_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','"+DropDownList1.SelectedItem.Text+ "','" + DropDownList2.SelectedItem.Text + "'," + TextBox5.Text + ")";
            int i = obj.sql_nonquery(ins);
            string inser = "insert into login_tab values(" + reg_id + ",'" + TextBox6.Text + "','" + TextBox7.Text + "','user','active')";
            int j = obj.sql_nonquery(inser);
            if (j == 1)
            {
                // Label12.Visible = true;

                // Label12.Text = "***Registration Completed start Shopping**** ";
                HyperLink2.Visible = true;
            }
        }
    }
}