using System;
using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date} - {Prompt}: {Response}";
        }
    }

    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveToFile()
        {
            Console.Write("Enter filename to save journal: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved to file.");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter filename to load journal: ");
            string filename = Console.ReadLine();
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');
                    string date = fields[0];
                    string prompt = fields[1];
                    string response = fields[2];
                    entries.Add(new Entry(prompt, response, date));
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            // List of prompts
            List<string> prompts = new List<string>
            {
                "what is your first name? ",
                "What is your last name? ",
                "How was your day? ",
                "how did you feel after prayer? ",
                "What is your favorite color? "
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nDaily Journal Menu");
                Console.WriteLine(" ");
                Console.WriteLine("1. new entry");
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");

                Console.Write("\nEnter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry(prompts[new Random().Next(prompts.Count)]);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } Console.WriteLine();
}   }   }       
