using System;
class Operaciones{
    static void Main(String[] args){
        String nombre, producto;
        int cantidad=0;
        float valor=0, precio=0;
        System.Console.Clear();
        System.Console.SetCursorPosition(110,10);
        Console.WriteLine("Registrar factura \n");
        System.Console.SetCursorPosition(108,11);
        Console.WriteLine("------------------------ \n");
        System.Console.SetCursorPosition(108,13);
        Console.WriteLine("Digite nombre   [          ]");
        System.Console.SetCursorPosition(126,13);
        nombre=Console.ReadLine();
        System.Console.SetCursorPosition(108,14);
        Console.WriteLine("Digite producto [         ] ");
        System.Console.SetCursorPosition(126,14);
        producto=Console.ReadLine();
        System.Console.SetCursorPosition(108,15);
        Console.WriteLine("Digite cantidad [          ] ");
        System.Console.SetCursorPosition(126,15);
        cantidad = int.Parse(Console.ReadLine());
        System.Console.SetCursorPosition(108,16);
        Console.WriteLine("Digite precio [          ] ");
        System.Console.SetCursorPosition(126,16);
        precio = int.Parse(Console.ReadLine());

        valor=cantidad*precio;

        System.Console.SetCursorPosition(108,30);
        Console.WriteLine("...........Valor a pagar[   "+valor+"    ] ");
    }
}