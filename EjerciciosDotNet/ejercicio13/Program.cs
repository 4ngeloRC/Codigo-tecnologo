using System;
class Program{
    static void Main(string[] args){
        int op=0;
        Console.Clear();
        Console.WriteLine("Digite la opcion \n 1.Digite 1 \n 2.Digite 2 \n 3.Digite 3 \n");
        op=int.Parse(Console.ReadLine());
        switch(op){
            case 1: Console.WriteLine("Usted digto la pocion 1");
            break;
            case 2: Console.WriteLine("Usted digto la pocion 2");
            break;
            case 3: Console.WriteLine("Usted digto la pocion 3");
            break;
            default: Console.WriteLine("Opcion no valida");
            break;
        }
    }
}