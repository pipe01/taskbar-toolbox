using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskbar_Toolbox
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

            ToolboxForm form;

            if (args.Length == 1)
            {
                try
                {
                    ToolboxList tlbList = ToolboxList.create();
                    Toolbox tlb = tlbList.getFromName(args[0]);
                    form = new ToolboxForm();
                    form.setToolbox(tlb);
                    Application.Run(form);
                } catch (Exception) {
                    //Application.Exit();
                }
            } else {
                return;
            }
        }
    }
}
