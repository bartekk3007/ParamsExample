namespace ParamsExample
{
    public class Program
    {
        public static void printAll(params string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        static void Main(string[] args)
        {
            printAll("Andrzej", "Bartek", "Czesław", "Dariusz", "Elżbieta");
        }
    }
}
