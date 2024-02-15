using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nBienvenido al conversor de temperaturas!");
                Console.WriteLine("¿Qué tipo de conversión deseas realizar?");
                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Fahrenheit a Celsius");
                Console.WriteLine("3. Celsius a Kelvin");
                Console.WriteLine("4. Kelvin a Celsius");
                Console.WriteLine("5. Fahrenheit a Kelvin");
                Console.WriteLine("6. Kelvin a Fahrenheit");
                Console.Write("Selecciona una opción (1-6): ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                double tempInicial, tempConvertida;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce la temperatura en grados Celsius: ");
                        tempInicial = Convert.ToDouble(Console.ReadLine());
                        tempConvertida = CelsiusAFahrenheit(tempInicial);
                        Console.WriteLine($"La temperatura en Fahrenheit es: {tempConvertida} °F");
                        break;
                    case 2:
                        Console.Write("Introduce la temperatura en grados Fahrenheit: ");
                        tempInicial = Convert.ToDouble(Console.ReadLine());
                        tempConvertida = FahrenheitACelsius(tempInicial);
                        Console.WriteLine($"La temperatura en Celsius es: {tempConvertida} °C");
                        break;
                    case 3:
                        Console.Write("Introduce la temperatura en grados Celsius: ");
                        tempInicial = Convert.ToDouble(Console.ReadLine());
                        tempConvertida = CelsiusAKelvin(tempInicial);
                        Console.WriteLine($"La temperatura en Kelvin es: {tempConvertida} K");
                        break;
                    case 4:
                        Console.Write("Introduce la temperatura en grados Kelvin: ");
                        tempInicial = Convert.ToDouble(Console.ReadLine());
                        tempConvertida = KelvinACelsius(tempInicial);
                        Console.WriteLine($"La temperatura en Celsius es: {tempConvertida} °C");
                        break;
                    case 5:
                        Console.Write("Introduce la temperatura en grados Fahrenheit: ");
                        tempInicial = Convert.ToDouble(Console.ReadLine());
                        tempConvertida = FahrenheitAKelvin(tempInicial);
                        Console.WriteLine($"La temperatura en Kelvin es: {tempConvertida} K");
                        break;
                    case 6:
                        Console.Write("Introduce la temperatura en grados Kelvin: ");
                        tempInicial = Convert.ToDouble(Console.ReadLine());
                        tempConvertida = KelvinAFahrenheit(tempInicial);
                        Console.WriteLine($"La temperatura en Fahrenheit es: {tempConvertida} °F");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Deseas realizar otra conversión? (s/n): ");
            } while (Console.ReadLine().ToLower() == "s");
        }

        static double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static double KelvinACelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        static double FahrenheitAKelvin(double fahrenheit)
        {
            return CelsiusAKelvin(FahrenheitACelsius(fahrenheit));
        }

        static double KelvinAFahrenheit(double kelvin)
        {
            return CelsiusAFahrenheit(KelvinACelsius(kelvin));
        }

    }
}
