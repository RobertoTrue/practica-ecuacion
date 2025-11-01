using ecuacicion_matematica;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el valor de a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de c:");
        double c = Convert.ToDouble(Console.ReadLine());

        // Creo un objecto para utilizarlo para llamar el metodo
        Ecuacion ecuacion = new Ecuacion(a, b, c);

        // Llamo al metodo para calcular las soluciones
        ecuacion.CalcularSoluciones();
    }
}