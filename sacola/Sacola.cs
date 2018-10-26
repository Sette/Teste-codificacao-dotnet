using System;
using System.Collections.Generic;
namespace sacola
{
   
    class Sacola{
        private Stack<int> pilha {get;set;}
        private Queue<int> fila {get;set;}
        
        /*dotnet add package C5 --version 2.5.3 */
        private C5.IntervalHeap<int> fila_prioritaria {get;set;}


        public Sacola(){
            this.fila_prioritaria = new C5.IntervalHeap<int>();
            this.pilha = new Stack<int>();
            this.fila = new Queue<int>();
        }

        public void Add(int elem){
            this.fila_prioritaria.Add(elem);
            this.fila.Enqueue(elem);
            this.pilha.Push(elem);

        }

        public int[] pop(){
            int[] elems = new int[3];
            elems[0] = fila.Dequeue();
            elems[1] = pilha.Pop();
            elems[2] = fila_prioritaria.DeleteMax();
            return elems;
        }
        
    }
}