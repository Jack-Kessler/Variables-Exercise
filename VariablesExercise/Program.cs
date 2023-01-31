namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myString = "great day to be alive";
            int myInt = 11;
            char myChar = 'A';
            bool myBool = true;
            double myDouble = 20.22d;
            decimal myDecimal = 11.0314m;
            
            Console.WriteLine($"Isn't it a {myString}? I just ate {myInt} cookies, and I feel '{myChar}'-Oh-Kay!");
            Console.WriteLine($"I have exactly {myDouble} seconds before my TrueCoders class starts, " +
                $"but it is going to take me {myDecimal} seconds to tie my shoes.");
            Console.WriteLine($"It is {myBool.ToString().ToLower()} that I have no time to waste!");
        }
    }
}
