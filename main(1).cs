using System;
using System.Collections.Generic;
class HelloWorld {
  
    public static Dictionary<long,long> cache = new Dictionary<long,long>();
    //zad1---------------------------------------------------------
    public static long fib(long n){
        if( n == 0 || n == 1){ return n;}
         
        if(cache.ContainsKey(n)){
            return cache[n];
        }  
        long result = fib(n-1)+fib(n-2);
        cache[n] = result;
        return result;
        
    }
    //zad2---------------------------------------------------------------
    public static long zaba(long n){
        long[] dp = new long[n+1];
        
        dp[0] = 1;
        
        for(long i = 0; i < n; i++){
            
            dp[i+1] += dp[i];
            
            if(i + 2 < n){
                dp[i+2] += dp[i];
            }
        }
        return dp[n];
    }
    //zad2 ----------------------------------------------------- 
    public static long zaba1(long n, long k){
        long[] dp = new long[n+1];
        
        dp[0] = 1;
        
        for(long i = 0; i < n; i++){
            for(long j = 1; j < k; j++){
                dp[i+1] += dp[i];
                
                if(i + j + 1 < n){
                    dp[i+j+1] += dp[i];
                }
            }
        
        }
        return dp[n];
    }
    //zad3 - NIE DZIALA--------------------------------------------------------
    public static long zaba2(long n,long k){
        long[,] dp = new long[n+1,k];
        dp[0,0] = 1;
        
        for(long i = 0; i < n; i++){
            for(long j = 0; j < k; j++){
                dp[i+1,j] += dp[i,j];
                
                if(i + 2 <= n && j+1 < k){
                    dp[i+2,j+1] += dp[i,j];
                }
            }
        }
        long result = 0;
        for(long i = 0; i < k;i++){
            result+=dp[n-1,i];
        }
        return result;
    }
    //zad 4------------------------------------------------------------
    public static long zaba3(int[] n){
        int arrLen = n.Length;
        int[] dp = new int[99999];
        for(int i = 0; i < arrLen; i++){
            dp[i] = 99999;
        }
        
        
        dp[0] = 0;
        
        for(int i = 0;i< arrLen-1; i++){
            dp[i+1] = Math.Min(dp[i+1],dp[i] + Math.Abs(n[i] - n[i+1]));
        
        
        
        if(i+2 <arrLen){
            dp[i+2] = Math.Min(dp[i+2],dp[i] + Math.Abs(n[i] - n[i+2]));
        }
        }
        return dp[arrLen-1];
    }
    
  static void Main() {
    
    Console.WriteLine(fib(5));//zad1
    Console.WriteLine(zaba(51));//zad2a
    Console.WriteLine(zaba1(51,2));//zad2b
    Console.WriteLine(zaba2(5,1));//zad3 - NIE DZIALA
    int[] tab = {30,10,60,10,60,50};
    Console.WriteLine(zaba3(tab)); // zad4
  }
  
}
