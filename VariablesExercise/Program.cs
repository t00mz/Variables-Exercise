namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Rex";
            int dogAge = 6;
            bool myDogIsWhite = true;
            double dogHeight = 3.5;
            char nrOfLegs = '4';
            decimal dogWidth = 21.2341m;

            
            Console.WriteLine($"My Dog's name is {dogName}, he's {dogAge} years old, and he has {nrOfLegs} legs.");
            Console.WriteLine($"My dog is white;it's {myDogIsWhite}");
    }
}