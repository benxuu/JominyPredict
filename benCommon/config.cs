using System;
using System.Configuration;
using System.Xml;
using System.Data;

namespace benCommon
{
    /// 
    /// Ӧ�����£�
//��ȡ��
//ConfigClass config = new ConfigClass();
//string coal = config.ReadConfig("coal");
//this.tbOpenFile.Text = config.ReadConfig("inWellTime");

//д��
//ConfigClass config = new ConfigClass();
////�õ������config����DataOperate.exe.config��
//config.SetConfigName("DataOperate.exe.config");
//config.SaveConfig("coal","����һ"); 
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
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        private void AccessAppSettings()
        {
            //��ȡConfiguration����
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //����Key��ȡ<add>Ԫ�ص�Value
            string name = config.AppSettings.Settings["name"].Value;
            //д��<add>Ԫ�ص�Value
            config.AppSettings.Settings["name"].Value = "fx163";
            //����<add>Ԫ��
            config.AppSettings.Settings.Add("url", "http://www.fx163.net");
            //ɾ��<add>Ԫ��
            config.AppSettings.Settings.Remove("name");
            //һ��Ҫ�ǵñ��棬д����������config.Save()Ҳ����
            config.Save(ConfigurationSaveMode.Modified);
            //ˢ�£���������ȡ�Ļ���֮ǰ��ֵ��������װ���ڴ棩
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        public string ReadConfig(string configKey)
        {
            configValue = "";
            configValue = ConfigurationManager.AppSettings["" + configKey + ""];
            return configValue;
        }

        //�õ������config�ļ��������Լ������ڵ�ȫ·��
        public void SetConfigName(string strConfigName)
        {
            configName = strConfigName;
            //��������ļ���ȫ·��
            GetFullPath();
        }

        public void GetFullPath()
        {
            //��������ļ���ȫ·��
            strFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + configName;
        }

        public void SaveConfig(string configKey, string configValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(strFileName);
            //�ҳ�����Ϊ��add��������Ԫ��
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //��ý���ǰԪ�ص�key����
                XmlAttribute att =nodes[i].Attributes["key"];
                //����Ԫ�صĵ�һ���������жϵ�ǰ��Ԫ���ǲ���Ŀ��Ԫ��
                if (att.Value != null && att.Value == ""+configKey+"")
                {
                    //��Ŀ��Ԫ���еĵڶ������Ը�ֵ
                    att = nodes[i].Attributes["value"];
                    att.Value = configValue;
                    break;
                }
            }
            //����������޸�
            doc.Save(strFileName);
        }
    }
}


