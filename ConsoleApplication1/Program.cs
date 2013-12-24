using System;
// using MonoMac;

namespace HelloWorld3
{
    public class MainConsole
    {
        static void Main(string[] args)
        {

            

            char IterratorChar = Console.ReadKey().KeyChar;

            int Iterrater = int.Parse((IterratorChar).ToString());

            Console.WriteLine("\t\n");


            if (Iterrater > 0)
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Das ist ein Test");
                }

                for (int a= 0 ; a < Iterrater; a++)
                {

                    double wert = a * 30;
                    Console.WriteLine("Das ist ein rechenwert:\t{0,8:p}", wert);


                }
            }

                // Console.InputEncoding.GetChars(Text);

                Console.Write("\n Bitte hier Text eingeben: ");

                string text = Console.ReadLine();

                Console.WriteLine("\n das ist der Input ----> {0} <------", text);

                Console.WriteLine("\n Hier ist der Ausstieg vorgesehen \n");
            
            Console.WriteLine("Bitte belibiget Taste drücken um das Programm zu beenden");
            char test = Console.ReadKey().KeyChar;
                
        }
    }
    //private class Function 

}

