using System;

class salario{
    static void Main(string[] args){
        float horaE=0, antiguo=0, horaM=0, sueldo=0, desc=0, sueldoT=0, sueldoTD=0;
        string nombre;
        System.Console.Clear();
        Console.WriteLine("Digite el valor de su hora de trabajo \n");
        horaE=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite nombre de empleado \n");
        nombre=Console.ReadLine();
        Console.WriteLine("Digite la antiguedad en la empresa en años \n");
        antiguo=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cantidad de horas trabajadas en el mes \n");
        horaM=float.Parse(Console.ReadLine());

        sueldo=horaM*horaE;
        sueldoT=sueldo+(antiguo*50000);
        desc=(sueldoT*13)/100;
        sueldoTD=sueldoT-desc;

        Console.WriteLine("Empleado "+nombre+", lleva "+antiguo+" años en la empresa. \n Su hora laboral esta valorizada en "+horaE+". \n Su pago en bruto es: "+sueldo+". \n Su pago sin descuento es de: "+sueldoT+".  \n El descuento realizado es del "+desc+"%. \n Su pago total es de "+sueldoTD+"");

    }
}