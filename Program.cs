namespace Part_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();

            if (die1.Roll == 1 && die2.Roll == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if (die1.Roll == die2.Roll)
            {
                Console.WriteLine("Doubles!");
            }
            else if (die1.Roll + die2.Roll == 7)
            {
                Console.WriteLine("You got a Sum of Seven!");
            }
            else if (die1.Roll + die2.Roll % 2 == 0 )
            {
                Console.WriteLine("You got an Even Sum!");
            }

            if (die1.Roll > die2.Roll)
            {
                Console.WriteLine("Dice One is Bigger!");
            }
            else if (die2.Roll > die1.Roll)
            {
                Console.WriteLine("Dice Two is Bigger!");
            }
            // Can't figure out how to look for a sequence-
            die1.DrawDie();
            die2.DrawDie();
        }
    }
}
