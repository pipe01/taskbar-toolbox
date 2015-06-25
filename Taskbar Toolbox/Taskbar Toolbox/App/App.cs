using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Taskbar_Toolbox
{
    public class App
    {
        public string name;
        public string id;
        public string path;

        public App() { }
        public App(string name, string id, string path)
        {
            this.name = name;
            this.id = id;
            this.path = path;
        }
    }
}
