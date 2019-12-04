using System;
using System.Diagnostics;
using System.Threading;

namespace Reaktionsspelet
{
    class Game
    {
        int rndNumber;
        int resultat;

        public Game()
        {
            Random rnd = new Random();
            rndNumber = rnd.Next(3,11);         // Skapar ett random nummer mellan 3-10
        }
        public void StartGame()
        {
            Stopwatch startKlocka = new Stopwatch();  // Skapar objektet stopWatch
            Console.Clear();
            Console.Write("Ok, get ready");
            
            for(int i = 0; i < rndNumber; i++){     // Loopar varje sekund för att skriva ut .
                Console.Write("."); 
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.Write("NOW!");
            
            startKlocka.Start();                            // startklockan börjar ticka
            Console.ReadKey();
            startKlocka.Stop();                             // startklockan stoppar
                  
            TimeSpan ts = startKlocka.Elapsed;              // skapar en TimeSpan för att få reda på tiden mellan start och stop
            if(ts.Milliseconds <= 0){
                Console.Write("Du fuskade!!");
            }else {
                resultat = ts.Milliseconds; // Skriver ut millisekunder
                Console.WriteLine("Din reaktionstid var " + resultat + " millisekunder.");   // Skriver ut resultatet i konsolen
            }   
        }
    }
}



