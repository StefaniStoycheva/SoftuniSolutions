namespace ExerciseLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coins 07 diff resolution
            double value = double.Parse(Console.ReadLine());

            int coins = 0;

            double curStotinkiCoinValue = 0.01; // start with the largest stotinki coin (2 leva)

            while (value != 0)
            {
                if (value >= curStotinkiCoinValue)
                {
                    coins++; // another coin there!
                    value = Math.Round(value - curStotinkiCoinValue, 2); // we must round here, otherwise we'll be in double "precision trouble"
                }
                else
                    // the current value is less than the current coin value
                    // go to the lesser coin value
                    switch (curStotinkiCoinValue)
                    {
                        case 2.00: curStotinkiCoinValue = 1.00; break;
                        case 1.00: curStotinkiCoinValue = 0.50; break;
                        case 0.50: curStotinkiCoinValue = 0.20; break;
                        case 0.20: curStotinkiCoinValue = 0.10; break;
                        case 0.10: curStotinkiCoinValue = 0.05; break;
                        case 0.05: curStotinkiCoinValue = 0.02; break;
                        case 0.02: curStotinkiCoinValue = 0.01; break;
                        case 0.01: curStotinkiCoinValue = 0; break; // this is the end of the cycle
                    }
            }

            Console.WriteLine(coins);
        }
    }
}