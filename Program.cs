namespace Part_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die(7);

            die1.RollDie();
            die1.DrawDie();
            die2.RollDie();
            die2.DrawDie();
        }
    }
}
