using System;

namespace sacola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sacola sacola = new Sacola();

            string leitura = Console.ReadLine();

            while (leitura != null){

                int n = int.Parse(leitura);

                bool pilha = true;
                bool fila = true;
                bool prioridade = true;
                bool misto = true;

                for (int i = 0; i < n; i++)
                {
                    string[] split = Console.ReadLine().Split(' ');
                    int comando = int.Parse(split[0]);
                    int elem = int.Parse(split[1]);

                    if (comando == 1){
                        sacola.Add(elem);
                    }else if (comando == 2){
                        int[] elems = sacola.pop();
                        fila = fila && (elems[0] == elem);
                        pilha = pilha && (elems[1] == elem);
                        prioridade = prioridade && (elems[2] == elem);
                        misto = misto && ((fila && pilha) || (fila && prioridade) || (pilha && prioridade));
                    }else{
                        Console.WriteLine("Comando inválido");
                    }
                }

                if (misto){
                    Console.WriteLine("not sure");
                }else if(fila){
                    Console.WriteLine("queue");
                }else if(pilha){
                    Console.WriteLine("stack");
                }else if(prioridade){
                    Console.WriteLine("priority queue");
                }else{
                    Console.WriteLine("impossible");
                }

            leitura = Console.ReadLine();
            }

        }
    }
}
