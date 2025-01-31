using System;

class Program
{
    static void Main()
    {
       ScriptureLibrary library = new ScriptureLibrary();

       Scripture scripture = library.GetRandomScripture();

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayTest());

        while (!scripture.IsCompletelyHidden())
        {
            
            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();
           

            if (input == "")
            {
                
                scripture.HideRandomWord(3);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayTest());

                
            }
            

            else if (input?.ToLower() == "quit")
            {
                break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
