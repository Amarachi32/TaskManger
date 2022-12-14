

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //List all running tasks
            Process[] processes = Process.GetProcesses();
          WriteLine("List of all running tasks: ");
            foreach (Process process in processes)
            {
                WriteLine(process.ProcessName);
            }
            WriteLine();

            
            //Kill any task
            WriteLine("Enter the name of the process to kill: ");

            try
            {
                string processName = ReadLine();
                foreach (Process process in processes)
                {
                    if (process.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase))
                    {
                        process.Kill(true);
                        break;
                    }
                }
                WriteLine($"Process {processName} killed successfully!");
                WriteLine();
            }
            catch (Exception ex)
            {

                WriteLine(ex.Message);
            }

            //start


            //Start a new process
            WriteLine("Enter the name of the process to start: ");
            try
            {
                string processNameToStart = ReadLine();
                Process.Start(processNameToStart);
                WriteLine($"Process {processNameToStart} started successfully!");
            }
            catch (Exception ex)
            {

                WriteLine(ex.Message);
            }
            WriteLine();
           


            //Create a custom process
            Process customProcess = new Process();
            WriteLine("Enter the name of the custom process to start: ");
            try
            {
                customProcess.StartInfo.FileName = ReadLine();
                WriteLine("Enter the command line arguments of the custom process to start: ");
                customProcess.StartInfo.Arguments = ReadLine();
                customProcess.Start();
                WriteLine($"Custom process {customProcess.StartInfo.FileName} started successfully!");
            }
            catch (Exception ex)
            {

                WriteLine(ex.Message);
            }
            WriteLine();

            //Create a thread
            Thread thread = new Thread(Secondary);
            thread.Start();
            WriteLine($" {thread.ManagedThreadId} Thread started successfully!");
            WriteLine();

            //Create a background thread
            Thread backgroundThread = new Thread(Secondary);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
            WriteLine($"Background thread {backgroundThread.Name} started successfully!");
            WriteLine();

            // check if threads are alive
            WriteLine($"Thread {thread.Name} is {(thread.IsAlive ? "alive" : "not alive")}");
            WriteLine($"Background thread {backgroundThread.Name} is {(backgroundThread.IsAlive ? "alive" : "not alive")}");
            ReadKey();
        }

        private static void Secondary(object threadName)
        {
            WriteLine("Secondary thread started!, {0}", threadName);
            //Do some work here
            WriteLine("secondary thread finished!");
        }
     
        

/*        public static int Start(string processName)
        {
            var process =
                Process.Start(processName);
            return
                process.Id;
        }*/
    }
}
