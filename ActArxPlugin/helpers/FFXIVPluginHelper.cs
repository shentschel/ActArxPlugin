using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Advanced_Combat_Tracker;

namespace ActArxPlugin.helpers
{
    class FFXIVPluginHelper
    {
        private static ActPluginData _plugin;
        private static string FFXIV_PLUGIN_NAME = "FFXIV_ACT_Plugin.dll";
        private static string FFXIV_PLUGIN_LABEL = "FFXIV Plugin Started.";

        public static object Instance
        {
            get 
            {
                if (_plugin == null && ActGlobals.oFormActMain.Visible)
                {
                    foreach (ActPluginData pluginData in ActGlobals.oFormActMain.ActPlugins)
                    {
                        if (pluginData.pluginFile.Name == FFXIV_PLUGIN_NAME &&
                            pluginData.lblPluginStatus.Text == FFXIV_PLUGIN_LABEL)
                        {
                            _plugin = pluginData;
                            break;
                        }
                    }
                }
                return _plugin;
            }
        }

        public static Process GetFFXIVProcess
        {
            get
            {
                try
                {
                    FieldInfo fi = _plugin
                        .pluginObj
                        .GetType()
                        .GetField("_Memory", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);

                    var memory = fi.GetValue(_plugin.pluginObj);
                    if (memory == null)
                    {
                        return null;
                    }

                    fi = memory
                        .GetType()
                        .GetField("_config", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);

                    var config = fi.GetValue(memory);
                    if (config == null)
                    {
                        return null;
                    }

                    fi = config
                        .GetType()
                        .GetField("Process", BindingFlags.GetField | BindingFlags.Public | BindingFlags.Instance);

                    var proc = fi.GetValue(config);
                    if (proc == null)
                    {
                        return null;
                    }

                    return (Process) proc;
                }
                catch
                {
                    return null;
                }

            }
        }
    }
}
