using System;

class horas{
    static void Main (string[] args){
        string nombre;
        int horas=0;
        float sueldo=0, gana=0, ganaex=0;
        System.Console.Clear();
        Console.WriteLine("Digite la cantidad de horas extras trabajadas \n");
        horas=int.Parse(Console.ReadLine());
        if(horas>2){
            Console.WriteLine("Digite el nombre del empleado \n");
            nombre=Console.ReadLine();
            Console.WriteLine("Digite el sueldo \n");
            sueldo=float.Parse(Console.ReadLine());
            if(sueldo>=1000){
                Console.WriteLine("empleado \n"+nombre);
                ganaex=sueldo/horas;
                gana=sueldo+ganaex;
                Console.WriteLine("Su sueldo es: "+sueldo+" + horas extras "+ganaex+", su sueldo total "+gana+"\n");
            }
            if(sueldo<1000){
                Console.WriteLine("empleado \n"+nombre);
                ganaex=sueldo/horas;
                gana=sueldo+ganaex+10;
                Console.WriteLine("Su sueldo es: "+sueldo+" + horas extras "+ganaex+" sueldo total "+gana+"\n");
            }
        }
        else{
            Console.WriteLine("Minimo 3 horas para continuar");
        }
    }
}
