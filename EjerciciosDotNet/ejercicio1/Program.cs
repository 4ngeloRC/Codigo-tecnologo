using System;

class operaciones{
    static void Main(String[] args){
        int a=0;
       
        System.Console.Clear();
        Console.WriteLine("Operaciones basicas \n");
        Console.WriteLine("Digite su peso \n");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Su peso es: \n"+a+"Kg");
    }
}