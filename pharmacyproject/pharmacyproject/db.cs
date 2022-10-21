﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyproject
{
    // this class is for database insertion updattion
    // this class handle all the database connection to c# work
    class db
    {
        // this is how we get the connection string;
        // instead of writing all the time we will call this function
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            // here catalog is the database name pharmacyMangment
            con.ConnectionString = "Data Source=.;Initial Catalog=pharmacyManagment;Integrated Security=True";
            return con;
        }

        // this function will return the query
        // this function accept the connection string
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            // here we have filled the dataset object with the data
            // coming formthe database
            da.Fill(ds);


            return ds;
        }

        // function to set the data

        public void setData(string query, string message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();

            //  passing the connection  in the cmd;
            cmd.Connection = con;
            con.Open();
            // now we have to fire the  query select * fom user like etc
            // now this query is passed into the cmd'
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
