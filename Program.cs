namespace Hafiza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string difficulty = "";
            bool Isdifficulty = true;
            int score = 0;
            int fail = 0;
            int memorise = 0;
            bool Iscorrect = false;
            int answer = 0;

            try
            {
                do
                {
                    Console.WriteLine("Welcome to the Memory game!\nChoose level! \n(B)asic\n(M)edium\n(H)ard");
                    difficulty = Console.ReadLine();
                    difficulty = difficulty.ToLower();
                    Isdifficulty = difficulty == "b" || difficulty == "m" || difficulty == "h";
                    if (Isdifficulty) { break; }
                    else
                    {
                        throw new Exception("You typed wrong! For difficulty level use (B) , (M) or (H)");
                    }
                }
                while (Isdifficulty);

                Console.Clear();
                Console.WriteLine("Game starts!");
                Random random = new Random();
                do
                {
                    if (difficulty == "b") { memorise = random.Next(1000, 10000); }
                    else if (difficulty == "m") { memorise = random.Next(10000, 100000); }
                    else if (difficulty == "h") { memorise = random.Next(100000, 1000000); }
                    else;
                    Console.WriteLine(memorise);
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.Write("Answer: ");
                    answer = Int32.Parse(Console.ReadLine());
                    Iscorrect = answer == memorise;
                    if (Iscorrect) { Console.WriteLine("True answer"); score++; }
                    else { Console.WriteLine("Wrong answer"); fail++; }
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                while (fail < 3);
                Console.WriteLine($"Game over!\nScore:{score}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
        }
            
    }
}
