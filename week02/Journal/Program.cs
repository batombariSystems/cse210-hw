/*
Creativity:
I exceeded the core requirements by:
1. Allowing the user to record their mood with every journal entry.
2. Saving and loading the mood along with the journal entry.
3. Displaying the total number of journal entries whenever the journal is displayed.
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);

                Console.WriteLine("Journal entry added successfully!");
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);

                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            Console.WriteLine();
        }
    }
}
