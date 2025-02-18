namespace Part_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die(4);

            Console.WriteLine(die1.Roll);
            Console.WriteLine(die2.Roll);
        }
    }
}
