/*using System.Diagnostics;

namespace TaskManger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ListAllRunningProcesses();
        }

        static void ListAllRunningProcesses()
        {
            // Get all the processes on the local machine, ordered by
            // PID.

            var runningProcs = from proc
                               in Process.GetProcesses(".")
                               orderby proc.Id
                               select proc;
            // Print out PID and name of each process.
            foreach (var p in runningProcs)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("************************************\n");
        }
    }

    class TaskManger
    {
        //list all running task
        //kill all the task or any of them
        //start a task
        //create custom process and kill it //name the process and spin it up
        //create custom thread and kill it
        //create background thread
        //check if they are alive



    }


}
*/