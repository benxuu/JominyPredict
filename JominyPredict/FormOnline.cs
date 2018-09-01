using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using benCommon;
using System.Data.SqlClient;

namespace JominyPredict
{
    public partial class FormOnline : Form
    {
        public FormOnline()
        {
            InitializeComponent();
        }
        DataSet myds = new DataSet();
        DataTable mytable = new DataTable();
        JominyCal cal1 = new JominyCal();
        
        BackgroundWorker bk = new BackgroundWorker();
        double c, mn, si, p, s, cu, ni, cr, v, ti, nb, mo, al, b;
        int rowID;
        baseClass.smpInfo smpInfo1 = new baseClass.smpInfo();//试样对应的算法及端淬值得点距离位置
        //读取oracle数据库记录到本地数据库，并打上读取标记
        //sampleId	steel	C	MN	SI	P	S	CU	NI	CR	V	TI	NB	MO	jominy1	jominy2	jominy3	jominy4	jominy5	isRead
        //tb_sample
        public void readData2()
        {
            //string sql = "select sampleId,steel,C,MN,SI,P,S,CU,NI,CR,V,TI,NB,MO from tb_sample  where isread is null or isread<>'true'";
            string sql = "select SMP_NO,STEEL_GRD,TRUSTDEED_NO,SPEC,C,MN,SI,P,S,CU,NI,CR,V,TI,NB,MO,AL,B  from NG.TF_IO_QUENCH_CHEM " +
                "where MSG_FLAG = 'N'";

            mytable = OracleHelper.GetDataTable(sql);
            //dataGridView1.DataSource = mytable.DefaultView;
            //逐行存入本地数据库，并在oracle原始记录上做读取标记
            for (int i = 0; i < mytable.Rows.Count; i++)
            {
                //if (baseClass.isOnly(mytable.Rows[i]["sampleId"].ToString()))
                if (true)
                {
                    // double c, mn, si, p, s, cu, ni, cr, v, ti, nb, mo; 
                    c = Convert.ToDouble(mytable.Rows[i]["c"] is DBNull ? 0 : mytable.Rows[i]["c"]);
                    mn = Convert.ToDouble(mytable.Rows[i]["MN"] is DBNull ? 0 : mytable.Rows[i]["MN"]);
                    si = Convert.ToDouble(mytable.Rows[i]["SI"] is DBNull ? 0 : mytable.Rows[i]["SI"]);
                    p = Convert.ToDouble(mytable.Rows[i]["P"] is DBNull ? 0 : mytable.Rows[i]["P"]);
                    s = Convert.ToDouble(mytable.Rows[i]["S"] is DBNull ? 0 : mytable.Rows[i]["S"]);
                    cu = Convert.ToDouble(mytable.Rows[i]["CU"] is DBNull ? 0 : mytable.Rows[i]["CU"]);
                    ni = Convert.ToDouble(mytable.Rows[i]["NI"] is DBNull ? 0 : mytable.Rows[i]["NI"]);
                    cr = Convert.ToDouble(mytable.Rows[i]["CR"] is DBNull ? 0 : mytable.Rows[i]["CR"]);
                    v = Convert.ToDouble(mytable.Rows[i]["V"] is DBNull ? 0 : mytable.Rows[i]["V"]);
                    ti = Convert.ToDouble(mytable.Rows[i]["TI"] is DBNull ? 0 : mytable.Rows[i]["TI"]);
                    nb = Convert.ToDouble(mytable.Rows[i]["NB"] is DBNull ? 0 : mytable.Rows[i]["NB"]);
                    mo = Convert.ToDouble(mytable.Rows[i]["MO"] is DBNull ? 0 : mytable.Rows[i]["MO"]);
                    al = Convert.ToDouble(mytable.Rows[i]["AL"] is DBNull ? 0 : mytable.Rows[i]["AL"]);
                    b = Convert.ToDouble(mytable.Rows[i]["B"] is DBNull ? 0 : mytable.Rows[i]["B"]);

                   // bool b1 = baseClass.ea.ExecuteNonQuery("insert into QUENCH_CHEM(SMP_NO,STEEL_GRD,TRUSTDEED_NO,SPEC,MSG_FLAG,C,MN,SI,P,S,CU,NI,CR,V,TI,NB,MO,AL,B) values('" +
                    bool b1 = db.ExcuteNonQuery("insert into QUENCH_CHEM(SMP_NO,STEEL_GRD,TRUSTDEED_NO,SPEC,MSG_FLAG,C,MN,SI,P,S,CU,NI,CR,V,TI,NB,MO,AL,B) values('" +
               
                    mytable.Rows[i]["SMP_NO"].ToString() + "','" +
                mytable.Rows[i]["STEEL_GRD"].ToString() + "','" +
                mytable.Rows[i]["TRUSTDEED_NO"].ToString() + "','" +
                mytable.Rows[i]["SPEC"].ToString() + "','" + "N" + "','" +
                c.ToString() + "','" + mn.ToString() + "','" + si.ToString() + "','" + p.ToString() + "','" +
                s.ToString() + "','" + cu.ToString() + "','" + ni.ToString() + "','" + cr.ToString() + "','" + v.ToString() + "','" + ti.ToString()
                + "','" + nb.ToString() + "','" + mo.ToString() + "','" + al.ToString() + "','" + b.ToString() + "')")>=0;
                }
                //else
                //{
                //    MessageBox.Show("编号为" + mytable.Rows[i]["sampleId"].ToString() + "的样品已存在！");
                //}

                //在oracle数据源做标记
                string errstr;
                bool b2 = OracleHelper.UpdateData(out errstr, "update NG.TF_IO_QUENCH_CHEM set MSG_FLAG = 'Y' where SMP_NO='" + mytable.Rows[i]["SMP_NO"].ToString() + "' and SMP_NO='" + mytable.Rows[i]["SMP_NO"].ToString() + "'");
                if (!b2)
                {
                    // MessageBox.Show(errstr);
                    return;
                }
            }

            //选取本地数据库中未计算的数据到mytable；
            sql = "select * from QUENCH_CHEM where MSG_FLAG='N'";
            mytable = db.ExcuteDataQuery(sql);
            dataGridView1.DataSource = mytable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OracleHelper.TestConn())
            {
                readData2();
                this.dataGridView1.DataSource = mytable.DefaultView;
            }
            else
            {
                MessageBox.Show("未能与检化验平台Oracle数据库建立连接，请检查网络或与信息中心联系！");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormOnline_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            //button4.Visible = false;
            bk.DoWork += new DoWorkEventHandler(bk_DoWork);
            bk.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bk_RunWorkerCompleted);
        }

