namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var cookies = Multiply(4, 7);
            Console.WriteLine($" I have {amountOfCars} cars.");
            Console.WriteLine($" My sister and I love cookies, I ate {cookies}");
        Console.WriteLine("What is your name?"); // output
            var name = Console.ReadLine(); // input 
            Console.WriteLine("What is you favorite color?"); // output
            var color = Console.ReadLine(); // input
            Console.WriteLine("What is your favorite animal?"); // output
            var animal = Console.ReadLine(); // input
            Console.WriteLine("Whos your favorite band?"); // output
            var band = Console.ReadLine(); // input 


            Console.WriteLine($" {name} was having a bad day because his {color} shirt got ripped because of his {animal}." +
                $" It got better when {name} got to see his favorite band {band}.");
        }

        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        
    }        
}
