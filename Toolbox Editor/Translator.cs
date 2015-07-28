using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace Toolbox_Editor
{
    class Translator
    {
        private Dictionary<string, string> langEntries = new Dictionary<string, string>();
        private ResourceManager rm;

        private bool initiated;

        public Translator()
        {
            initiated = true;
            rm = new ResourceManager(this.GetType().Namespace + ".strings", Assembly.GetExecutingAssembly());
        }

        public void translateForm(Form form)
        {
            if (!initiated) { return; }
            foreach (Control item in getControls(form))
            {
                if (item.Tag == null) { continue; }
                if (item.Tag.ToString().StartsWith("@"))
                {
                    string unloc = item.Tag.ToString().Substring(1, item.Tag.ToString().Length - 1);
                    item.Text = unloc;
                    string text;
                    try
                    {
                        text = rm.GetString(unloc);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    item.Text = text;
                }
            }
        }

        public List<Control> getControls(Control where)
        {
            List<Control> controles = new List<Control>();
            foreach (Control c in where.Controls)
            {
                controles.Add(c);
                if (c.Controls.Count > 0)
                {
                    controles.AddRange(getControls(c));
                }
            }
            return controles;
        }
    }
}
