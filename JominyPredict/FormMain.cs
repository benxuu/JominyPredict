using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
using System.Reflection;
using System.Diagnostics;
namespace JominyPredict
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        //the show Statusmessage function for delegate
        public void statusMsg(string s) { toolStripStatusLabel1.Text = s; }
        //the show  messagebox function for delegate
        public void showMbox(string s) { MessageBox.Show(s); }
        public void progressBarChange(int progressBarValue)
        {
            //if (progressBarValue < 101)
            //{
            //    this.toolStripProgressBar1.Value = progressBarValue;
            //}
            //else
            //{
            //    this.toolStripProgressBar1.Value = 0;
            //}
        }
        /// <summary> 
        /// Search mdi child form by specific type string 
        /// </summary> 
        /// <param name= "ChildTypeString "> </param> 
        /// <returns> </returns> 
        private bool ContainMDIChild(string ChildTypeString)
        {

            Form myMDIChild = null;
            foreach (Form f in this.MdiChildren)
            {

                if (f.GetType().ToString() == ChildTypeString)
                {
                    // found it 
                    myMDIChild = f;
                    break;
                }
            }

            // Show the exist form 

            if (myMDIChild != null)
            {
                myMDIChild.TopMost = true;
                myMDIChild.Show();
                myMDIChild.Focus();
                return true;
            }
            else
                return false;

        }
        /// <summary> 
        /// Open child window 
        /// </summary> 
        /// <param name= "ChildTypeString "> </param> 

        private void OpenWindow(string ChildTypeString)
        {

            Form myChild = null;

            if (!ContainMDIChild(ChildTypeString))
            {
                // Get current process assembly 
                Assembly assembly = Assembly.GetExecutingAssembly();

                // Create data type using type string 
                Type typForm = assembly.GetType(ChildTypeString);

                // Create object using type 's "InvokeMember " method 
                Object obj = typForm.InvokeMember(

                null,
                BindingFlags.DeclaredOnly |
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.CreateInstance,
                null,
                null,
                null);

                // Show child form 
                if (obj != null)
                {
                    myChild = obj as Form;
                    myChild.MdiParent = this;
                    myChild.Show();
                    myChild.WindowState = FormWindowState.Maximized;//最大化
                    myChild.Focus();

                }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //string s1="计时器：--委托";
            //t1.Start();
            //注册委托
            baseClass.dstatusMsg = statusMsg;
            baseClass.dprogressbar = progressBarChange;
            //baseClass.loadyuce = loadYC;
            //loadYC();

            //预加载预测页
            FormYuce yuce1 = new FormYuce(); 
            yuce1.MdiParent = this;

            //自动打开首页
            OpenWindow(typeof(FormIndex).ToString());


            //功能测试菜单的启用            
            if (System.Configuration.ConfigurationManager.AppSettings["isDebug"] == "true")
            {
                //toolStripButton2.Visible = true;
            }
            else
            {
                //toolStripButton2.Visible = false;
            }
            //close the starting page
            baseClass.closestart();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            OpenWindow(typeof(FormYuce).ToString());
        }
    }
}
