internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" ");

        /*Escriba un programa que pida los coeficientes de una ecuación de primer grado (a x + b = 0) y
muestre la solución.
Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los
números sean solución. La fórmula de las soluciones es x = -b / a
*/

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
        else
        {
            // solucion

            double x = -b / a;
            Console.WriteLine($"La solcion es: x = {x}");
        }




    }
}