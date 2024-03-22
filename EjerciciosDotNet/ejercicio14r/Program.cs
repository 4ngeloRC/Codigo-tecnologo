using System;
class calculadora{
    static void Main(String[] args){
        int op=0, a=0, b=0, c=0;
        Console.Clear();
        Console.WriteLine("Digite la opcion \n 1.Digite suma \n 2.Digite resta \n 3.Digite multiplicacion \n 4.Digite division");
        op=int.Parse(Console.ReadLine());
        switch(op){
            case 1: Console.WriteLine("Usted digito suma");
            Console.WriteLine("Digite un numero");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            b=int.Parse(Console.ReadLine());
            c=a+b;
            Console.WriteLine("El resultado es:" +c);
            break;
            case 2: Console.WriteLine("Usted digito resta");
            Console.WriteLine("Digite un numero");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            b=int.Parse(Console.ReadLine());
            c=a+b;
            Console.WriteLine("El resultado es:" +c);
            break;
            case 3: Console.WriteLine("Usted digito multiplicacion");
            Console.WriteLine("Digite un numero");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            b=int.Parse(Console.ReadLine());
            c=a+b;
            Console.WriteLine("El resultado es:" +c);
            break;
            case 4: Console.WriteLine("Usted digito division");
            Console.WriteLine("Digite un numero");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            b=int.Parse(Console.ReadLine());
            c=a+b;
            Console.WriteLine("El resultado es:" +c);
            break;
            default: Console.WriteLine("Opcion no valida");
            break;
        }
    }
}