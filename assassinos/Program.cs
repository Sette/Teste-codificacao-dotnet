using System;
using System.Collections.Generic;

namespace assassinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> assasinos = new Dictionary<string, int>();
            Dictionary<string, int> assassinados= new Dictionary<string, int>();
            int val;
            string[] split;
            string nomes = Console.ReadLine();
            while(nomes != null){
                split = nomes.Split(" ");
                try
                {
                    assasinos.Add(split[0], 1);
                }
                catch (ArgumentException)
                {
                    assasinos[split[0]]+=1;
                }

                try
                {
                    assassinados.Add(split[1], 1);
                }
                catch (ArgumentException)
                {
                    assassinados[split[1]]+=1;
                }
                nomes = Console.ReadLine();
            }

            foreach(KeyValuePair<string, int> entry in assasinos)
            {
                
                if(!assassinados.TryGetValue(entry.Key, out val)){
                    Console.WriteLine($"{entry.Key} {entry.Value}");
                }
            }

        }
    }
}
