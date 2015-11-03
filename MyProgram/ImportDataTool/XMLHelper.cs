using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ImportDataTool
{
    public class XMLHelper
    {
        public static List<DBNameModel> getDBxml(string xmlName)
        {

            string xmlFile = Application.StartupPath + @"\XML\" + xmlName;

            if (!System.IO.File.Exists(xmlFile))
            {
                return null;
            }

            List<DBNameModel> dbList = new List<DBNameModel>();
            XmlDocument xml = new XmlDocument();//声明xml
            xml.Load(xmlFile);//按路径读xml文件
            XmlElement rootElem = xml.DocumentElement;//获取根节点
            XmlNodeList personNodes = rootElem.GetElementsByTagName("item");
            foreach (XmlNode node in personNodes)
            {
                DBNameModel db = new DBNameModel();
                XmlNodeList itemNodes0 = ((XmlElement)node).GetElementsByTagName("DBId");
                XmlNodeList itemNodes1 = ((XmlElement)node).GetElementsByTagName("DBType");
                XmlNodeList itemNodes2 = ((XmlElement)node).GetElementsByTagName("DBName");
                XmlNodeList itemNodes3 = ((XmlElement)node).GetElementsByTagName("DBUrl");
                XmlNodeList itemNodes4 = ((XmlElement)node).GetElementsByTagName("DBShowName");
                db.DBId = itemNodes0[0].InnerText;
                db.DBType = itemNodes1[0].InnerText;
                db.DBName = itemNodes2[0].InnerText;
                db.DBUrl = itemNodes3[0].InnerText;
                db.DBShowName = itemNodes4[0].InnerText;
                dbList.Add(db);
            }

            return dbList;
        }
    }
}
