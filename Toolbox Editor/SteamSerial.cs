using Microsoft.Win32;
using PortableSteam;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Toolbox_Editor
{
    class SteamSerial
    {
        public SteamSerial()
        {
            SteamWebAPI.SetGlobalKey("0B7965E2A44CE9CA6D12923228DDCECC");
        }

        public string getAppName(int appId)
        {
            List<PortableSteam.Interfaces.General.ISteamApps.App> appList = getAppList();
            //await downloadSteamAppListAsync(false);
            foreach (var app in appList)
            {
                if (app.AppID == appId)
                {
                    return app.Name;
                }
            }
            return null;
        }

        public List<PortableSteam.Interfaces.General.ISteamApps.App> getAppList()
        {
            List<PortableSteam.Interfaces.General.ISteamApps.App> appList = new List<PortableSteam.Interfaces.General.ISteamApps.App>();
            string[] lines = File.ReadAllLines("./steamapps.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 1) { continue; }
                PortableSteam.Interfaces.General.ISteamApps.App tmp = new PortableSteam.Interfaces.General.ISteamApps.App();
                tmp.AppID = int.Parse(parts[0]);
                tmp.Name = parts[1];
                appList.Add(tmp);
            }
            return appList;
        }

        public async Task downloadSteamAppListAsync(bool force)
        {
            if (!File.Exists("./steamapps.txt") || force)
            {
                var ret = await SteamWebAPI.General().ISteamApps().GetAppList().GetResponseAsync();
                StreamWriter stream = File.CreateText("./steamapps.txt");
                foreach (var app in ret.Data.Apps)
                {
                    stream.WriteLine(app.AppID + "=" + app.Name);
                }
            }
        }

        public void downloadSteamAppList(bool force)
        {
            if (!File.Exists("./steamapps.txt") || force)
            {
                var ret = SteamWebAPI.General().ISteamApps().GetAppList().GetResponse();
                StreamWriter stream = File.CreateText("./steamapps.txt");
                foreach (var app in ret.Data.Apps)
                {
                    stream.WriteLine(app.AppID + "=" + app.Name);
                }
            }
        }

        public string getSteamAppsDir()
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");
            string installpath = null;

            if (regKey != null)
            {
                installpath = regKey.GetValue("SourceModInstallPath").ToString();
                installpath = installpath.Replace("sourcemods", null);
                installpath += "common\\";
            }
            return installpath;
        }

        public string getAppExecutable(string appName)
        {
            try
            {
                string path = getSteamAppsDir() + appName;
                foreach (string item in Directory.EnumerateFiles(path, "*.exe",
                                        SearchOption.TopDirectoryOnly))
                {
                    return item;
                }
            }
            catch (System.Exception)
            {
                return null;
            }
            return null;
        }
    }
}
