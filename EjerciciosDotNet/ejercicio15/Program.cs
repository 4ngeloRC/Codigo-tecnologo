using System;
class Edades{
    static void Main(String[] args){
        int edad=0;
        Console.Clear();
        Console.WriteLine("Digite su edad \n 1. si su edad es de 0 a 3 años \n 2.si su edad es de 4 a 9 años \n 3.si su edad es de 10 a 12 años \n 4.si su edad es de 13 a 19 años \n 5.si su edad es de 20 a 29 años \n 6.si su edad es de 30 a 49 años \n 7.si su edad es de 50 a 59 años \n 8.si su edad es de 60 años en adelante");
        edad=int.Parse(Console.ReadLine());    
        switch(edad){
            case 1: Console.WriteLine("Usted es recien nacido");
            break;
            case 2: Console.WriteLine("Usted es infante");
            break; 
            case 3: Console.WriteLine("Usted es puberto");
            break;
            case 4: Console.WriteLine("Usted es adolecente");
            break;
            case 5: Console.WriteLine("Usted es Joven");
            break;
            case 6: Console.WriteLine("Usted es Adulto joven");
            break;
            case 7: Console.WriteLine("Usted es Adulto");
            break;
            case 8: Console.WriteLine("Usted es Adulto mayor");
            break;
            default: Console.WriteLine("Opcion no valida");
            break;
        }

    }
}