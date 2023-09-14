
namespace gravitate_test_automation
{
	public class logIt
	{
        public static void LogIt(string message)
        {
            string logPath = AppDomain.CurrentDomain.BaseDirectory + "Logs";
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            string logFile = logPath + @"/selenium-run-log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            using (StreamWriter sw = File.AppendText(logFile))
            {
                sw.WriteLine(DateTime.Now + " - " + message);
            }
        }
    }
}

