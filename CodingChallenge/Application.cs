namespace CodingChallenge;

public class Application
{
    static void Main()
    {
        OldPhonePad oldPhonePad = new OldPhonePad();
        string input = "";
        
        while (input != "exit")
        {
            Console.Write("Enter the sequence of numbers (or 'exit' to quit): ");
            input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            
            try
            {
                string result = oldPhonePad.ConvertToText(input);
                Console.WriteLine("The result is: " + result);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}