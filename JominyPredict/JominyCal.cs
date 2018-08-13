using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Arrays;
using steelnet;

namespace JominyPredict
{

    public class JominyCal
    {
        steelnet.Calculate sc = new Calculate();

        //static steelnet.Calculate sc = new Calculate();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="steeltype">"net1E0669"</param>
        /// <param name="inputdata">{ 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 }</param>
        /// <returns></returns>
        public double[] steelcal(string steeltype, double[] inputdata)
        {

            MWCharArray calname = steeltype;
            //double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
            MWNumericArray x = (MWNumericArray)inputdata;
            MWNumericArray d = (MWNumericArray)sc.calculate(calname, x);
            //MWArray d = sc.calculate((MWArray)calname,(MWArray)x);
            double[] s1 = new double[36];
            return (double[])d.ToVector(MWArrayComponent.Real);
        }

        //  steelnet.Calculate sc = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Test1");
            //steelnet.Calculate c = new Calculate();
            steelnet.Calculate sc = new Calculate();
            //   sc = new Calculate();
            MWCharArray calname = "net1E0669";
            double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
            MWNumericArray x = (MWNumericArray)inputd;
            MWNumericArray d = (MWNumericArray)sc.calculate(calname, x);
            //MWArray d = sc.calculate((MWArray)calname,(MWArray)x);
            double[] s1 = new double[10];
            s1 = (double[])d.ToVector(MWArrayComponent.Real);
            string ss = "ans:";
            for (int i = 0; i < 10; i++)
            {
                ss += s1[i].ToString() + "--";
            }

            //MessageBox.Show(ss);
            //  MessageBox.Show("Test2");
        }
    }
}
