using Microsoft.Reporting.WinForms;
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
    public partial class FormDataRpt : Form
    {
        public FormDataRpt()
        {
            InitializeComponent();
            baseClass.wtFormRptshowData = showData;
        }

        private void FormDataRpt_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;//填充父窗体    
            this.reportViewer1.RefreshReport();
        }
        query q = new query();
        public void showData()
        {

            DialogResult result = q.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReportDataSource rs = new ReportDataSource("DataSetRpt", q.newDatetable);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rs);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("你没选择任何数据！");
            }
        }
    }
}
