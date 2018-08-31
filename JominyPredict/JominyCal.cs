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
        public double[] steelcal_double(string steeltype, double[] input)
        {
            double[,] inputdata = new double[,] { { input[0] }, { input[1] }, { input[2] }, { input[3] }, { input[4] }, { input[5] }, { input[6] }, { input[7] } };
          
            MWCharArray calname = steeltype;
            //double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
            MWNumericArray x = (MWNumericArray)inputdata;
            MWNumericArray d = (MWNumericArray)sc.calculate(calname, x);
            //MWNumericArray x2 = (MWNumericArray)d;
            double[,] ddout = (double[,])d.ToArray(MWArrayComponent.Real);
            double[] result = new double[ddout.GetLength(0)];//根据第一列长度生成结果数组；
            for (int i = 0; i < ddout.GetLength(0); i++)
            {
                result[i] = ddout[i, 0];
            }
            //MWArray d = sc.calculate((MWArray)calname,(MWArray)x);
            //double[] s1 = new double[36];
            return result;
        }
        //public decimal[] steelcal_double(string steeltype, double[] input)
        //{
        //    double[,] inputdata = new double[,] { { input[0] }, { input[1] }, { input[2] }, { input[3] }, { input[4] }, { input[5] }, { input[6] }, { input[7] } };

        //    MWCharArray calname = steeltype;
        //    //double[] inputd = { 0.3294, 1.0320, 0.2880, 0.0300, 0.1670, 0.0262, 0.0108, 0.0022 };
        //    MWNumericArray x = (MWNumericArray)inputdata;
        //    MWNumericArray d = (MWNumericArray)sc.calculate(calname, x);
        //    //MWNumericArray x2 = (MWNumericArray)d;
        //    double[,] ddout = (double[,])d.ToArray(MWArrayComponent.Real);
        //    decimal[] result = new decimal[ddout.GetLength(0)];//根据第一列长度生成结果数组；
        //    for (int i = 0; i < ddout.GetLength(0); i++)
        //    {
        //        result[i] = Convert.ToDecimal(ddout[i, 0]);
        //    }
        //    //MWArray d = sc.calculate((MWArray)calname,(MWArray)x);
        //    //double[] s1 = new double[36];
        //    return result;
        //}

        public string steelcal_string(string steeltype, double[] inputdata) {
            double[] rsd = steelcal_double(steeltype, inputdata);
            string ss = string.Empty;
            for (int i = 0; i < rsd.Count(); i++)
            {
                ss += rsd[i].ToString("0.000") + ",";
            }
            return ss;

        }

        public   string doubletostring(double[] doubledata)
        {

            string ss = string.Empty;
            int x = doubledata.Count();
            for (int i = 0; i < x; i++)
            {
                ss += doubledata[i].ToString("0.000") + ",";
            }
            return ss;
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
