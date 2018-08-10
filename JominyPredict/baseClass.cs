using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace JominyPredict
{
    class baseClass
    {
        private void AccessAppSettings()
        {
            //获取Configuration对象
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //根据Key读取<add>元素的Value
            string name = config.AppSettings.Settings["name"].Value;
            //写入<add>元素的Value
            config.AppSettings.Settings["name"].Value = "fx163";
            //增加<add>元素
            config.AppSettings.Settings.Add("url", "http://www.fx163.net");
            //删除<add>元素
            config.AppSettings.Settings.Remove("name");
            //一定要记得保存，写不带参数的config.Save()也可以
            config.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        //public delegate double[] calJominy(double[,] input);
        public delegate void weituo();
        //定义状态栏字符串和数值签名委托委托
        public delegate void delegateStr(string s);
        public delegate void delegateInt(int intValue);
        public static delegateStr dstatusMsg;
        public static delegateInt dprogressbar;
        public static weituo wtFormRptshowData;
        public static weituo wtFormRptfigshowData;
        public static weituo wtFormRptCXshowData;
        //public static weituo loadyuce;
        public static weituo closestart;
        //自定义事件委托
        public delegate void eventDelegate(object sender, myEventArgs e);
        public static EasyAccess ea = new EasyAccess();

        /// <summary>
        /// 测试样品编号是否已存在，返回true表示唯一（不存在），返回false表示已存在
        /// </summary>
        /// <param name="sampleId"></param>
        /// <returns></returns>
        public static bool isOnly(string sampleId)
        {
            string sql = "select count(*) from tb_sample where sampleID='" + sampleId + "'";
            return (int)ea.ExcuteScalar(sql) < 1;
        }
        //测试检化验平台oracle数据库是否连通
        public static bool isOraceConn()
        {
            return OracleHelper.TestConn();
        }
        /// <summary>
        /// 获取指定钢种的对应算法
        /// </summary>
        /// <param name="steel"></param>
        /// <returns></returns>
        public static string getAlg(string steel)
        {
            string sql = "select alg from tb_steelalg where steel='" + steel + "'";
            if (ea.ExcuteScalar(sql) is DBNull)
            {
                return "";
            }
            else
            {
                return (string)ea.ExcuteScalar(sql);
            }

        }
        public class smpInfo
        {

            // public  string STEEL_GRD;
            //  public  string SPEC;
            public string alg;
            public string dist1;
            public string dist2;
            public string dist3;
            public string dist4;
            public string dist5;
            public string dist6;
            public string dist7;
            public string dist8;
            public string dist9;
            public string dist10;
            public string dist11;
            public string dist12;
            public bool isConfig = false;
        }

        //根据钢种类型、规格，获取钢种信息，如预测点距离、是否已配置该试样算法。
        public static smpInfo getsmpInfo(string STEEL_GRD, string SPEC)
        {
            string sql = "select  * from tb_steelAlg where steel='" + STEEL_GRD + "' and spec='" + SPEC + "'";
            smpInfo s = new smpInfo();
            System.Data.DataTable dt1 = ea.ExecuteDataTable(sql);
            //System.Data

            if (dt1.Rows.Count > 0)
            {
                s.dist1 = dt1.Rows[0]["DIST1"].ToString();
                s.dist2 = dt1.Rows[0]["DIST2"].ToString();
                s.dist3 = dt1.Rows[0]["DIST3"].ToString();
                s.dist4 = dt1.Rows[0]["DIST4"].ToString();
                s.dist5 = dt1.Rows[0]["DIST5"].ToString();
                s.dist6 = dt1.Rows[0]["DIST6"].ToString();
                s.alg = dt1.Rows[0]["alg"].ToString();
                s.isConfig = true;
            }
            else
            {
                s.isConfig = false;
            }

            return s;
        }
    }

    public class inputD
    {
        public inputD()
        {
            c = 0.00;
            mn = 0.00;
            si = 0.00;
            p = 0.00;
            s = 0.00;
            cu = 0.00;
            ni = 0.00;
            cr = 0.00;
            v = 0.00;
            ti = 0.00;
            nb = 0.00;
            mo = 0.00;
            al = 0.00;
            b = 0.00;
        }

        public double c;
        public double mn;
        public double si;
        public double p;
        public double s;
        public double cu;
        public double ni;
        public double cr;
        public double v;
        public double ti;
        public double nb;
        public double mo;
        public double al;
        public double b;

    }

}
