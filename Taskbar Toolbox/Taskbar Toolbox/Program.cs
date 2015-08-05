using System;
using System.Windows.Forms;
using Toolbox_API;

namespace Taskbar_Toolbox
{
    static class Program
    {
        public static ToolboxForm form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
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
