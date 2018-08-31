using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace benCommon
{

/// <summary>
/// �Ƴ�һ���ļ������һ���޸ĵ��ļ���Ϣ
/// </summary>
    public class removelastfile
    {
        public removelastfile()
        { 
        }
        public static void removelast(ref FileInfo[] arr)
        {
            if (arr.Length>0)//��Ϊ��
            {
                FileInfo tempfile=arr[0];
            int ii=0;
            for (int i = 1; i < arr.Length; i++)
            {
                if( arr[ii].LastWriteTime < arr[i].LastWriteTime)
                {
                    ii = i;
                }
            }
            arr[ii] = null;
            }
            
        }
    }


//    ʹ�÷���: 
//System.IO.DirectoryInfo dir = new DirectoryInfo(currentFolder); 
//System.IO.FileInfo[] files = dir.GetFiles(); 
//MyQuickSort.QuickSort(files, 0, files.Length - 1);//��ʱ������ 
//ʹ�ú�: 
//���files�ĳ��ȴ���0,��ôfiles[0]Ϊ����ʱ�����µ��ļ�.
//��ϸ�����ο���http://www.jb51.net/article/8039.htm
    /// <summary> 
    /// ���������㷨 
    /// </summary> 
    public class MyQuickSort
    {
        public MyQuickSort()
        {
            // 
            // TODO: Add constructor logic here 
            // 
        }

        /// <summary> 
        /// ���������㷨 
        /// </summary> 
        /// ��������Ϊ���ȶ�����,ʱ�临�Ӷ�O(nlog2n),Ϊͬ���������������򷽷� 
        /// <param name="arr">���ֵ�����</param> 
        /// <param name="low">����Ͷ��ϱ�</param> 
        /// <param name="high">����߶��±�</param> 
        /// <returns></returns> 
        static int Partition(FileInfo[] arr, int low, int high)
        {
            //����һ�˿�������,�����������¼λ�� 
            // arr[0] = arr[low]; 
            FileInfo pivot = arr[low];//������������arr[0] 
            while (low < high)
            {
                while (low < high && arr[high].CreationTime <= pivot.CreationTime)
                    --high;
                //�����������¼С���Ƶ��Ͷ� 
                Swap(ref arr[high], ref arr[low]);
                while (low < high && arr[low].CreationTime >= pivot.CreationTime)
                    ++low;
                Swap(ref arr[high], ref arr[low]);
                //�����������¼����Ƶ��߶� 
            }
            arr[low] = pivot; //�������Ƶ���ȷλ�� 
            return low; //����������λ�� 
        }
        static void Swap(ref FileInfo i, ref FileInfo j)
        {
            FileInfo t;
            t = i;
            i = j;
            j = t;
        }
        /// <summary> 
        /// ���������㷨 
        /// </summary> 
        /// ��������Ϊ���ȶ�����,ʱ�临�Ӷ�O(nlog2n),Ϊͬ���������������򷽷� 
        /// <param name="arr">���ֵ�����</param> 
        /// <param name="low">����Ͷ��ϱ�</param> 
        /// <param name="high">����߶��±�</param> 
        public static void QuickSort(FileInfo[] arr, int low, int high)
        {
            if (low <= high - 1)//�� arr[low,high]Ϊ�ջ�ֻһ����¼�������� 
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

    }





    public class fileHandle
    {
        /*
��ȡini�ļ�����
using System.Runtime.InteropServices;*/
        //    [DllImport("kernel32")]
        //    private static extern long GetPrivateProfileString(string section,string key, string def,StringBuilder retVal,int size,string filePath)
        //    {
        //        string Section=%%1;
        //        string Key=%%2;
        //        string NoText=%%3;
        //        string iniFilePath=%%4; //"Setup.ini"
        //        string %%4=String.Empty;
        //    if(File.Exists(iniFilePath)){
        //        StringBuilder temp = new StringBuilder(1024);
        //GetPrivateProfileString(Section,Key,NoText,temp,1024,iniFilePath);
        //%%4=temp.ToString();
        //}

        /// <summary>
        /// <param name="var">FileInfo����</param>
        /// <param name="DestPath">DestPathΪ����·���������ļ���</param>
        /// ȡ����������ڸ��ǵ�ʱ����ͬ���ļ��� �½��ļ�������*** - @1, 
        /// ����ԭ�ļ���Ϊ123.txt, ��һ�θ���ȡ��123 - @1.txt 
        /// �ڶ��θ���ȡ��123 - @2.txt
        /// �����θ���ȡ��123 - @3.txt
        /// <returns>DataSet</returns>
        /// <returns>�Զ����һЩ����</returns>
        /// </summary>
        public static void fileMove(FileInfo var, ref string DestPath)
        {
            //string newpath = Path.Combine(DestPath, var.Name);
            //string s = string.Format("���ļ�{0}���ƶ���Ŀ¼{1},/n"+newpath, var.Name,DestPath);

            //     MessageBox.Show(s); //debug

            if (!File.Exists(DestPath))
            {
                var.MoveTo(DestPath);
            }
            else
            {
                string filenameH = Path.GetFileNameWithoutExtension(DestPath);//ȡ������׺���ļ���
                if (filenameH.Contains("@"))//�ж��Ƿ����Ѿ������������������ļ�
                {
                    int i = filenameH.LastIndexOf("@");
                    //��ȡ�����ļ���ţ����������Ĵ���
                    int fileNb = int.Parse(filenameH.Substring(filenameH.LastIndexOf("@") + 1)) + 1;
                    //�������ļ���
                    string newname = filenameH.Substring(0, filenameH.LastIndexOf("@") + 1) + fileNb.ToString() + Path.GetExtension(DestPath);
                    DestPath = Path.Combine(Path.GetDirectoryName(DestPath), newname);
                    fileMove(var, ref DestPath);
                }
                else
                {
                    //�״θ�����ݹ飻
                    string newname = filenameH + " - @1" + Path.GetExtension(DestPath);
                    DestPath = Path.Combine(Path.GetDirectoryName(DestPath), newname);
                    fileMove(var, ref DestPath);
                }
            }
        }


    }
}
