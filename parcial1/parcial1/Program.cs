internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" ");

        // primero solicitamos el coeficiente 

        Console.Write("ingrese el valor de a ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de b ");
        double b = Convert.ToDouble(Console.ReadLine());

        // posibilidades

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("La ecuacion tiene infinitas soluciones");
            }
            else
            {
                Console.WriteLine("La ecuacion no tiene solución");
            }
        }
        else {



    }
}