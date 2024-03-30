namespace CIT_190_Lesson_7_Collections_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> supercars = new List<string>
            {
                "Koenigsegg Jesko",
                "McLaren Artura",
                "Maserati MC20",
                "Aston Martin Valkyrie",
                "Ferrari Enzo",
                "Jaguar XJ220"
            };
            string[] newCars = new string[]
            {
                "Bugatti Chiron",
                "Pagani Zonda",
                "Ford GT",
                "Audi R8"
            };
            supercars.AddRange(newCars);
            supercars.Sort();

            Console.WriteLine();
            Console.WriteLine("Your list of supercars:");
            Console.WriteLine();

            foreach (string car in supercars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            Console.WriteLine("now removing the one I don't like...");
            Console.WriteLine();

            supercars.Remove("Audi R8");
            supercars.Reverse();

            foreach (string car in supercars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
