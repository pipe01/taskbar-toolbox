using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Taskbar_Toolbox
{
    class ToolboxList : List<Toolbox>
    {
        public static ToolboxList create()
        {
            ToolboxList list = new ToolboxList();
            foreach (string folder in Directory.EnumerateDirectories("./toolboxes"))
            {
                try
                {
                    Toolbox tlb = Toolbox.xml2toolbox(folder + "/toolbox.xml");
                    tlb.icon = System.Drawing.Image.FromFile("./toolboxes/" + tlb.name + "/icon.png");
                    list.Add(tlb);
                } catch { break; }
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
