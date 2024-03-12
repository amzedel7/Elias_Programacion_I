using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        int [] vector = {2,4,6,8,10,9,15,18};
        sumavector(vector); 
        MultiploTres(vector);
        Array.Sort(vector);                  
    }

    static void sumavector(int[]vector){
        int par = 0;
        int impar = 0;
        
        foreach(int elemento in vector)
        {
            if((elemento % 2)==0)
            par = par + elemento;
            if(elemento % 2 !=0)
            impar += elemento;
            
        }
        Console.WriteLine("la suma de numeros pares es: " +par+ " la suma de numeros impares es: "+ impar);
    }
    static void MultiploTres(int[]vector)
        
        {
        int multiplo = 0;
        foreach(int elemento in vector)
        {
            if(elemento % 3 == 0)
            {
                multiplo++;                
            }                        
        }
        Console.WriteLine("el vector tiene: " + multiplo + " multiplos de 3");
        Console.ReadKey();
    }
    
  }
}

