class Program
{
    private static void printItems(Queue<string> items)
    {
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n");
    }

    static void Main()
    {
        Queue<string> jobs = new Queue<string>();
        int finishedJob = 0;
        int code;

        Console.WriteLine("Welcome to my JOB SCHEDULING");

        do
        {
            Console.WriteLine("\nChoose what you want to do?");
            Console.WriteLine("1 - NEW JOB");
            Console.WriteLine("2 - FINISH JOB");
            Console.WriteLine("3 - SEARCH JOB");
            Console.WriteLine("4 - CURRENT JOB");
            Console.WriteLine("5 - DISPLAY ALL JOBS");
            Console.WriteLine("6 - COUNT JOBS");
            Console.WriteLine("7 - EXIT");

            Console.Write("Enter code: ");
            code = Convert.ToInt32(Console.ReadLine());

            switch (code)
            {
                case 1:
                    Console.Write("\nEnter new job: ");
                    string newJob = Console.ReadLine();

                    jobs.Enqueue(newJob);
                    Console.WriteLine("New job has been added!");
                    break;

                case 2:
                    if (jobs.Count > 0)
                    {
                        jobs.Dequeue();
                        finishedJob++;

                        Console.WriteLine("\nThe current job has been marked FINISH.");
                        Console.WriteLine($"Total number of finished job: {finishedJob}");
                    }
                    else
                    {
                        Console.WriteLine("\nNo JOB on the list.");
                    }
                    break;

                case 3:
                    Console.Write("\nEnter job to search: ");
                    string searchJob = Console.ReadLine();

                    if (jobs.Contains(searchJob))
                        Console.WriteLine("The job is found!");
                    else
                        Console.WriteLine("The job not found!");
                    break;

                case 4:
                    if (jobs.Count > 0)
                        Console.WriteLine($"\nCurrent Job: {jobs.Peek()}");
                    else
                        Console.WriteLine("\nNo JOB on the list.");
                    break;

                case 5:
                    if (jobs.Count > 0)
                    {
                        Console.WriteLine("\nList of Jobs:");
                        printItems(jobs);
                    }
                    else
                    {
                        Console.WriteLine("\nNo JOB on the list.");
                    }
                    break;

                case 6:
                    Console.WriteLine($"\nNumber of jobs on the schedule: {jobs.Count}");
                    break;

                case 7:
                    Console.WriteLine("\nThank you for using the program");
                    break;

                default:
                    Console.WriteLine("\nInvalid code!");
                    break;
            }

        } while (code != 7);
    }
}