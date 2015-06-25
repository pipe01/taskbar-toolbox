using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;

namespace Taskbar_Toolbox
{
    public class Toolbox
    {
        public string name;
        public Dictionary<string, App> appList = new Dictionary<string,App>();
        public System.Drawing.Color bgColor;
        public System.Drawing.Image icon;

        public static void toolbox2xml(Toolbox toolbox, string xmlPath)
        {
            using (XmlWriter writer = XmlWriter.Create(xmlPath))
            {
                writer.WriteStartDocument();
                    writer.WriteStartElement("Toolbox"); // Toolbox
                        writer.WriteStartElement("ToolboxAttributes"); // ToolboxAttributes
                            writer.WriteElementString("Name", toolbox.name);
                            writer.WriteElementString("BGColor", ColorTranslator.ToWin32(toolbox.bgColor).ToString());
                        writer.WriteEndElement(); // -ToolboxAttributes
                        writer.WriteStartElement("Apps");
                            foreach (App item in toolbox.appList.Values)
                            {
                                writer.WriteStartElement("App");
                                writer.WriteElementString("ID", item.id);
                                writer.WriteElementString("Name", item.name);
                                writer.WriteElementString("ExePath", item.path);
                                writer.WriteEndElement();
                            }
                        writer.WriteEndElement();
                    writer.WriteEndElement(); // -Toolbox
                writer.WriteEndDocument();
            }
        }

        public static Toolbox xml2toolbox(string xmlPath)
        {
            bool inToolboxAttributes = false;
            bool inApp = false;
            App currentApp = new App();
            Toolbox toolbox = new Toolbox();
            using (XmlReader reader = XmlReader.Create(xmlPath))
            {
                while(reader.Read())
                {
                    if(reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "ToolboxAttributes":
                                inToolboxAttributes = true;
                                break;
                            case "App":
                                inApp = true;
                                break;
                            case "ID":
                                reader.Read();
                                currentApp.id = reader.Value;
                                break;
                            case "Name":
                                if (inToolboxAttributes) {
                                    reader.Read();
                                    toolbox.name = reader.Value;
                                } else if (inApp) {
                                    reader.Read();
                                    currentApp.name = reader.Value;
                                }
                                break;
                            case "ExePath":
                                reader.Read();
                                currentApp.path = reader.Value;
                                toolbox.appList.Add(currentApp.id, currentApp);
                                currentApp = new App();
                                inApp = false;
                                break;
                            case "BGColor":
                                reader.Read();
                                toolbox.bgColor = ColorTranslator.FromWin32(int.Parse(reader.Value));
                                inToolboxAttributes = false;
                                break;
                        }
                    }
                }
                reader.Close();
            }
            return toolbox;
        }
    }
}
