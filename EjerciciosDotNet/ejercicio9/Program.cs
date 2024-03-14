class Edad{
    static void Main(String[] args){
        String nombre;
        int edad=0;
        System.Console.Clear();
        Console.WriteLine("Digite un nombre \n");
        nombre=Console.ReadLine();
        Console.WriteLine("Digite edad\n");
        edad=int.Parse(Console.ReadLine());
        System.Console.Clear();
        Console.WriteLine("Nombre \n"+nombre);
        if(edad<18){
            Console.WriteLine("Usted es Menor de edad \n"+edad);
        }
        else{
            Console.WriteLine("Usted es mayor de edad \n"+edad);
        }
    }
}