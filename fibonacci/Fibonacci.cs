using System;


class Fibonacci{
    private int[] fib;

    public int FibRecursivo(int n){
        if (n == 0) return 0;
        if (n == 1) return 1;

        return FibRecursivo(n-1) + FibRecursivo(n-2);
    }

    public int FibDynamic(int n){
        return this.fib[n];
    } 


    public Fibonacci(int len){
        fib = new int[len];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i < len; i++)
        {
            fib[i] = fib[i-1] + fib[i-2];
        }
    }
}