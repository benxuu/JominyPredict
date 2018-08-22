using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using steelnet;
namespace JominyPredict
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            steelnet.Calculate sc = new Calculate();
            MWCharArray calname = "net1E0669";
             double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
             MWNumericArray x = (MWNumericArray)inputd;
            MWNumericArray d = (MWNumericArray)sc.calculate(calname, x);
            //MWArray d = sc.calculate((MWArray)calname,(MWArray)x);
            double[] s1 = (double[])d.ToVector(MWArrayComponent.Real);
            
            string ss = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                ss += s1[i].ToString() + ",";
            }
            MessageBox.Show(ss); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JominyCal jc = new JominyCal();
            string calname = "net1E0669";
            double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
            MessageBox.Show(jc.steelcal_string(calname,inputd));
        }
    }
}
