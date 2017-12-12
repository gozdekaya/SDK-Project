using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp16.Models;

namespace WindowsFormsApp16
{
    public static class DB
    {

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            }
        }

        public static bool InsertUpdateDelete(string sqlquery)
        {
            SqlConnection c = new SqlConnection();
            try
            {

                c.ConnectionString = ConnectionString;

                if (c.State == System.Data.ConnectionState.Closed)
                {
                    c.Open();
                }

                SqlCommand cmd = new SqlCommand(sqlquery, c);
                return cmd.ExecuteNonQuery() != -1;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (c.State == System.Data.ConnectionState.Open)
                {
                    c.Close();
                }
            }
        }

        //public static DataTable Update(string queryupdate,DataTable dt)
        //{
        //    SqlConnection c = new SqlConnection();
        //    try
        //    {
        //        c.ConnectionString = ConnectionString;

        //        if (c.State == System.Data.ConnectionState.Closed)
        //        {
        //            c.Open();
        //        }
        //        SqlCommand cmd = new SqlCommand(queryupdate, c);
                
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return dt;
        //}

        public static DataTable Select(string sqlquery)
        {
            SqlConnection c = new SqlConnection();
            try
            {

                c.ConnectionString = ConnectionString;

                if (c.State == System.Data.ConnectionState.Closed)
                {
                    c.Open();
                }

                SqlCommand cmd = new SqlCommand(sqlquery, c);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (c.State == System.Data.ConnectionState.Open)
                {
                    c.Close();
                }
            }
        }


       
    }


  
}
