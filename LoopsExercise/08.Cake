namespace _08.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeVolume = width * length;
           //int sumPieces = 0;

            while (cakeVolume >= 0)
             
            {
                
                string input = Console.ReadLine();

                if (input == "STOP")
                    break;

                    cakeVolume -= int.Parse(input);

            
             }

                if (cakeVolume >= 0)
                {
                    Console.WriteLine($"{cakeVolume} pieces are left.");
                    
                } else

                Console.WriteLine($"No more cake left! You need {-cakeVolume} pieces more.");
            }
        }
    }
