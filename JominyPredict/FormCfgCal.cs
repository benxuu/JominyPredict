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
    public partial class FormCfgCal : Form
    {
        public FormCfgCal()
        {
            InitializeComponent();
        }

        private void FormCfgCal_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jominyDBDataSet.tbSteelAlg”中。您可以根据需要移动或删除它。
            this.tbSteelAlgTableAdapter.Fill(this.jominyDBDataSet.tbSteelAlg);

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.tbSteelAlgTableAdapter.Update(this.jominyDBDataSet.tbSteelAlg);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.tbSteelAlgTableAdapter.Fill(this.jominyDBDataSet.tbSteelAlg);
        }
    }
}
