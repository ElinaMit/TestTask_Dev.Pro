namespace TestTask_Dev.Pro.Task_1;

public class Logger
{
    public void LogMessage(string filePath, string message, string level)
    {
        string timestamp = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]");
        string logEntry = $"{timestamp} [{level}] {message}\n";

        File.AppendAllText(filePath, logEntry);
    }
}