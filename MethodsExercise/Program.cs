using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Whats your favorite tv show?");
            string tvShow = Console.ReadLine();

            Console.WriteLine("Whats the best candy?");
            string candy = Console.ReadLine();

            Console.WriteLine($"{name} likes to eat their {candy} while watching their favorite show {tvShow}");

            Console.WriteLine(Add(4, 8));
            Console.WriteLine(Multiply(3, 8));
            Console.WriteLine(Subtract(21, 7));
            Console.WriteLine(Divide(20, 4));

        }
       
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }

    }
}
