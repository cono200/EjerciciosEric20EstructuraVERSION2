using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEric20Estructura
{
    internal class EstructuraControl
    {
        public string DiaSemana(int dia)
        {
            string semana;

            switch (dia)
            {
                case 1:
                    dia = 1;
                    semana = "Domingo";
                    break;
                case 2:
                    dia = 2;
                    semana = "Lunes";
                    break;
                case 3:
                    dia = 4;
                    semana = "Martes";
                    break;
                case 4:
                    dia = 5;
                    semana = "Miercoles";
                    break;
                case 5:
                    dia = 6;
                    semana = "Jueves";
                    break;
                case 6:
                    dia = 7;
                    semana = "Viernes";
                    break;
                case 7:
                    dia = 8;
                    semana = "Sabado";
                    break;
                default:
                    semana = "No existe ese dia karnal, no inventes cosas";
                    break;
            }
            return semana;


        }

        public double PromedioNumeros(double numero1, double numero2, double numero3)
        {
            double promedioNumero = 0;
            if (numero1 < 0 && numero2 <0 && numero3<0 )
            {
                return promedioNumero;
            }
            else if (numero1 < 0 && numero2<0 && numero3>0 )
            {
                promedioNumero = numero3;
            }
            else if (numero1 <0 && numero2>0 && numero3>0)
            {
                promedioNumero = (numero2 + numero3) / 2;
            }
            else if(numero1>0 && numero2>0 && numero3 < 0)
            {
                promedioNumero = (numero2 + numero1) / 2;
            }
            else
            {
                promedioNumero=(numero2 + numero3 + numero1) / 3;
            }
            return promedioNumero;
            

        }


        public void Divisirve(double numero)
        {

            if (numero % 2 !=0 && numero % 3 !=0)
            {
                Console.WriteLine("No es karnal");
            }

            else if (numero %2 == 0 && numero %3 ==0)
            {
                Console.WriteLine("Se puede dividir tanto con 2 como por 3");
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("Se puede dividir por 2");
            }

            else
            {
                Console.WriteLine("Se puede dividir entre 3");
            }
            /*
             if (numero % 2 == 0 && numero % 3 == 0)
            {
                Console.WriteLine("Se puede dividir tanto con 2 y con 3");
            }
            else  if (numero % 2 == 0)
            {
                Console.WriteLine("Se puede dividir  por 2");
            }
            else if (numero % 3 == 0)
            {
                Console.WriteLine("Se puede dividir por 3");
            }
            else
            {
                Console.WriteLine("No ai");
            }
            */


        }


        public  void  SemanaDia(string  DiaSemana)
        {
            

            switch (DiaSemana)
            {
                case "Lunes":
                    Console.WriteLine("1");
                    break;
                    
                    
                case "Martes":
                    Console.WriteLine("2");
                    break;
                case "Miercoles":
                    Console.WriteLine("3");
                    break;
                case "Jueves":
                    Console.WriteLine("4");
                    break;
                case "Viernes":
                    Console.WriteLine("5");    
                    break;
                case "Sabado":
                    Console.WriteLine("6");
                    break;
                case "Domingo":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("No existe ese dia karnal, no inventes cosas");  
                    break;
            }
            


        }

        //METODO MIO
        public void  NumeroPrimo(double numero)
        {

            if (numero <= 1)
            {
                Console.WriteLine("No es primo");
            }
            
            else if (numero % 2 == 0)
            {
                Console.WriteLine("No es primo");
            }
            else
            {
                Console.WriteLine("Es primo");            }
        }


        //METODO DE PROFE
        public bool EsPrimo(int numero2)
        {
            bool esPrimo = true;
            for(int x=2; x< numero2; x++)
            {
                if ( numero2 % x == 0)
                {
                    esPrimo= false;
                }
            }
            return esPrimo;
        }


      

        public   double Descuento(double precioOriginal, double porcentajeDescuento)
        {
            double resultado;
            porcentajeDescuento = porcentajeDescuento / 100;
            resultado= precioOriginal * porcentajeDescuento;
                
            return resultado;
         }
        public int Factorial (int numero )
        {
            if (numero == 1)
                return numero;
            numero *= Factorial(numero - 1);




            return numero; }

        public int SumaDescendente(int numero)
        {
           
            if (numero == 0)
                return numero;
            
            return numero+ SumaDescendente(--numero); 
        
        }


        public bool Palindromo(string numero1)
        {
            bool palindromo= true;
            for (int i=0; i<numero1.Length/2; i++)
            {
                if (numero1[i] != numero1[numero1.Length - i - 1])
                {
                    palindromo= false;
                }
            }
            return palindromo;
        }


        public int  SumarNumeros(int numeroSuma)
        {

            int suma = 0;
            if(numeroSuma < 0)
            {
                return suma;
            }
            for (int i = 0; i <= numeroSuma; i++)
            {
                suma+=i;
            }
            return suma;
        }







        internal string ToString(string? v)
        {
            throw new NotImplementedException();
        }
    }
}
