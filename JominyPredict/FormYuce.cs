using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using benCommon;
using System.Data.SqlClient;
 
 

namespace JominyPredict
{
    public partial class FormYuce : Form
    {
        public FormYuce()
        {
            InitializeComponent();
        }

        private void FormYuce_Load(object sender, EventArgs e)
        {
            DataTable algdt = new DataTable();
            algdt = db.ExcuteDataQuery("select Id, steel, alg from  tbSteelAlg order by Id asc");
            comboBox1.DisplayMember = "steel";
            comboBox1.ValueMember = "alg";
            comboBox1.DataSource = algdt;
        }

        JominyCal jc = new JominyCal();
        private void btCal_Click(object sender, EventArgs e)
        {            
            string sampleID = textBox1.Text.ToString();
            if ( sampleID == "")
            {
                MessageBox.Show("请输入钢种编号！");
                return;
            }
            else

                if (baseClass.isOnly(sampleID))
                //if (true)	 
                {
                     string alg = comboBox1.SelectedValue.ToString();
                     string steel = comboBox1.Text; 
                    double c = Convert.ToDouble(tbC.Text.ToString());
                    double mn = Convert.ToDouble(tbMn.Text.ToString());
                    double si = Convert.ToDouble(tbSi.Text.ToString()); 
                    double ni = Convert.ToDouble(tbNi.Text.ToString());
                    double cr = Convert.ToDouble(tbCr.Text.ToString()); 
                    double ti = Convert.ToDouble(tbTi.Text.ToString()); 
                    double mo = Convert.ToDouble(tbMo.Text.ToString()); 
                    double b = Convert.ToDouble(tbB.Text.ToString());
 

                    //cal1.inputData = inputData;//传值
                    //获取钢种成分一维数组
                    double[] input = { c, mn, si,  ni, cr,  ti, mo,  b };
                 

                    //btCal.Enabled = false;
                    //var send = new object[4];//发送给计算线程的数据包
                    //send[0] = sampleID;
                    //send[1] = alg;
                    //send[2] = input;
                    //send[3] = steel;
 
                    baseClass.dstatusMsg("神经网络运行中，请耐心等待，不要关闭程序！！");
                    baseClass.dprogressbar(10);
                    //backgroundWorker1.WorkerSupportsCancellation = true;
                    //backgroundWorker1.RunWorkerAsync(send);//开始后台线程计算
                    //btCal.Enabled = false;
                    double[] ans = jc.steelcal_double(alg, input);
                    

                    baseClass.dstatusMsg("神经网络计算完成,正在进行后续数据处理！");
                
                    int ic = ans.Count();


                    //根据算法配置获取输出数据定义
                    //string sql_getcfg = string.Format("select * from tbSteelAlg where alg='{0}'",alg);
                    int outpoint;
                    bool issiglepoint = baseClass.isSinglePoints(alg, out outpoint);
                    string sql = string.Format("insert into tbSample( sampleId,steel, c, mn, si,  ni, cr,  ti, mo, b,jominy,algDateTime) values('{0}','{1}',{2},{3},{4},{5},{6},{7},{8},{9},'{10}','{11}')", sampleID, steel, input[0], input[1], input[2], input[3], input[4], input[5], input[6], input[7], ans, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    db.ExcuteNonQuery(sql);        
                    tbResult.AppendText("试件编号："+sampleID.ToString()+"  钢种："+steel);
                    tbResult.AppendText("\r\n测试时间："+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    tbResult.AppendText("\r\n化学成分："+ string.Format("c:{0}, mn:{1}, si:{2}, ni:{3}, cr:{4}, ti:{5}, mo:{6}, b:{7}", input[0], input[1], input[2], input[3], input[4], input[5], input[6], input[7]));
                   tbResult.AppendText("\r\n测试结果：");
                    if (issiglepoint)
                    {
                        Decimal dp1 = (Decimal)db.ExcuteScalar("select dp1 from tbSteelAlg where alg=" + alg);
                        tbResult.AppendText("\r\n距离1[" + dp1+"]:"+ans[0].ToString("0.000"));
                        string sql2 = "update tbSample set p1=" + ans[0];
                        for (int i = 2; i < ans.Count() + 2; i++)
                        {
                            sql2 += ",p" + i + "=" + ans[i-1];
                            Decimal dp = (Decimal)db.ExcuteScalar("select dp" + i + " from tbSteelAlg where alg=" + alg);
                            tbResult.AppendText("\r\n距离" + i + "[" + dp + "]:" + ans[i - 1].ToString("0.000"));
                        }
                        sql2 += string.Format("where sampleId='{0}'", sampleID);
                        db.ExcuteNonQuery(sql2);
                       
                    }
                    else
                    {
                        Decimal dp1 = (Decimal)db.ExcuteScalar("select dp1 from tbSteelAlg where alg='" + alg + "'");
                        tbResult.AppendText("\r\n距离1[" + dp1 + "]:" + ans[0].ToString("0.000") + "(正面)," + ans[1].ToString("0.000") + "(反面)");
                        string sql2 = string.Format("update tbSample set p1={0},n1={1}", ans[0], ans[1]);
                        for (int i = 2; i <= ans.Count() / 2; i++)
                        {                 
                            sql2 += string.Format(",p{0}={1},n{0}={2}", i, ans[2 * i - 2], ans[2 * i - 1]);
                            Decimal dp = (Decimal)db.ExcuteScalar("select dp" + i + " from tbSteelAlg where alg='" + alg + "'");
                            tbResult.AppendText("\r\n距离" + i + "[" + dp + "]:" + ans[2 * i - 2].ToString("0.000") + "(正面)," + ans[2 * i - 1].ToString("0.000") + "(反面)");
                        }
                        sql2 += string.Format(" where sampleId='{0}'", sampleID);
                        db.ExcuteNonQuery(sql2);
                    }
                    

                }
                else
                {
                    MessageBox.Show("钢种编号与历史记录重复，请核对编号！");
                    return;
                }
        }

    

     

        private void btReCal_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)

            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

        }

        
        

    }
}
