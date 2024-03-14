class par{
    static void Main(String[] args){
        String nombre;
        int n=0, r=0;
        System.Console.Clear();
        Console.WriteLine("Digite un numero \n");
        n =int.Parse(Console.ReadLine());
        r=n%2;
        System.Console.Clear();
        Console.WriteLine("Numero \n"+n);
        if(r==0){
            Console.WriteLine("El numero es par \n"+r);
        }
        else{
            Console.WriteLine("El numero es impar \n"+r);
        }
    }
}