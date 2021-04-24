using System;
using System.IO;

namespace GetRandomName
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Oto lista wszystkich polskich imion: ");
            Console.WriteLine("Naciśnij ENTER aby wyświetlić listę ...");
            Console.ReadLine();
           
            string[] names = File.ReadAllLines("lista.txt");

            foreach (var item in names)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Naciśnij ENTER aby wylosować imię ...");
            GetRandomName(names);
            Console.WriteLine("Jeszcze raz? ... \n Wpisz tak aby wylosować ponownie ...");

            string answer = Console.ReadLine().ToLower();
            while (answer == "tak")
            {
                GetRandomName(names);
                Console.WriteLine("Jeszcze raz? ....");
                answer = Console.ReadLine().ToLower();


            }
            Environment.Exit(0);

        }

        public static void GetRandomName(string[] names)
        {
            Random rnd = new Random();
            int n = rnd.Next(names.Length);
            Console.WriteLine("Losowe imię to: " + names[n]);
        }


    }
       
}
