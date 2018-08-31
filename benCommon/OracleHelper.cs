using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;
using System.Data;
using System.Configuration;


namespace benCommon
{
    public static class OracleHelper
    {

        //private static string _sConnString = string.Empty;

        private static string _sConnString = ConfigurationManager.AppSettings["OracleConnString"]; 
        //string sConnStr = @"Data Source=**;User Id=**;Password=**;"; 
        public static string ConnString
        {
            get { return _sConnString; }
            set { _sConnString = value; }
        }

        /// <summary>
        /// 测试连接是否成功
        /// </summary>
        /// <param name="sConnStr"></param>
        /// <returns></returns>
        public static bool TestConn(string sConnStr = "")
        {
            OracleConnection myConn = null;
            bool bResult = false;
            try
            {
                if (string.IsNullOrEmpty(sConnStr)) sConnStr = _sConnString;
                myConn = new OracleConnection(_sConnString);
                myConn.Open();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (myConn != null && myConn.State.ToString() == "Open")
                    bResult = true;
            }

            myConn.Close();
            return bResult;
        }
        /// <summary>
        /// 返回datatable对象
        /// </summary>
        /// <param name="sErr">错误信息</param>
        /// <param name="sSQL"></param>
        /// <param name="sConnStr"></param>
        /// <param name="cmdParams"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(out string sErr, string sSQL, string sConnStr = "", params OracleParameter[] cmdParams)
        {
            DataTable dt = null;
            sErr = string.Empty;

            if (string.IsNullOrEmpty(sConnStr)) sConnStr = _sConnString;

            OracleConnection accConn = null;
            try
            {
                accConn = new OracleConnection(sConnStr);
                OracleCommand accCmd = new OracleCommand(sSQL, accConn);
                accConn.Open();

                if (cmdParams != null)
                {
                    foreach (OracleParameter parm in cmdParams)
                        accCmd.Parameters.Add(parm);
                }

                OracleDataAdapter adapter = new OracleDataAdapter(accCmd);
                dt = new DataTable();
                adapter.Fill(dt);
                accConn.Close();
            }
            catch (Exception ex)
            {
                sErr = ex.Message;
            }
            return dt;
        }

        /// <summary>
        /// 返回datatable对象
        /// </summary>
        /// <param name="sErr">错误信息</param>
        /// <param name="sSQL"></param>
        /// <param name="sConnStr"></param>
        /// <param name="cmdParams"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sSQL)
        {
            DataTable dt = null;
            // sErr = string.Empty;
            string sConnStr = _sConnString;

            OracleConnection accConn = null;
            try
            {
                accConn = new OracleConnection(sConnStr);
                OracleCommand accCmd = new OracleCommand(sSQL, accConn);
                accConn.Open();

                OracleDataAdapter adapter = new OracleDataAdapter(accCmd);
                dt = new DataTable();
                adapter.Fill(dt);
                accConn.Close();
            }
            catch (Exception ex)
            {
                // sErr = ex.Message;
            }
            return dt;
        }

        // 取dataset 
        public static DataSet GetDataSet(out string sError, string sSQL, string sConnStr = "", params OracleParameter[] cmdParams)
        {
            DataSet ds = null;
            sError = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(sConnStr)) sConnStr = _sConnString;

                OracleConnection conn = new OracleConnection(sConnStr);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sSQL;

                if (cmdParams != null)
                {
                    foreach (OracleParameter parm in cmdParams)
                        cmd.Parameters.Add(parm);
                }

                OracleDataAdapter dapter = new OracleDataAdapter(cmd);
                ds = new DataSet();
                dapter.Fill(ds);
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return ds;
        }

        // 取某个单一的元素 
        public static object GetSingle(out string sError, string sSQL, string sConnStr)
        {
            DataTable dt = GetDataTable(out sError, sSQL, sConnStr);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0][0];
            }

            return null;
        }

        // 取最大的ID 
        public static Int32 GetMaxID(out string sError, string sKeyField, string sTableName, string sConnStr = null)
        {
            DataTable dt = GetDataTable(out sError, "select nvl(max(" + sKeyField + "),0) as MaxID from " + sTableName, sConnStr);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            return 0;
        }

        // 执行insert,update,delete 动作，也可以使用事务 
        public static bool UpdateData(out string sError, string sSQL, string sConnStr = "", OracleParameter[] cmdParams = null, bool bUseTransaction = false)
        {
            int iResult = 0;
            sError = string.Empty;
            if (string.IsNullOrEmpty(sConnStr)) sConnStr = _sConnString;

            if (!bUseTransaction)
            {
                try
                {
                    OracleConnection conn = new OracleConnection(sConnStr);
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sSQL;

                    if (cmdParams != null)
                    {
                        foreach (OracleParameter parm in cmdParams)
                            cmd.Parameters.Add(parm);
                    }

                    iResult = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    sError = ex.Message;
                    iResult = -1;
                }
            }
            else // 使用事务 
            {
                OracleTransaction trans = null;
                try
                {
                    OracleConnection conn = new OracleConnection(sConnStr);
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    trans = conn.BeginTransaction();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sSQL;

                    if (cmdParams != null)
                    {
                        foreach (OracleParameter parm in cmdParams)
                            cmd.Parameters.Add(parm);
                    }

                    cmd.Transaction = trans;
                    iResult = cmd.ExecuteNonQuery();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    sError = ex.Message;
                    iResult = -1;
                    trans.Rollback();
                }
            }

            return iResult > 0;
        }

        // 执行insert,update,delete 动作，也可以使用事务 
        public static bool UpdateData(out string sError, string sSQL)
        {
            int iResult = 0;
            sError = string.Empty;
            string sConnStr = _sConnString;
            try
            {
                OracleConnection conn = new OracleConnection(sConnStr);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sSQL;
                iResult = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                iResult = -1;
            }

            return iResult > 0;
        }

        private static void PrepareCommand(OracleCommand cmd, OracleConnection conn, OracleTransaction trans, string cmdText, OracleParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType; 
            if (cmdParms != null)
            {
                foreach (OracleParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                    (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

    }
}