
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi 

{ 
    public class Message
    {

        // wyświetlanie powitania
        public void StartingScreen()
        {
            Console.WriteLine();
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine();
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine();
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine();
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine();
            Console.WriteLine(" WYBIERZ 1, 2 LUB 3:");
            Console.ReadLine();
            Console.Clear();
        }
      

        public void ReservationScreen ()
        {
            Console.WriteLine();
            Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ:");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

