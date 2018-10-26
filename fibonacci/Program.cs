using System;

namespace fibonacci
{
    class Program
    {
        

        static void Main(string[] args)
        {   
            int len = 45;
            Fibonacci fib = new Fibonacci(len);

            while(true){
                int n = int.Parse(Console.ReadLine());
                if (n >= 0 && n < 45){
                Console.WriteLine(fib.FibDynamic(n));
                /* Console.WriteLine(fib.FibRecursivo(n));*/
                }else{
                    Console.WriteLine("Valor excede o limite permitido");
                }
            }
            

        }
    }
}
