using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActArxPlugin.helpers
{
    public static class FFXIVProcessHelper
    {
        private static string FFXIV = "ffxiv";
        private static string FFXIV_DX11 = "ffxiv_dx11";

        private static bool checkProcess(Process proc, string name)
        {
            return !proc.HasExited && proc.MainModule != null && proc.MainModule.ModuleName == name;
        }

        public static IList<Process> GetFFXIVProcesses()
            => (
                    from proc in Process.GetProcessesByName(FFXIV)
                    where checkProcess(proc, FFXIV + ".exe")
                    select proc
               ).Union(
                    from proc in Process.GetProcessesByName(FFXIV_DX11)
                    where checkProcess(proc, FFXIV + ".exe")
                    select proc
               ).ToList<Process>();


        public static Process GetFFXIVProcess(int pid)
        {
            Process result = null;
            IList<Process> list = GetFFXIVProcesses();
            if (pid == 0)
            {
                if (list.Any<Process>())
                {
                    result = (from proc in list orderby proc.Id select proc)
                        .FirstOrDefault<Process>();
                }
            }
            else
            {
                result = list.FirstOrDefault((Process proc) => proc.Id == pid);
            }

            return result;
        }
    }
}
