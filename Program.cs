using System;
namespace uppgift_3._1
{
    class program
    { 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hur gammal är du");
            int age = int.Parse(Console.ReadLine());
            if (age > 19)
            {
                Console.WriteLine("Du är för gammal för att delta i tävlingen");
            }
            else if (age < 16)
            {
                Console.WriteLine("Du är för ung för att delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Du är gammal nog att delta i tävlingen");
            }
        }
    }
}