        void bk_DoWork(object sender, DoWorkEventArgs e)
        { 

            ////计算端淬度
            //if (cal1.calculate())
            //{

            //}
            //else
            //{
            //    MessageBox.Show("钢种算法未设定！请到基础配置区配置以下钢种的预测算法：" + cal1.steel);
            //    //backgroundWorker1.CancelAsync();
            //}
      

            baseClass.dprogressbar(90);
        }

        void bk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //单笔计算完成后的处理
            baseClass.dstatusMsg("钢种编号为：" + mytable.Rows[rowID]["SMP_NO"].ToString() + "的数据计算完成！！");

            string sqlA = "insert into QUENCH_RSLT";
            string sqlQ = "insert into NG.TX_IO_QUENCH_RSLT";
            string sqlV="";
          //  switch (cal1.alg)
          //  {
          //      case "IEE690":
          //          sqlV = "(TRUSTDEED_NO,SMP_NO,INS_TS,JOMINY_DIST1,JOMINY_RST1,JOMINY_DIST2,JOMINY_RST2,JOMINY_DIST3,JOMINY_RST3,JOMINY_DIST4,JOMINY_RST4,JOMINY_DIST5,JOMINY_RST5," +
          //         " JOMINY_DIST6,JOMINY_RST6,JOMINY_DIST7,JOMINY_RST7,JOMINY_DIST8,JOMINY_RST8,JOMINY_DIST9,JOMINY_RST9,JOMINY_DIST10,JOMINY_RST10," +
          //         " MSG_FLAG) values( '" +
          //  mytable.Rows[rowID]["TRUSTDEED_NO"].ToString() + "','" +
          //  mytable.Rows[rowID]["SMP_NO"].ToString() + "','" +
          // DateTime.Now.ToString("yyyyMMddHHmmss") + "','" +
          // smpInfo1.dist1 + "','" +
          //   cal1.output[0].ToString("0.0") + "','" +
          //    smpInfo1.dist2 + "','" +
          //     cal1.output[1].ToString("0.0") + "','" +
          //     smpInfo1.dist3 + "','" +
          //      cal1.output[2].ToString("0.0") + "','" +
          //      smpInfo1.dist4 + "','" +
          //         cal1.output[3].ToString("0.0") + "','" +
          //       smpInfo1.dist5 + "','" +
          //         cal1.output[4].ToString("0.0") + "'" +
          //          smpInfo1.dist6 + "','" +
          //   cal1.output[5].ToString("0.0") + "','" +
          //    smpInfo1.dist7 + "','" +
          //     cal1.output[6].ToString("0.0") + "','" +
          //     smpInfo1.dist8 + "','" +
          //      cal1.output[7].ToString("0.0") + "','" +
          //      smpInfo1.dist9 + "','" +
          //         cal1.output[8].ToString("0.0") + "','" +
          //       smpInfo1.dist10 + "','" +
          //         cal1.output[9].ToString("0.0") + "'";
          //          break;

