using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var pickles = Sum(10, 11);
            var bugs = multiply(17, 18);

            Console.WriteLine("What is your name?"); // output
            var name = Console.ReadLine(); // input
            Console.WriteLine("What is your favorite ice cream flavor?"); // output
            var flavor = Console.ReadLine(); // input
            Console.WriteLine("Who is your favorite superhero"); // output
            var hero = Console.ReadLine(); // input
            Console.WriteLine("Which planet is third from the sun?"); // output
            var orb = Console.ReadLine(); // input

            Console.WriteLine($" {name} loves {flavor} and his favorite superhero is {hero} he is the strongest on the {orb}");
            Console.WriteLine();
            Console.WriteLine($" ill be {pickles} in two years. And {bugs} is a big number.");

        }
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}

