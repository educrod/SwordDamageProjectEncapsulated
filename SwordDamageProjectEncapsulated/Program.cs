using System;

namespace SwordDamageProjectEncapsulated
{
    class Program
    {
        static Random random = new Random();
        

        private static int RollDice()
        {
            return random.Next(3, 18);
        }

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice());            
            
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char keyChar = Console.ReadKey(false).KeyChar;

                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3') return;

                swordDamage.Roll = RollDice();
                swordDamage.Magic = (keyChar == '1' || keyChar == '3');
                swordDamage.Flaming = (keyChar == '2' || keyChar == '3');

                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP");
            }
        }
    }
}