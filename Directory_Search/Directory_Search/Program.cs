using System;
using System.IO;

namespace Directory_Search
{
    class Program
    {
        static void Main(string[] args)
        {

            string path; string output; bool subDirect;
            // Display title 
            Console.WriteLine("Directory Search in C#");
            Console.WriteLine("------------------------\n");

            // Ask the user to type in directory to search.
            Console.WriteLine("Please type the directory to search");
            path = Convert.ToString(Console.ReadLine());



            // Ask the user to type in directory to search.
            Console.WriteLine("Please type where you would like the output csv");
            output = Convert.ToString(Console.ReadLine());


            // Ask if you want to search subdirectories.
            Console.WriteLine("Do you want to search subdirectories? True/False");
            subDirect = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(path);
            Console.WriteLine(output);
            Console.WriteLine(subDirect);

            
        }
    }
    public static void Main(string[] args)
    {
        foreach (string path in args)
        {
            if (File.Exists(path))
            {
                // This path is a file
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }
        }
    }
}

