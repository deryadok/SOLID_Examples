using System;
using System.Collections.Generic;
using System.Text;

namespace _05_DependencyInversion.OrderManagement
{
    internal class FileLogger
    {
        public void Log(string message)
        {
            // Simulate logging to a file
            StreamWriter writer = new StreamWriter("log.txt");
            writer.WriteLine(message);
            writer.Flush();
            writer.Close();
        }
    }
}
