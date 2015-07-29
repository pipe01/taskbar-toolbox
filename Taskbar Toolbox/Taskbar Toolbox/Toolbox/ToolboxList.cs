using System.Collections.Generic;
using System.IO;

namespace Taskbar_Toolbox
{
    class ToolboxList : List<Toolbox>
    {
        public static ToolboxList create()
        {
            ToolboxList list = new ToolboxList();
            foreach (string folder in Directory.EnumerateDirectories(Util.getToolboxesPath()))
            {
                try
                {
                    Toolbox tlb = Toolbox.xml2toolbox(folder + "/toolbox.xml");
                    string nombre = Path.GetFileName(Path.GetFullPath(folder));
                    if (nombre == tlb.name)
                    {
                        tlb.icon = System.Drawing.Image.FromFile(Util.getToolboxesPath() + tlb.name + "/icon.png");
                        list.Add(tlb);
                    }
                } catch { continue; }
            }
            return list;
        }

        public Toolbox getFromName(string name)
        {
            foreach (Toolbox item in this)
            {
                if (item.name == name) { return item; }
            }
            return null;
        }
    }
}
