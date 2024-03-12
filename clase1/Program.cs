<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information
using system;
static void Main()
{
Console.WriteLine("HOLA, MUNDO!");
Console.WriteLine("cambio");
=======
﻿using System;

namespace HelloWorld
{
  class Infernal
  { 
    // sacar el promedio de las 2 notas
    static void Main()
    {
       
        /*
        Console.Write("Por favor ingrese la la primera nota: ");
        Console.Write("Por favor ingrese la la segunda nota: ");
        int nota = int.Parse(Console.ReadLine());
        int nota2 = int.Parse(Console.ReadLine());
       
        
        evaluarNota(nota);
        */
        int numero = 0;
        Console.WriteLine("Ingrese los numeros");
        numero = int.Parse(Console.ReadLine());
        
        rotar();
        
        /*
    }
    static void evaluarNota(int nota )
    {
        
        if (nota > 50)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
        */
    } 
    
    static void rotar()
    {
        string numero = Console.ReadLine();
        char ultimo = numero[numero.Length -1];
        string resto = numero.Substring(0, numero.Length -1);
        string resultado = ultimo + resto;
        Console.WriteLine(resultado);
    }                
  }
>>>>>>> Stashed changes
}



