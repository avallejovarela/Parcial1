﻿using System;
using System.Security.Cryptography;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un
        //sueldo base de $XXXX.Además, recibe una comisión del 10 % sobre el valor total de cada venta que
        //realiza.El vendedor desea saber:
        /* ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el
        mes?
         ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
         ¿Cuál fue la venta que le generó la mayor comisión?
         ¿Cuál fue el promedio de las comisiones que recibió por cada venta?
        Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El
        objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde
        indique si ganó o no el beneficio.
        */

        //declaracion de constantes y variables
        const decimal sueldoBase = 2000000;
        const decimal comision = 10;
        const decimal extra = 100000;
        const decimal objetivo = 1000000;
        decimal totalComision, ventamayorcomision, promediocomision, venta1, venta2, venta3, comision1, comision2, comision3, sueldototal, totalventa; 

        // datos de entrada

        Console.Write("ingresa el valor de la venta 1: ");
        venta1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("ingresa el valor de la venta 2: ");
        venta2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("ingresa el valor de la venta 3: ");
        venta3 = Convert.ToDecimal(Console.ReadLine());

        // calculo de las comisiones

        comision1 = venta1 * (comision / 100);
        comision2 = venta2 * (comision / 100);
        comision3 = venta3 * (comision / 100);

        totalComision = comision1 + comision2 + comision3;

        // calculo del sueldo total

        sueldototal = sueldoBase + totalComision;

        // venta con mayor comision

        ventamayorcomision = comision1;
        if (comision2 > ventamayorcomision)
        {
            ventamayorcomision = comision2;
        }
        if (comision3 > comision1)
        {
            ventamayorcomision = comision3;
        }

        // promedio de comisiones 

        promediocomision = totalComision / 3;

        // bono extra

        totalventa = venta1 + venta2 + venta3;

        if (totalventa >= objetivo)
        {
            sueldototal = +extra;
        }

        // mostrar los resultados
        Console.WriteLine($"Comision total por la tres ventas {totalComision:C0}");
        Console.WriteLine($"Sueldo total del mes por:{sueldototal}");
        Console.WriteLine($"la venta que genero mayor comision fue: {ventamayorcomision:C0}");
        Console.WriteLine($"Promedio de las comisiones por las ventas es:  {promediocomision:C0}");

        if (totalventa >= objetivo)
        {
            Console.WriteLine($"Haz alcanzado el objetivo y por ende has recibido un extra por $100.000 pesos");
        }
        else
        {
            Console.WriteLine("No haz alcanzado el objetivo y por ende no vas a recibir beneficio extra");
        }
    }
}