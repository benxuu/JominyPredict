﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JominyPredict
{
    public partial class FormDataView : Form
    {
        public FormDataView()
        {
            InitializeComponent();
        }

        private void FormDataView_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“jominyDBDataSet.tbSample”中。您可以根据需要移动或删除它。
            this.tbSampleTableAdapter.Fill(this.jominyDBDataSet.tbSample);

        }
    }
}
