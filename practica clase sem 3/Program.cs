using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_clase_sem_3
{
    internal class Program

    {

        public static void Calculosuma()
        {
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Digite el primer numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {n1+n2}");

        }

        public static void Calculoresta()
        {
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Digite el primer numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {n1-n2}");

        }

        public static void Calculodivision()
        {
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Digite el primer numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {n1/n2}");

        }

        public static void Calculopotencia()
        {
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Digite la base:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el exponente:");
            n2 = float.Parse(Console.ReadLine());
            double Result=Math.Pow(n1, n2);
            Console.WriteLine($"El resultado es:{Result}");

        }

        public static void Calculotriangulo()
        {
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Digite la base:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es:{(n1*n2)/2}");

        }
        public static void Calculocuadrado()
        {
            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Digite la base:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es:{n1*n2}");

        }

        static void Main(string[] args)
        {

            string opcion="";

            do
            {
                Console.WriteLine("Escriba una opcion");
                Console.WriteLine("Sumar");
                Console.WriteLine("Restar");
                Console.WriteLine("Division");
                Console.WriteLine("Potencia");
                Console.WriteLine("Triangulo");
                Console.WriteLine("Cuadrado");
                Console.WriteLine("Salir");
                opcion = Console.ReadLine().ToLower();


                switch (opcion)

                {
                    case "sumar":
                        Calculosuma();
                        break;
                    case "restar":
                        Calculoresta();
                        break;
                    case "division":
                        Calculodivision();
                        break;
                    case "potencia":
                        Calculopotencia();
                        break;
                    case "triangulo":
                        Calculotriangulo();
                        break;
                    case "cuadrado":
                        Calculocuadrado();
                        break;
                    case "salir":
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;

                }
            }

            while (opcion != "salir");


            {
                
                Console.WriteLine("Presione enter para cerrar la consola");
                Console.Read();

            }


        }
    }
}
