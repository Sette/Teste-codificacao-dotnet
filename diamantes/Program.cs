using System;
using System.Collections.Generic;

namespace diamantes
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> diamantes_pilha = new Stack<string>();
            
            string input = "";

            int n = int.Parse(Console.ReadLine());

            
            while(n > 0){
                input = Console.ReadLine();
                Stack<char> stack = new Stack<char>(input.ToCharArray());
                int diamantes = 0,possiveis_diamantes = 0;
                while(stack.Count > 0){
                    char elem = stack.Pop();
                    if(elem == '>'){
                        possiveis_diamantes+=1;
                    }else if(elem == '<'){
                        if(possiveis_diamantes > 0){
                            possiveis_diamantes-=1;
                            diamantes+=1;
                        }
                    }
                    
                }
                n-=1;
                Console.WriteLine(diamantes);
            }
            
            /* 
            Solução sem pilha
            string split = Console.ReadLine();
            int diamantes = 0,possiveis_diamantes = 0;
            for (int i = 0; i < split.Length; i++)
            {   
                Console.WriteLine(split[i]);
                if(split[i] == '<'){
                    possiveis_diamantes+=1;
                }else if(split[i] == '>'){
                    if(possiveis_diamantes>0){
                        possiveis_diamantes-=1;
                        diamantes+=1;
                    }
                }
            }

            Console.WriteLine(diamantes);
            */

        }
    }
}
