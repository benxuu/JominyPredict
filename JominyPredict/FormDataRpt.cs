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
        }

        private void FormDataRpt_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jominyDBDataSet1.tbSample”中。您可以根据需要移动或删除它。
            this.tbSampleTableAdapter.Fill(this.jominyDBDataSet1.tbSample);

            this.reportViewer1.RefreshReport();
        }
    }
}
