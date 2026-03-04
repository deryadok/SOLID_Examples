namespace _05_DependencyInversion.OrderManagement.Refactored
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            StreamWriter writer = new StreamWriter("log.txt");
            writer.WriteLine(message);
            writer.Flush();
            writer.Close();
        }
    }
}
