using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using benCommon;

namespace JominyPredict
{
    public partial class query : Form
    {
        public query()
        {
            InitializeComponent();
        }
        public query(bool steel = true, bool alg = true)
        {

            InitializeComponent();
            cbSteel.Enabled = steel;
            //cbAlg.Enabled = alg;
        }
        public DataTable newDatetable;
        //确定
        private void button1_Click(object sender, EventArgs e)
        {

            if (tbSampleID.Text == "")
            {
                DateTime d1, d2;
                d1 = dateTimePicker1.Value;
                d2 = dateTimePicker2.Value;
                string   steel;
                //alg = cbAlg.Text;
                steel = cbSteel.Text;
                //标准加序号查询
                //select Format(1+Dcount('1','tb_sample', a.id & '>id'),'0000') AS id, sampleId,steel,c, mn, si, p, s, cu, ni, cr, v, ti, nb, mo,jominy1,jominy2,jominy3,jominy4,jominy5,alg,algdatetime from tb_sample as a where isalg=true and algDatetime >= #2012-2-29# and algDatetime<=#2012-3-30# order by id asc
                //string sql = "select Format(1+Dcount('1','tb_sample', a.id & '>id'),'0000') AS id, sampleId,steel,c, mn, si, p, s, cu, ni, cr, v, ti, nb, mo,jominy1,jominy2,jominy3,jominy4,jominy5,alg,algdatetime from tb_sample  as a  where isalg=true and algDatetime >= #" + d1.ToShortDateString() + "# and algDatetime<=#" + d2.ToShortDateString() + "#";
                string sql = "select   sampleId,steel,c, mn, si, ni, cr,  ti,  mo, B,  p1,n1,p2,n2,p3,n3,p4,n4,p5,n5,p6,n6,p7,n7,p8,n8,p9,n9,p10,n10,p11,n11,p12,n12,p13,n13,p14,n14,p15,n15,algdatetime from tbsample where  algDatetime >= '" + d1.ToString("yyyy-MM-dd") + "' and algDatetime<='" + d2.ToString("yyyy-MM-dd") + "'";

                //if (alg != "")
                //{
                //    sql += "and alg='" + alg + "' ";
                //}
                if (steel != "")
                {
                    sql += "and steel='" + steel + "'";
                }
                if (cbOrder.Text == "降序")
                {
                    sql += " order by algdatetime desc";
                }
                else
                {
                    sql += " order by algdatetime asc";
                }

                this.newDatetable = db.ExcuteDataQuery(sql);

                ////修改id
                //for (int i = 0; i < newDatetable.Rows.Count; i++)
                //{
                //    newDatetable.Rows[i]["id"] = i + 1;
                //}
            }
            else
            {
                string sql = "select   sampleId,steel,c, mn, si, ni, cr,  ti,  mo, B,  p1,n1,p2,n2,p3,n3,p4,n4,p5,n5,p6,n6,p7,n7,p8,n8,p9,n9,p10,n10,p11,n11,p12,n12,p13,n13,p14,n14,p15,n15,algdatetime from tbsample where  sampleId= '" + tbSampleID.Text +   "'";
                this.newDatetable = db.ExecuteDataTable(sql);
                if (this.newDatetable.Rows.Count == 0)
                {
                    MessageBox.Show("您查找的钢种编号信息不存在！");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void query_Load(object sender, EventArgs e)
        {
            //// TODO: 这行代码将数据加载到表“ds_AlgEl.tb_AlgEl”中。您可以根据需要移动或删除它。
            //this.tb_AlgElTableAdapter.Fill(this.ds_AlgEl.tb_AlgEl);
            //// TODO: 这行代码将数据加载到表“ds_steelAlg.tb_steelAlg”中。您可以根据需要移动或删除它。
            //this.tb_steelAlgTableAdapter.Fill(this.ds_steelAlg.tb_steelAlg);
            DataTable dtsteel = db.ExcuteDataQuery("select distinct steel from tbSample");
            cbSteel.DataSource = dtsteel;
            cbSteel.DisplayMember = "steel";
            cbSteel.ValueMember = "steel";
            DataRow row = dtsteel.NewRow();
            row["steel"] = "";
            dtsteel.Rows.InsertAt(row, 0);
            this.cbSteel.SelectedIndex = -1;

            this.dateTimePicker2.MaxDate = Convert.ToDateTime("2023-12-12");
            this.dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            this.dateTimePicker2.Value = DateTime.Now.AddDays(1);

            //System.Data.DataTable dt = ds_AlgEl.Tables[0];
            //System.Data.DataRow row = dt.NewRow();
            //row["alg"] = "";
            //dt.Rows.InsertAt(row, 0);
            //DataTable dt2 = this.ds_steelAlg.Tables[0];
            //DataRow row2 = dt2.NewRow();
            //row2["steel"] = "";
            //dt2.Rows.InsertAt(row2, 0);
            //this.cbAlg.SelectedIndex = -1;
            //this.cbSteel.SelectedIndex = -1;
            this.cbOrder.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
