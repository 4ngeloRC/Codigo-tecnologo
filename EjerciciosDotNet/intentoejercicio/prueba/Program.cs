using System;
class Pagos{
    static void Main(String[] args){
        String producto;
        int cantidad=0;
        float valor=0, precio=0, Pago=0;
        System.Console.Clear();
        System.Console.SetCursorPosition(60,10);
        Console.WriteLine("Registrar pago \n");
        System.Console.SetCursorPosition(58,11);
        Console.WriteLine("------------------------ \n");
        System.Console.SetCursorPosition(58,13);
        Console.WriteLine("Digite producto [         ] ");
        System.Console.SetCursorPosition(76,13);
        producto=Console.ReadLine();
        System.Console.SetCursorPosition(58,14);
        Console.WriteLine("Digite cantidad [         ] ");
        System.Console.SetCursorPosition(76,14);
        cantidad=int.Parse(Console.ReadLine());
        System.Console.SetCursorPosition(58,15);
        Console.WriteLine("Digite precio   [         ] ");
        System.Console.SetCursorPosition(76,15);
        precio=float.Parse(Console.ReadLine());
        System.Console.SetCursorPosition(58,16);
        Console.WriteLine("Metodo de pago: ");
        System.Console.SetCursorPosition(58,17);
        Console.WriteLine("1. P. Efectivo");
        System.Console.SetCursorPosition(58,18);
        Console.WriteLine("2. P.Tarjeta");
        System.Console.SetCursorPosition(58,19);
        Console.WriteLine("cual eliges?:    [       ] ");
        System.Console.SetCursorPosition(78,19);
        Pago=float.Parse(Console.ReadLine());

        valor=cantidad*precio;

        if(Pago==1){
            System.Console.SetCursorPosition(58,21);
            Console.WriteLine("Su metodo de pago es P. Efectivo y el total a pagar es: "+((valor*15)/100));
        }
        if(Pago==2){
            System.Console.SetCursorPosition(58,21);
            Console.WriteLine("Su metodo de pago es P. Tarjeta y el total a pagar es: "+((valor*12)/100));
        }
    }
}