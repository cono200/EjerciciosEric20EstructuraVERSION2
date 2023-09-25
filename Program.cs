using System;

namespace EjerciciosEric20Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstructuraControl control1 = new EstructuraControl();

            //EJERCICIO DE QUE SELECCIONAS UN NUMERO Y TE DA EL DIA
            /*
            Console.WriteLine("Ingresa el dia que quieres saber");
            int dia= Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(control1.DiaSemana(dia));
            */


            //EJERCICIO QUE TE SACA EL PROMEDIO DE 3 CALIFICACIONES
            /*
            Console.WriteLine("Escribe la primera calificacion");
            int numero1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe la segunda calificacion");
            int numero2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe la tercera calificacion");
            int numero3=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(control1.PromedioNumeros(numero1,numero2,numero3));
            */
            //   EJERCICIO DE DIVISIRVE POR 2 O 3
            /*
               Console.WriteLine("Escribe el numero");
               int numero = Convert.ToInt32(Console.ReadLine());

               control1.Divisirve(numero);


               /*
               Console.WriteLine("Escribe la palabra (nota la primera debe de llevar mayuscula y estar bien escrita Ejemeplo: Lunes)");
               string DiaSemana= Console.ReadLine();

               control1.SemanaDia(DiaSemana);

               //EJERCICIO DE NUMEROS PRIMOS

               Console.WriteLine("Escribe el numero que desees saber si es primo o no");
               double numero=Convert.ToDouble(Console.ReadLine());
               control1.NumeroPrimo(numero);


               /*PROGRAMA DE DESCUENTOS
               Console.WriteLine("Escribe el precio original");
               double precioOriginal = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("Escribe el porcentaje de descuento");
               double porcentajeDescuento = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine(control1.Descuento(precioOriginal, porcentajeDescuento)); 
               */

            /*
            Console.WriteLine("Escribe un numero");
            string numero1=Console.ReadLine();
            Console.WriteLine(control1.Palindromo(numero1));
         
            
            Console.WriteLine("Escribe el numero que desees saber si es primo o no");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(control1.EsPrimo(numero2)); 

            */
            EstructuraControl sumaDescendente = new EstructuraControl();
            Console.WriteLine("Ingrese un numero");

<<<<<<< HEAD


            int numero= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sumaDescendente.SumaDescendente(numero));
=======
            Console.WriteLine("Escribe un numero");
            int numeroSuma=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(control1.SumarNumeros(numeroSuma));

>>>>>>> 7838efbf07c8768ac9aa318ffb635c22cb28e2b5
        }
    }
}