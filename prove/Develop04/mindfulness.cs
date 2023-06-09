using System;
using System.Threading;

class ActivityProgram
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity();
                    break;
                case "2":
                    ReflectionActivity();
                    break;
                case "3":
                    ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"--- {activityName} ---");
        Console.WriteLine(description);
        Console.Write("Enter the duration of the activity (in seconds): ");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting the activity
    }

    static void EndActivity(string activityName, int duration)
    {
        Console.WriteLine("Good job!");
        Thread.Sleep(2000); // Pause for 2 seconds before displaying the activity summary
        Console.WriteLine($"You have completed the {activityName} for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds before finishing the activity
    }

    static void BreathingActivity()
    {
        StartActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Starting breathing activity...");
        Thread.Sleep(2000); // Pause for 2 seconds before starting the breathing cycle

        Console.WriteLine("Breathe in...");
        Thread.Sleep(2000); // Pause for 2 seconds before displaying the countdown
        Countdown(3); // Countdown from 3 seconds

        Console.WriteLine("Breathe out...");
        Thread.Sleep(2000); // Pause for 2 seconds before displaying the countdown
        Countdown(3); // Countdown from 3 seconds

        EndActivity("Breathing Activity", 6); // Assuming each breath cycle takes 6 seconds
    }

    static void ReflectionActivity()
    {
        StartActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();

        for (int i = 0; i < prompts.Length; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(2000); // Pause for 2 seconds before displaying the questions
            Console.WriteLine("Reflect on the following question:");
            Console.WriteLine("Why was this experience meaningful to you?");
            Thread.Sleep(2000); // Pause for 2 seconds before displaying the countdown
            Countdown(3); // Countdown from 3 seconds

            // Display other questions...

            Console.WriteLine();
        }

        EndActivity("Reflection Activity", 30); // Assuming each reflection takes 30 seconds
    }

    static void ListingActivity()
    {
        StartActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();

        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to think and start listing...");
        Thread.Sleep(5000); // Pause for 5 seconds before prompting for the list

        int count = 0;
        string item;
        do
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            item = Console.ReadLine();
            if (item != "done")
            {
                count++;
            }
        } while (item != "done");

        Console.WriteLine($"You have listed {count} items.");

        EndActivity("Listing Activity", 0); // No specific duration for listing activity
    }

    static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}