          //      default:
          //          sqlV = "(TRUSTDEED_NO,SMP_NO,INS_TS,JOMINY_DIST1,JOMINY_RST1,JOMINY_DIST2,JOMINY_RST2,JOMINY_DIST3,JOMINY_RST3,JOMINY_DIST4,JOMINY_RST4,JOMINY_DIST5,JOMINY_RST5,MSG_FLAG) values( '" +
          // mytable.Rows[rowID]["TRUSTDEED_NO"].ToString() + "','" +
          // mytable.Rows[rowID]["SMP_NO"].ToString() + "','" +
          //DateTime.Now.ToString("yyyyMMddHHmmss") + "','" +
          //smpInfo1.dist1 + "','" +
          //  cal1.output[0].ToString("0.0") + "','" +
          //   smpInfo1.dist2 + "','" +
          //    cal1.output[1].ToString("0.0") + "','" +
          //    smpInfo1.dist3 + "','" +
          //     cal1.output[2].ToString("0.0") + "','" +
          //     smpInfo1.dist4 + "','" +
          //        cal1.output[3].ToString("0.0") + "','" +
          //      smpInfo1.dist5 + "','" +
          //        cal1.output[4].ToString("0.0") + "'";
          //          break;
          //  }




            //存入检化验平台；
            string sql = sqlQ + sqlV + ",'N')";
            string outstr;

