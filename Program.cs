using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_RAMS_1018822
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.Write("Ingrese un número entero: ");
            int num = 0;
            string letra = Console.ReadLine();

            if (int.TryParse(letra, out num))
            { 
            if(num > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            if (num < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            if (num == 0)
            {
                Console.WriteLine("El número es cero");
            }
            }
            else
            {
                Console.WriteLine("Ingresó una letra");
            }


            Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Días de la semana: ");
            Console.WriteLine("1. Lunes");
            Console.WriteLine("2. Martes");
            Console.WriteLine("3. Miercoles");
            Console.WriteLine("4. Jueves");
            Console.WriteLine("5. Viernes");
            Console.WriteLine("6. Sábado");
            Console.WriteLine("7. Domingo");
            Console.WriteLine("");
            Console.Write("Ingrese el numero de dia de la semana: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("DIA: Lunes");
                    break;
                case 2:
                    Console.WriteLine("DIA: Martes");
                    break;
                case 3:
                    Console.WriteLine("DIA: Miercoles");
                    break;
                case 4:
                    Console.WriteLine("DIA: Jueves");
                    break;
                case 5: 
                    Console.WriteLine("DIA: Viernes");
                    break;
                case 6:
                    Console.WriteLine("DIA: Sabado");
                    break;
                case 7:
                    Console.WriteLine("DIA: Domingo");
                    break;
            }

            Console.ReadKey();
        }
    }
}
