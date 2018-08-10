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
    public partial class FormStarting : Form
    {
        public FormStarting()
        {
            InitializeComponent();
            baseClass.closestart = this.closeStart;
        }
        public void closeStart()
        {
            this.Close();
        }
    }
}
