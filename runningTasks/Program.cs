using System;
using System.Diagnostics;
namespace runningTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] Memory = Process.GetProcesses();

            foreach (Process prc in Memory)
            {
                Console.WriteLine("İşlem: {0}", prc.ProcessName);
            }
        }
    }
}
