using System;
using System.Windows.Forms;

namespace Toolbox_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Util.steam.downloadSteamAppList(false);

            try
            {
                initToolbox(args);
            }
            catch (Exception)
            {
                return;
            }

            if (Util.tlb == null) { return; }

            Application.Run(new frmEditarToolbox());
        }

        static void initToolbox(string[] args)
        {
            string ret = "";
            if (args.Length == 0)
            {
                ret = preguntarToolbox();
                if (ret == null) { return; }
            }
            else
            {
                ret = args[0];
            }
            Util.tlb = Toolbox.xml2toolbox(Util.getToolboxesPath() + ret + "/toolbox.xml");
            if (Util.tlb == null) { initToolbox(new string[] {}); }
        }

        static string preguntarToolbox()
        {
            string tmp = "";
            Util.InputBox("Toolbox no encontrada", "Introduzca el nombre de la Toolbox", ref tmp);
            if (tmp != null)
            {
                return tmp;
            }
            return null;
        }
    }
}
