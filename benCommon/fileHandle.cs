using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace benCommon
{

/// <summary>
/// 移除一组文件中最后一次修改的文件信息
/// </summary>
    public class removelastfile
    {
        public removelastfile()
        { 
        }
        public static void removelast(ref FileInfo[] arr)
        {
            if (arr.Length>0)//不为空
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


//    使用方法: 
//System.IO.DirectoryInfo dir = new DirectoryInfo(currentFolder); 
//System.IO.FileInfo[] files = dir.GetFiles(); 
//MyQuickSort.QuickSort(files, 0, files.Length - 1);//按时间排序 
//使用后: 
//如果files的长度大于0,那么files[0]为创建时间最新的文件.
//详细出处参考：http://www.jb51.net/article/8039.htm
    /// <summary> 
    /// 快速排序算法 
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
        /// 快速排序算法 
        /// </summary> 
        /// 快速排序为不稳定排序,时间复杂度O(nlog2n),为同数量级中最快的排序方法 
        /// <param name="arr">划分的数组</param> 
        /// <param name="low">数组低端上标</param> 
        /// <param name="high">数组高端下标</param> 
        /// <returns></returns> 
        static int Partition(FileInfo[] arr, int low, int high)
        {
            //进行一趟快速排序,返回中心轴记录位置 
            // arr[0] = arr[low]; 
            FileInfo pivot = arr[low];//把中心轴置于arr[0] 
            while (low < high)
            {
                while (low < high && arr[high].CreationTime <= pivot.CreationTime)
                    --high;
                //将比中心轴记录小的移到低端 
                Swap(ref arr[high], ref arr[low]);
                while (low < high && arr[low].CreationTime >= pivot.CreationTime)
                    ++low;
                Swap(ref arr[high], ref arr[low]);
                //将比中心轴记录大的移到高端 
            }
            arr[low] = pivot; //中心轴移到正确位置 
            return low; //返回中心轴位置 
        }
        static void Swap(ref FileInfo i, ref FileInfo j)
        {
            FileInfo t;
            t = i;
            i = j;
            j = t;
        }
        /// <summary> 
        /// 快速排序算法 
        /// </summary> 
        /// 快速排序为不稳定排序,时间复杂度O(nlog2n),为同数量级中最快的排序方法 
        /// <param name="arr">划分的数组</param> 
        /// <param name="low">数组低端上标</param> 
        /// <param name="high">数组高端下标</param> 
        public static void QuickSort(FileInfo[] arr, int low, int high)
        {
            if (low <= high - 1)//当 arr[low,high]为空或只一个记录无需排序 
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
读取ini文件属性
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
        /// <param name="var">FileInfo对象</param>
        /// <param name="DestPath">DestPath为绝对路径，包含文件名</param>
        /// 取名规则：如果在覆盖的时候发现同名文件， 新建文件名规则：*** - @1, 
        /// 例如原文件名为123.txt, 第一次覆盖取名123 - @1.txt 
        /// 第二次覆盖取名123 - @2.txt
        /// 第三次覆盖取名123 - @3.txt
        /// <returns>DataSet</returns>
        /// <returns>自定义的一些参数</returns>
        /// </summary>
        public static void fileMove(FileInfo var, ref string DestPath)
        {
            //string newpath = Path.Combine(DestPath, var.Name);
            //string s = string.Format("打开文件{0}并移动到目录{1},/n"+newpath, var.Name,DestPath);

            //     MessageBox.Show(s); //debug

            if (!File.Exists(DestPath))
            {
                var.MoveTo(DestPath);
            }
            else
            {
                string filenameH = Path.GetFileNameWithoutExtension(DestPath);//取不含后缀的文件名
                if (filenameH.Contains("@"))//判断是否是已经被覆盖重命名过的文件
                {
                    int i = filenameH.LastIndexOf("@");
                    //获取重名文件编号，即重命名的次数
                    int fileNb = int.Parse(filenameH.Substring(filenameH.LastIndexOf("@") + 1)) + 1;
                    //设置新文件名
                    string newname = filenameH.Substring(0, filenameH.LastIndexOf("@") + 1) + fileNb.ToString() + Path.GetExtension(DestPath);
                    DestPath = Path.Combine(Path.GetDirectoryName(DestPath), newname);
                    fileMove(var, ref DestPath);
                }
                else
                {
                    //首次改名后递归；
                    string newname = filenameH + " - @1" + Path.GetExtension(DestPath);
                    DestPath = Path.Combine(Path.GetDirectoryName(DestPath), newname);
                    fileMove(var, ref DestPath);
                }
            }
        }


    }
}