            //将已计算的数据行打标记
            sql = "update QUENCH_CHEM set MSG_FLAG='Y' where SMP_NO='" + mytable.Rows[rowID]["SMP_NO"].ToString() + "' and TRUSTDEED_NO='" + mytable.Rows[rowID]["TRUSTDEED_NO"].ToString() + "'";
            db.ExcuteNonQuery(sql); 
            if (OracleHelper.UpdateData(out outstr, sql))
            {

                //计算结果成功存入检化验，后保存到本地
                sql = sqlA + sqlV + ",'Y')";
                db.ExcuteNonQuery(sql); 


            }
            else
            {
                //计算结果未存入检化验，后保存到本地
                sql = sqlA + sqlV + ",'N')";
                db.ExcuteNonQuery(sql); 

                baseClass.dstatusMsg(outstr);
            } 
            //alg(++rowID);
        }

        //检查数据，将未上传平台的数据上传，未下载的数据下载，保持同步
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select TRUSTDEED_NO,SMP_NO,INS_TS,JOMINY_DIST1,JOMINY_RST1,JOMINY_DIST2,JOMINY_RST2,JOMINY_DIST3,JOMINY_RST3,JOMINY_DIST4,JOMINY_RST4,JOMINY_DIST5,JOMINY_RST5," +
              " JOMINY_DIST6,JOMINY_RST6,JOMINY_DIST7,JOMINY_RST7,JOMINY_DIST8,JOMINY_RST8,JOMINY_DIST9,JOMINY_RST9,JOMINY_DIST10,JOMINY_RST10 " +
             " from QUENCH_RSLT where MSG_FLAG='N'";
            //OleDbDataReader da = baseClass.ea.ExecuteDataReader(sql);
            SqlDataReader da=  db.ExcuteReader(sql);
            if (da.HasRows)
            {
                do
                {

                    string sqlQ = "insert into NG.TX_IO_QUENCH_RSLT";
                    string sqlV = "(TRUSTDEED_NO,SMP_NO,INS_TS,JOMINY_DIST1,JOMINY_RST1,JOMINY_DIST2,JOMINY_RST2,JOMINY_DIST3,JOMINY_RST3,JOMINY_DIST4,JOMINY_RST4,JOMINY_DIST5,JOMINY_RST5," +
                                             " JOMINY_DIST6,JOMINY_RST6,JOMINY_DIST7,JOMINY_RST7,JOMINY_DIST8,JOMINY_RST8,JOMINY_DIST9,JOMINY_RST9,JOMINY_DIST10,JOMINY_RST10, " +
                            "MSG_FLAG) values( '" +
                     da.GetValue(0).ToString() + "','" +
                      da.GetValue(1).ToString() + "','" +
                     da.GetValue(2).ToString() + "','" +
                      da.GetValue(3).ToString() + "','" +
                      da.GetValue(4).ToString() + "','" +
                     da.GetValue(5).ToString() + "','" +
                      da.GetValue(6).ToString() + "','" +
                      da.GetValue(7).ToString() + "','" +
                     da.GetValue(8).ToString() + "','" +
                      da.GetValue(9).ToString() + "','" +
                      da.GetValue(10).ToString() + "','" +
                     da.GetValue(11).ToString() + "','" +
                      da.GetValue(12).ToString() + "','" +
                      da.GetValue(13).ToString() + "','" +
                      da.GetValue(14).ToString() + "','" +
                     da.GetValue(15).ToString() + "','" +
                      da.GetValue(16).ToString() + "','" +
                      da.GetValue(17).ToString() + "','" +
                     da.GetValue(18).ToString() + "','" +
                      da.GetValue(19).ToString() + "','" +
                      da.GetValue(20).ToString() + "','" +
                     da.GetValue(21).ToString() + "','" +
                      da.GetValue(22).ToString() +

                      "','N')";

                    //存入检化验平台；
                    string sql1 = sqlQ + sqlV;
                    string outstr;
                    if (OracleHelper.UpdateData(out outstr, sql))
                    {
                        //计算结果成功存入检化验，后保存到本地
                        sql = "updata QUENCH_RSLT set MSG_FLAG='Y' where TRUSTDEED_NO='" + da.GetValue(0).ToString() + "' and SMP_NO='" + da.GetValue(1).ToString() + "'";
                        db.ExcuteNonQuery(sql);
                       
                    }
                    else
                    {
                        //计算结果未存入检化验，后保存到本地
                        MessageBox.Show("数据上传失败，样品编号：" + da.GetValue(0).ToString() + "' 样品编号：'" + da.GetValue(1).ToString() + "错误消息：" + outstr);
                    }

                } while (da.Read());

            }
        }
    }
}
