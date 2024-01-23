using System.Linq.Expressions;
using System;

namespace EjercicioClase
{
    class Heroes
    {
        private int cantidadHeroes = 5;
        static void Main(string[] args)
        {

            Console.WriteLine("C# Marvel Creator");
            Console.WriteLine("Crea tu Super Heroe");
            Console.WriteLine("Cantidad de super Heroes?");

            int cantidadHeroes = Int32.Parse(s: Console.ReadLine());

            SuperHeroe[] listObj = new SuperHeroe[cantidadHeroes];

            for (int i = 0; i < cantidadHeroes; i++)
            {
                //Console.WriteLine("TotalLength("+ listObj.Length + ")");
                //Console.WriteLine("i["+i+"]");
                Console.WriteLine("Datos del Super Heroe #" + (i + 1));
                SuperHeroe se = new SuperHeroe();

                Console.WriteLine("Nombre: ");
                se.Nombre = Console.ReadLine();

                Console.WriteLine("Identidad Secreta: ");
                se.IdentidadSecreta = Console.ReadLine();

                Console.WriteLine("Ciudad: ");
                se.Ciudad = Console.ReadLine();

                Console.WriteLine("Puede Volar: (SI / NO)");
                string pv = Console.ReadLine();

                if (pv.ToLowerInvariant() == "no")
                {
                    se.PuedeVolar = false;
                }
                else {
                    se.PuedeVolar = true;
                }

                Console.WriteLine("Super Poder: ");
                se.SuperPoder = Console.ReadLine();

                Console.WriteLine("Descripcion: ");
                se.Descripcion = Console.ReadLine();

                Console.WriteLine("Nivel: ");
                se.Nivel = Int32.Parse(Console.ReadLine());

                listObj[i] = se;
            }

            for (int i = 0; i < listObj.Length; i++)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("Datos del Super Heroe #" + (i + 1));
                Console.WriteLine("*******************************************");
                listObj[i].imprimir();
            }
        }
    }
}