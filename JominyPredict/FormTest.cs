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
             //double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.00215 };
             double[,] minput = { { 0.3294 }, { 1.0320 }, { 0.2880 }, { 0.0300 }, { 0.1670 }, { 0.0262 }, { 0.0108 }, { 0.00215 } };
            // object[] a = sc.calculate(1,calname, minput);

             MWNumericArray input = (MWNumericArray)minput;
            MWArray d = sc.calculate(calname, input); 
            MWNumericArray x2 = (MWNumericArray)d; 
            double[,] dx3 = (double[,])x2.ToArray(MWArrayComponent.Real);

            double[] result = new double[dx3.GetLength(0)];
            for (int i = 0; i < dx3.GetLength(0); i++)
            {
                result[i] = dx3[i, 0];
            }

            string ss = string.Empty;
            for (int i = 0; i < result.Count(); i++)
            {
                ss += result[i].ToString("0.000") + ",";
            }
            MessageBox.Show(ss); 




            //MWCharArray calname = this.alg;
            //// double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
            //MWNumericArray x = (MWNumericArray)this.input;
            //MWNumericArray d = (MWNumericArray)m.calculate(calname, x);
            ////MWArray d = sc.calculate((MWArray)calname,(MWArray)x);
            ////double[] s1 = new double[10];
            //this.output = (double[])d.ToVector(MWArrayComponent.Real);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JominyCal jc = new JominyCal();
            string calname = "net1E0669";
            double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.00215 };
            MessageBox.Show(jc.steelcal_string(calname,inputd));
        }
    }
}
