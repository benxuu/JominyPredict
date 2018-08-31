using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using System.Collections;

namespace benCommon
{
    public class db
    {

        //public static string conString = ConfigurationManager.ConnectionStrings["dblocal"].ToString();
        public static readonly string conString = ConfigurationManager.ConnectionStrings["JominyPredict.Properties.Settings.jominyDBConnectionString"].ConnectionString;
       // public static string conString =ConfigurationManager.AppSettings["ConnectionString"]; 
        public static bool contest() 
        {
           using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                   
                    if (con.State==ConnectionState.Open)
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                   
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }



        /// <summary>
        /// 执行增，删，改的基方法
        /// </summary>
        /// <param name="sql">有效的sql语句</param>
        /// <param name="param">参数集合</param>
        /// <returns>影响的行数</returns>
        public static int ExcuteNonQuery(string sql, SqlParameter[] param)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    int count = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                    return count;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 执行增，删，改的基方法
        /// </summary>
        /// <param name="sql">有效的sql语句</param>
        /// <param name="param">参数集合</param>
        /// <returns>影响的行数</returns>
        public static int ExcuteNonQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int count = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                    return count;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 执行查询的基方法
        /// </summary>
        /// <param name="sql">有效的sql语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExcuteDataQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                sda.Fill(table);
                con.Close();
                return table;
            }
        }
        public static DataTable ExecuteDataTable(string sql) {
            return ExcuteDataQuery(sql);
        }

        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">有效的sql语句</param>
        /// <returns>返回DataReader</returns>
        public static SqlDataReader ExcuteReader(string sql)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">有效的sql语句</param>
        /// <param name="param">返回DataReader</param>
        /// <returns>返回DataReader</returns>
        public static SqlDataReader ExcuteReader(string sql, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddRange(param);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return reader;

        }
        /// <summary>
        /// 执行查询，返回结果集中的第一行第一列的值，忽略其他行列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExcuteScalar(string sql)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                return cmd.ExecuteScalar();
                //con.Close();
            }
        }


    }
}
