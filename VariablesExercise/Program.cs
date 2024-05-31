namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Jameson";
            int age = 45;
            char favLetter = 'e';
            bool isMarried = false;
            double moneyOnHand = 50.25;
            decimal favNumber = 260.123M;

            Console.WriteLine($"This is the story of {name}, a man who is {age} years old.");
            Console.WriteLine($"His favorite letter is {favLetter}, and his favorite number is {favNumber}.");
            Console.WriteLine($"He marrital status is {isMarried} and he currently has ${moneyOnHand} on his person.");
        }
    }
}
