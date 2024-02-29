using System;

class Captura{
    static void Main(string[] args){
        string n,a;
        int edad=0;
        System.Console.Clear();
    Console.WriteLine("captura de datos sencillas \n");
    Console.WriteLine("Digite su nombre:");
    n=Console.ReadLine();
    Console.WriteLine("Digite su apellido:");
    a=Console.ReadLine();
    Console.WriteLine("Digite su edad:");
    edad = int.Parse(Console.ReadLine());   
    Console.WriteLine("Su nombre es: "+n);
    Console.WriteLine("Su apellido es: "+a);
    Console.WriteLine("Su edad es: "+edad);

       }
}