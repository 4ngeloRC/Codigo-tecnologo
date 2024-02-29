using System;
class Operadores{
    static void Main(String[] args){
        int a=0,b=0,s=0,r=0,m=0,d=0, d1=0;
        System.Console.Clear();
        System.Console.SetCursorPosition(110,10);
        Console.WriteLine("Operaciones basicas \n");
        System.Console.SetCursorPosition(108,11);
        Console.WriteLine("------------------------ \n");
        System.Console.SetCursorPosition(108,13);
        Console.WriteLine("Digite Numero   [   ]");
        System.Console.SetCursorPosition(126,13);
        a = int.Parse(Console.ReadLine());
        System.Console.SetCursorPosition(108,14);
        Console.WriteLine("Digite Numero   [   ]");
        System.Console.SetCursorPosition(126,14);
        b = int.Parse(Console.ReadLine());
        System.Console.Clear();
        s= a+b;
        r = a-b;
        m = a*b;
        d = a/b;
        d1 = a%b;
        System.Console.SetCursorPosition(110,15);
        Console.WriteLine("La suma (+) es: "+s);
        System.Console.SetCursorPosition(110,16);
        Console.WriteLine("La resta (-) es: "+r);
        System.Console.SetCursorPosition(110,17);
        Console.WriteLine("La multiplicacion (*) es: "+m);
        System.Console.SetCursorPosition(110,18);
        Console.WriteLine("La divicion (/) es: "+d);
        System.Console.SetCursorPosition(110,19);
        Console.WriteLine("La division con mod (%) es: "+d1);
        System.Console.SetCursorPosition(110,20);
    }
}   