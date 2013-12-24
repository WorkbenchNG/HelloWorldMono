using System;
using MonoMac;

namespace HelloWorld3
{
	public class MainConsole
	{
			static void Main (string [] args)
			{
			
				for (int i=0; i<10; i++) {
					Console.WriteLine ("Das ist ein Test");
				}
//Das ist ein Kommentar ich will wissen ob dieser auch in der Decompilten Version verfügbar ist !!!!


				for (int a=0; a<100; a++) {
					
					double wert = a * 30;
				    Console.WriteLine ("Das ist ein rechenwert:\t{0,8:p}",wert);
                    
                    if (a == 99)
                    {

                        // Console.InputEncoding.GetChars(Text);

                         Console.Write("\n Bitte hier Text eingeben: ");

                        string text = Console.ReadLine();

                        Console.WriteLine("\n das ist der Input ----> {0} <------",text);

                        Console.WriteLine("\n Hier ist der Ausstieg vorgesehen \n");

                    }

				}


			}
	}
}

