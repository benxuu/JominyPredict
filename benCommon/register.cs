using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Management;

namespace benCommon
{
    public  class register
    {

            public string _HashText; //待加密的字符串
            public string HashText
            {
                set
                {
                    _HashText = value;
                }
                get
                {
                    return _HashText;
                }
            }
            

            /// 使用MD5CryptoServiceProvider类产生哈希值。不需要提供密钥。
            /// </summary>
            /// <returns></returns>
            public string MD5Hasher()
            {
                byte[] MD5Data = System.Text.Encoding.UTF8.GetBytes(_HashText);
                MD5 Md5 = new MD5CryptoServiceProvider();
                byte[] Result = Md5.ComputeHash(MD5Data);
                return Convert.ToBase64String(Result); //返回长度为字节字符串

            }

            //获取cpu序列号
            public String GetCpuID()
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                String strCpuID = null;
                foreach (ManagementObject mo in moc)
                {
                    strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strCpuID;
            }



            //获取硬盘序列号
            public String GetDriveID()
            {

                ManagementObject mo = new ManagementObject("win32_LogicalDisk.deviceid=\"c:\"");
                mo.Get();
                return mo.GetPropertyValue("VolumeSerialNumber").ToString();
            }

            ///得到机器码
        public string GetComputerID()
        {
           // HashText = GetCpuID() + GetDriveID();
            HashText = "messer" + GetDriveID();
            return MD5Hasher().Substring(8, 5);
        }


            //最终的序列号//m为配置文件值  
        public string regSN()
        {
            HashText = GetComputerID();
            return MD5Hasher();
        }
        public string regSN(string computerID)
        {
            HashText = computerID;
            return MD5Hasher();
        }
        }

        ////获取硬盘
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Hasher hash = new Hasher();
        //    textBox1.Text = hash.hashGetDriveID().ToString();

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Hasher shit = new Hasher();
        //    textBox1.Text = shit.Sern();

        //}

        ////
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Hasher shit = new Hasher();
        //    textBox1.Text = shit.GetDriveID();

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Hasher shit = new Hasher();
        //    textBox1.Text = shit.GetCpuID();

        //}


    }

