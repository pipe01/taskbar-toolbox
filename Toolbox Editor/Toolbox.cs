using System.Collections.Generic;
using System.Xml;
using System.Drawing;
using System.IO;

namespace Toolbox_Editor
{
    class Toolbox
    {
        public string name, oldName;
        public Dictionary<string, App> appList = new Dictionary<string, App>();
        public Color bgColor;
        public Image icon;
        public Point position;

        public void setName(string newName)
        {
            if (name == null)
            {
                oldName = newName;
                name = newName;
            }
            else
            {
                if (this.name != newName)
                {
                    Directory.Move(Util.getToolboxesPath() + this.name, Util.getToolboxesPath() + newName);
                }
                oldName = name;
                name = newName;
            }
        }

        public void save()
        {
            if (!Directory.Exists(Util.getToolboxesPath() + this.name))
            {
                Directory.CreateDirectory(Util.getToolboxesPath() + this.name);
            }

            if (this.icon != null) { this.icon.Save(Util.getToolboxesPath() + this.name + "/icon.png"); }
            toolbox2xml(this, Util.getToolboxesPath() + this.name + "/toolbox.xml");
        }

        public static void toolbox2xml(Toolbox toolbox, string xmlPath)
        {
            using (XmlWriter writer = XmlWriter.Create(xmlPath))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Toolbox"); // Toolbox
                writer.WriteStartElement("ToolboxAttributes"); // ToolboxAttributes
                writer.WriteElementString("Name", toolbox.name);
                writer.WriteElementString("BGColor", ColorTranslator.ToWin32(toolbox.bgColor).ToString());
                writer.WriteElementString("Position", toolbox.position.X + "x" + toolbox.position.Y);
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
                writer.Close();
            }
        }

        public static Toolbox xml2toolbox(string xmlPath)
        {
            bool inToolboxAttributes = false;
            bool inApp = false;
            App currentApp = new App();
            Toolbox toolbox = new Toolbox();
            if (!File.Exists(xmlPath))
            {
                return null;
            }
            using (XmlReader reader = XmlReader.Create(xmlPath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
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
                                if (inToolboxAttributes)
                                {
                                    reader.Read();
                                    toolbox.setName(reader.Value);
                                }
                                else if (inApp)
                                {
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
                                break;
                            case "Position":
                                reader.Read();
                                string[] parts = reader.Value.Split('x');
                                toolbox.position.X = int.Parse(parts[0]);
                                toolbox.position.Y = int.Parse(parts[1]);
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
