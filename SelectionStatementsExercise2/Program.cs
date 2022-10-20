namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var userInput = Console.ReadLine();

            switch(userInput.ToLower())
            {
                case "science":
                    Console.WriteLine("I love bill nye");
                    break;
                case "math":
                    Console.WriteLine("I love Pi");
                    break;
                case "physical education":
                    Console.WriteLine("I run after twinkies");
                    break;
                case "spanish":
                    Console.WriteLine("I love tacos");
                    break;
                case "history":
                    Console.WriteLine("I love hercules");
                    break;
                default:
                    Console.WriteLine("I do not know of that class");
                    break;
            }
        }
    }
}