using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();
            if (answer=="Yes")
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\asus\Desktop\W3\PU_IntroCSharp_InClass_1801681035\W3InClass\Exercise\Music\09 Kamikaze.wav"))
                {
                    Console.Write("Now playing Eminem-Kamikaze");
                    player.PlaySync();
                    
                }
            }
            else if(answer == "Fuck")
            {
                Console.WriteLine("Yes, fuck you too!!!");
            }
            else if (answer=="No")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Wrong imput!");
            }

           

            
        }
    }
}
