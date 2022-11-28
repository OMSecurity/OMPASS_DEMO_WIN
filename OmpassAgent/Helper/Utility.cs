using OmpassAgentDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OmpassAgent.Helper
{
    class Utility
    {
        private static object lockObject = new object();

        public static void Log(string location, string message)
        {
            lock (lockObject)
            {
                var diLog = new DirectoryInfo(Environment.CurrentDirectory + "\\Log");
                if (!diLog.Exists) diLog.Create();

                var date = DateTime.Now.ToString("yyyyMMdd_HH_mm");
                var path = diLog + $"\\Log_{date}.txt";

                using (var outfile = new StreamWriter(path, true, Encoding.Default))
                {
                    outfile.Write("\n[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] " + location + " : " + message);
                }

                Console.WriteLine(message);
            }
        }
    }
}
