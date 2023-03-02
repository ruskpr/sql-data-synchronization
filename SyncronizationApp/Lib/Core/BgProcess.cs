using System.Diagnostics;

namespace Lib.Core
{
    public static class BgProcess
    {
        #region const

        private const string DEFAULT_PROCESS_NAME = "SQL Sync Service";
        private const string DEFAULT_EXECUTABLE_PATH = "bgservice\\SQL Sync Service.exe";

        #endregion

        #region public static

        public static void StartProcess(string executablePath = DEFAULT_EXECUTABLE_PATH)
        {
            Process.Start(executablePath);
        }

        public static void StartProcessWithMaxOneInstance(
            string executablePath = DEFAULT_EXECUTABLE_PATH,
            string processName = DEFAULT_PROCESS_NAME)
        {
            if (Process.GetProcessesByName(processName).Length > 0)
                return;
            else
                Process.Start(executablePath);
        }

        public static void KillAllInstances(string processName = DEFAULT_PROCESS_NAME)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }

        public static bool IsRunning(string processName = DEFAULT_PROCESS_NAME)
        {
            var processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
                return true;
            else 
                return false;
        }
        #endregion

    }
}
