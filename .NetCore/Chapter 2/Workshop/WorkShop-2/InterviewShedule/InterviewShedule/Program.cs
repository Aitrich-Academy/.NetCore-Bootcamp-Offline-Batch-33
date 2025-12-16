using System;

namespace InterviewSchedule
{
    internal class Program
    {
        struct Interview
        {
            public string Title;
            public DateTime Date;
            public string Time;
            public string Location;
        }

        static void Main(string[] args)
        {
            Interview[] schedule = new Interview[10];
            int count = 0;

            string choice;

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("------------------ Interview Schedule System ------------------");
            Console.WriteLine("---------------------------------------------------------------\n");

            do
            {
                Console.WriteLine("A - Schedule an Interview");
                Console.WriteLine("D - Display All Scheduled Interviews");
                Console.WriteLine("Enter your option:");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "A":
                    case "a":
                        {
                            Console.WriteLine("How many interviews do you want to schedule?");
                            int n = int.Parse(Console.ReadLine());

                            for (int i = 0; i < n; i++)
                            {
                                if (count >= schedule.Length)
                                {
                                    Console.WriteLine("No more slots available!");
                                    break;
                                }

                                Console.WriteLine($"\n--- Interview {count + 1} ---");

                                Console.Write("Enter Job Title: ");
                                schedule[count].Title = Console.ReadLine();

                                Console.Write("Enter Interview Date (dd-mm-yyyy): ");
                                schedule[count].Date = DateTime.Parse(Console.ReadLine());

                                Console.Write("Enter Interview Time (hh:mm): ");
                                schedule[count].Time = Console.ReadLine();

                                Console.Write("Enter Location: ");
                                schedule[count].Location = Console.ReadLine();

                                count++;
                                Console.WriteLine("-----------------------------------------------\n");
                            }
                            break;
                        }

                    case "D":
                    case "d":
                        {
                            Console.WriteLine("\n----------- Scheduled Interviews ------------\n");

                            if (count == 0)
                            {
                                Console.WriteLine("No interviews scheduled yet.\n");
                                break;
                            }

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine("Job Title : " + schedule[i].Title);
                                Console.WriteLine("Date      : " + schedule[i].Date.ToString("dd/MM/yyyy"));
                                Console.WriteLine("Time      : " + schedule[i].Time);
                                Console.WriteLine("Location  : " + schedule[i].Location);
                                Console.WriteLine("---------------------------------------------\n");
                            }

                            break;
                        }

                    default:
                        Console.WriteLine("Invalid option. Please select A or D.\n");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N): ");
                choice = Console.ReadLine();

            } while (choice == "Y" || choice == "y");

            Console.WriteLine("\nThank you for using the Interview Scheduler!");
        }
    }
}
