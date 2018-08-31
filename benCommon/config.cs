using System;
using System.Configuration;
using System.Xml;
using System.Data;

namespace benCommon
{
    /// 
    /// 应用如下：
//读取：
//ConfigClass config = new ConfigClass();
//string coal = config.ReadConfig("coal");
//this.tbOpenFile.Text = config.ReadConfig("inWellTime");

//写：
//ConfigClass config = new ConfigClass();
////得到程序的config名：DataOperate.exe.config；
//config.SetConfigName("DataOperate.exe.config");
//config.SaveConfig("coal","三二一"); 
//config.SaveConfig("inWellTime","10");
    /// 
    public class ConfigClass
    {
        public string strFileName;
        public string configName;
        public string configValue;
        public ConfigClass()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private void AccessAppSettings()
        {
            //获取Configuration对象
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //根据Key读取<add>元素的Value
            string name = config.AppSettings.Settings["name"].Value;
            //写入<add>元素的Value
            config.AppSettings.Settings["name"].Value = "fx163";
            //增加<add>元素
            config.AppSettings.Settings.Add("url", "http://www.fx163.net");
            //删除<add>元素
            config.AppSettings.Settings.Remove("name");
            //一定要记得保存，写不带参数的config.Save()也可以
            config.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        public string ReadConfig(string configKey)
        {
            configValue = "";
            configValue = ConfigurationManager.AppSettings["" + configKey + ""];
            return configValue;
        }

        //得到程序的config文件的名称以及其所在的全路径
        public void SetConfigName(string strConfigName)
        {
            configName = strConfigName;
            //获得配置文件的全路径
            GetFullPath();
        }

        public void GetFullPath()
        {
            //获得配置文件的全路径
            strFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + configName;
        }

        public void SaveConfig(string configKey, string configValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(strFileName);
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //获得将当前元素的key属性
                XmlAttribute att =nodes[i].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value != null && att.Value == ""+configKey+"")
                {
                    //对目标元素中的第二个属性赋值
                    att = nodes[i].Attributes["value"];
                    att.Value = configValue;
                    break;
                }
            }
            //保存上面的修改
            doc.Save(strFileName);
        }
    }
}


