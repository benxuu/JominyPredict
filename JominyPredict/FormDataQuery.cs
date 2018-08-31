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
    public partial class FormDataQuery : Form
    {
        public FormDataQuery()
        {
            InitializeComponent();
           
        }

        private void FormDataQuery_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jominyDBDataSet.tbSample”中。您可以根据需要移动或删除它。
            this.tbSampleTableAdapter.Fill(this.jominyDBDataSet.tbSample);
            dataGridView1.ReadOnly = true;
            btcancel.Enabled = false;
            btsave.Enabled = false;

        }

        private void bteditenbale_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            btcancel.Enabled = true;
            btsave.Enabled = true;
        }

        private void btsave_Click(object sender, EventArgs e)
        {

            btcancel.Enabled = false;
            btsave.Enabled = false;
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            btcancel.Enabled = false;
            btsave.Enabled = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dataGridView1.Rows.Count != 0)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; )
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.SandyBrown;
                    i += 2;
                }
            }
        }
    }
}
