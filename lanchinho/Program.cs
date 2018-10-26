using System;
using System.Collections.Generic;

namespace lanchinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanchonete lanchonete = new Lanchonete("CJ Lanches");
            

            lanchonete.inserirLanche(new Lanche(1,"Cachorro quente",3.00));
            lanchonete.inserirLanche(new Lanche(2,"X-Salada",2.50));
            lanchonete.inserirLanche(new Lanche(3,"X-Bacon",5.00));
            lanchonete.inserirLanche(new Lanche(4,"Torrada simples",4.50));
            lanchonete.inserirLanche(new Lanche(5,"Refrigerante",1.50));
            
            

            while (true){
                string[] split = Console.ReadLine().Split(' ');
                int id = int.Parse(split[0]);
                int quantidade = int.Parse(split[1]);
                Pedido pedido = new Pedido();
                try{
                    pedido.inserirLanche(lanchonete.getLanche(id),quantidade);
                    Console.WriteLine($"Total: R$ {pedido.getPrecoPedido()}");
                }catch{
                    Console.WriteLine("Lanche inválido");
                    Console.WriteLine("Tabela de lanches: ");
                    Console.WriteLine("Código | Nome | Preço");
                    foreach(KeyValuePair<int,Lanche> entry in lanchonete.getLanches())
                    {
                        Console.WriteLine(entry.Value);
                    }
                }

            }
        }
    }
}
