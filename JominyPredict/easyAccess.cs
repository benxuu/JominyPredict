using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Collections; 
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
using System.IO;
namespace JominyPredict
{
    public class EasyAccess
    {
        /**/
        /// <summary>
        /// 连接数据库字符串
        /// </summary>
        private string connectionString;

        /**/
        /// <summary>
        /// 存储数据库连接（保护类，只有由它派生的类才能访问）
        /// </summary>
        protected OleDbConnection Connection;

        /**/
        /// <summary>
        /// 构造函数：数据库的默认连接
        /// </summary>
        public EasyAccess()
        {
            string connStr;
            connStr = ConfigurationManager.AppSettings["ConnectionString"]; 
              //  AppSettingsReader["ConnectionString"].ConnectionString.ToString();
           // connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
            // connStr = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"].ToString(); //从web.config配置中读取
            connectionString = connStr;
            //connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + HttpContext.Current.Request.PhysicalApplicationPath + connStr;       
            Connection = new OleDbConnection(connectionString);
        }

        /**/
        /// <summary>
        /// 构造函数：带有参数的数据库连接
        /// </summary>
        /// <param name="newConnectionString"></param>
        public EasyAccess(string newConnectionString)
        {
            connectionString = newConnectionString;
            Connection = new OleDbConnection(connectionString);
        }

        /**/
        /// <summary>
        /// 获得连接字符串
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        /**/
        /// <summary>
        /// 执行批处理（事务）
        /// </summary>
        /// <param name="arrlist"></param>
        /// <returns></returns>
        public bool ExecuteBatch(ArrayList arrlist)
        {
            bool bFlag = true;
            string strSQL = string.Empty;

            Connection.Open();
            OleDbCommand command = null;
            using (OleDbTransaction myTrans = Connection.BeginTransaction())
            {
                try
                {
                    foreach (Object objSql in arrlist)
                    {
                        strSQL = objSql.ToString().Trim();
                        if (!string.IsNullOrEmpty(strSQL))
                            command = new OleDbCommand(strSQL, Connection, myTrans);
                    }
                    myTrans.Commit();
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    try
                    {
                        string lstrFileFolder = "";//HttpContext.Current.Server.MapPath(@"~\log\");
                        string filename = "SqlErr_" + System.DateTime.Today.ToString("yyyyMMdd");
                        string path = lstrFileFolder + filename;
                        //判断目录是否存在，不存在就建立 
                        if (!Directory.Exists(lstrFileFolder))
                        {
                            Directory.CreateDirectory(lstrFileFolder);
                        }
                        //写文件，文件存在则追加文本，不存在则创建新文件
                        FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter m_streamWriter = new StreamWriter(fs);
                        m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                        m_streamWriter.WriteLine(" =============== [" + System.DateTime.Now.ToString() + "] =============== ");
                        m_streamWriter.WriteLine(e.ToString());
                        m_streamWriter.WriteLine("---------------------------------------");
                        m_streamWriter.WriteLine(strSQL);
                        m_streamWriter.WriteLine("---------------------------------------");
                        m_streamWriter.WriteLine(" ");
                        m_streamWriter.Flush();
                        m_streamWriter.Close();
                    }
                    catch { }
                    bFlag = false;
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                    {
                        Connection.Close();
                    }
                    if (Connection != null)
                    {
                        Connection.Dispose();
                    }
                }
            }

            return bFlag;
        }

        /**/
        /// <summary>
        /// 执行SQL语句没有返回结果，如：执行删除、更新、插入等操作
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>操作成功标志</returns>
        public bool ExecuteNonQuery(string strSQL)
        {
            bool resultState = false;

            Connection.Open();
            OleDbTransaction myTrans = Connection.BeginTransaction();
            OleDbCommand command = new OleDbCommand(strSQL, Connection, myTrans);

            try
            {
                command.ExecuteNonQuery();
                myTrans.Commit();
                resultState = true;
            }
            catch
            {
                myTrans.Rollback();
                resultState = false;
            }
            finally
            {
                Connection.Close();
            }
            return resultState;
        }
        /**/
        /// <summary>
        /// 执行SQL语句没有返回结果，如：执行删除、更新、插入等操作
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>影响的行数</returns>
        public int ExecuteNonQueryInt(string strSQL)
        {
            int result = 0;

            Connection.Open();
            OleDbTransaction myTrans = Connection.BeginTransaction();
            OleDbCommand command = new OleDbCommand(strSQL, Connection, myTrans);

            try
            {
                result = command.ExecuteNonQuery();
                myTrans.Commit();
            }
            catch
            {
                myTrans.Rollback();
                result = 0;
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }

        /// <summary>
        /// 执行查询，返回结果集中的第一行第一列的值，忽略其他行列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExcuteScalar(string sql)
        {
            //using (SqlConnection con = new SqlConnection(conString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    return cmd.ExecuteScalar();
            //    //con.Close();
            //}
            //int result = 0;
            object result;
            Connection.Open();
            OleDbTransaction myTrans = Connection.BeginTransaction();
            OleDbCommand command = new OleDbCommand(sql, Connection, myTrans);

            try
            {
                result = command.ExecuteScalar();
                myTrans.Commit();
            }
            catch
            {
                myTrans.Rollback();
                result = 0;
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }
        /**/
        /// <summary>
        /// 执行SQL语句返回结果到DataReader中
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>dataReader</returns>
        public OleDbDataReader ExecuteDataReader(string strSQL)
        {
            Connection.Open();
            OleDbCommand command = new OleDbCommand(strSQL, Connection);
            OleDbDataReader dataReader = command.ExecuteReader();
            Connection.Close();

            return dataReader;
        }

        /**/
        /// <summary>
        /// 执行SQL语句返回结果到DataSet中
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns>DataSet</returns>
        public DataSet ExecuteDataSet(string strSQL)
        {
            Connection.Open();
            DataSet dataSet = new DataSet();
            OleDbDataAdapter OleDbDA = new OleDbDataAdapter(strSQL, Connection);
            OleDbDA.Fill(dataSet, "myDataSet");

            Connection.Close();
            return dataSet;
        }

        /**/
        /// <summary>
        /// 执行SQL语句返回结果到DataTable中
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string strSQL)
        {
            return this.ExecuteDataSet(strSQL).Tables[0];
        }
    }
}
