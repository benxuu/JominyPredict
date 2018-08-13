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

                //if (baseClass.isOnly( sampleID))
                if (true)	 
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
 
                    baseClass.dstatusMsg("神经网络运行中，请耐心等待，不要关闭程序！！");
                    baseClass.dprogressbar(10);
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    backgroundWorker1.RunWorkerAsync();//开始后台线程计算
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
            MessageBox.Show("钢种算法未设定！请到基础配置区配置以下钢种的预测算法：");
            //计算端淬度
            //if (cal1.calculate())
            //{

            //}
            //else
            //{
            //    cal1.alg = "";
            //    MessageBox.Show("钢种算法未设定！请到基础配置区配置以下钢种的预测算法：" + cal1.steel);
            //    backgroundWorker1.CancelAsync();

            //}
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        { 
        }

    }
}
