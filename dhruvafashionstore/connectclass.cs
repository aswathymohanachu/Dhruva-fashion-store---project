using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace dhruvafashionstore
{
    public class connectclass
    {
        SqlConnection con;
        SqlCommand cmd;
        public connectclass()
        {
            con = new SqlConnection(@"server=DESKTOP-C01RUCG\SQLEXPRESS;database=dhruva;integrated security=true");

        }

        public int sql_nonquery(string sqlquery)//update,insert,delete
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;


        }

        public string sql_scalar(string sqlquery)//select
        {


            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }

        public SqlDataReader Fn_DataReader(string sqlquery)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public DataSet fn_DataSet(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public DataTable fn_DataTable(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }


    }
}