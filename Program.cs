using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace UIAutomationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceRepo ="";
            string sourceBranch ="";
            string testRepo ="";
            string testBranch ="";
            string testSampleName = "";
            string testScriptName = "";

            try
            {
                if (args.Length > 0)
                {
                    sourceRepo = args[0];
                    sourceBranch = args[1];
                    testRepo = args[2];
                    testBranch = args[3];
                    testSampleName = args[4];
                    testScriptName = args[5];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The catched exception is " + e.ToString());
            }

        }
    }
}
