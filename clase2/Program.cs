﻿using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      rotar ();
      Console.ReadLine();   
    }
    static void rotar()
    {
        string numero = Console.ReadLine();
        Char primero = numero[0];
        Char segundo = numero[1];
        string resto = numero.Substring(2, numero.Length -2);        
        string resultado = resto + primero + segundo;
        Console.WriteLine(resultado);
    }
  }
}

