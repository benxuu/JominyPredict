using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
 

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
            // TODO:  这行代码将数据加载到表“jominyDBDataSet1.tbSample”中。您可以根据需要移动或删除它。
            this.tbSampleTableAdapter.Fill(this.jominyDBDataSet1.tbSample);
            // TODO:  这行代码将数据加载到表“jominyDBDataSet.tbSteelAlg”中。您可以根据需要移动或删除它。
            this.tbSteelAlgTableAdapter.Fill(this.jominyDBDataSet.tbSteelAlg);
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
                    btCal.Enabled = false;
                    var send = new object[4];//发送给计算线程的数据包
                    send[0] = sampleID;
                    send[1] = alg;
                    send[2] = input;
                    send[3] = steel;
 
                    baseClass.dstatusMsg("神经网络运行中，请耐心等待，不要关闭程序！！");
                    baseClass.dprogressbar(10);
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    backgroundWorker1.RunWorkerAsync(send);//开始后台线程计算
                }
                else
                {
                    MessageBox.Show("钢种编号与历史记录重复，请核对编号！");
                    return;
                }
        }

        private void FormYuce_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var receive = e.Argument as object[];
            string sampleid = (string)receive[0];
            string alg = (string)receive[1];
            double[] input = (double[])receive[2];
            string  steel=(string)receive[3];
           // MessageBox.Show("钢种算法："+alg+"--sampleid:"+sampleid+"--input:"+input[0]);
            int i = 9;
            backgroundWorker1.ReportProgress(i, String.Format("当前值是 {0} ", i));
           // MessageBox.Show(jc.steelcal_string(alg,input));
            string ans=jc.steelcal_string(alg,input);
            MessageBox.Show(ans);
           // double[] ans = jc.steelcal_double(alg, input);
            //存储数据到datagrid；
            //string sql = "insert into tbSample( sampleId,steel,c, mn, si,  cu, ni, cr, v, ti,mo,al,b,jominy1,jominy2,jominy3,jominy4,jominy5,jominy6,jominy7,jominy8,jominy9,jominy10,alg,isalg,algdatetime) " +
            //                        "values('" + cal1.sampleID + "','" + cal1.steel + "','" + cal1.input[0] + "','" + cal1.input[1] + "','" + cal1.input[2] + "','" + cal1.input[3] + "','" + cal1.input[4] + "','" + cal1.input[5] + "','" + cal1.input[6] + "','" + cal1.input[7] + "','" + cal1.input[8] + "','" + cal1.input[9] + "','" + cal1.input[10] + "','" +
            //                               cal1.output[0].ToString("0.000") + "','" + cal1.output[1].ToString("0.000") + "','" + cal1.output[2].ToString("0.000") + "','" + cal1.output[3].ToString("0.000") + "','" + cal1.output[4].ToString("0.000") + "','" +
            //                               cal1.output[5].ToString("0.000") + "','" + cal1.output[6].ToString("0.000") + "','" + cal1.output[7].ToString("0.000") + "','" + cal1.output[8].ToString("0.000") + "','" + cal1.output[9].ToString("0.000") + "','" +
            //                               cal1.alg + "',true,'" + DateTime.Now.ToString() + "')";
            string sql = string.Format("insert into tbSample( sampleId,steel, c, mn, si,  ni, cr,  ti, mo, b,jominy,algDateTime) values('{0}','{1}',{2},{3},{4},{5},{6},{7},{8},{9},'{10}','{11}')", sampleid, steel, input[0], input[1], input[2], input[3], input[4], input[5], input[6], input[7], ans, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") );
            SqlHelper.ExecuteNonQuerySql(SqlHelper.connStr,sql);
            this.tbSampleTableAdapter.Fill(this.jominyDBDataSet1.tbSample);
            i = 99;
            backgroundWorker1.ReportProgress(i, String.Format("当前值是 {0} ", i));
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("计算完成！");
            btCal.Enabled = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //进度参数转换
           // this.progressBar1.Value = e.ProgressPercentage;
            baseClass.dprogressbar(e.ProgressPercentage);
            baseClass.dstatusMsg(e.UserState.ToString());
             
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.tbSampleTableAdapter.Update(this.jominyDBDataSet1.tbSample);
            //for (int i = 0; i < this.ds_sample.Tables["tb_sample"].Rows.Count; i++)
            //{
            //    this.ds_sample.Tables["tb_sample"].Rows[i]["issave"] = true;

            //}
            //this.tb_sampleTableAdapter.Update(ds_sample);
            //filldatagridview();
            MessageBox.Show("保存成功！！");
        }
        

    }
}
