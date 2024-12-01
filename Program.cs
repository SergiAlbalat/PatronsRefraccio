using System;
using BibliotecaPatronsRefraccio;
namespace PatronsRefraccio
{
    class Program
    {
        static void Main()
        {
            const string Msg1 = "Introdueix l'amplada del rectangle:";
            const string Msg2 = "Introdueix l'altura del rectangle:";
            const string Error = "El format del numero es incorrecte";
            double width, height;

            // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
            Console.WriteLine(Msg1);
            try
            {
                do
                {
                    width = Convert.ToDouble(Console.ReadLine());
                } while (!MyMethods.IsNatural(width));
                Console.WriteLine(Msg2);
                do
                {
                    height = Convert.ToDouble(Console.ReadLine());
                } while (!MyMethods.IsNatural(height));

                // Calcula l'àrea
                double area = width * height;
                Console.WriteLine("L'àrea del rectangle és: " + area);

                // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
                Console.WriteLine("Introdueix el radi del cercle:");
                double radius = Convert.ToDouble(Console.ReadLine());
                double circumference = 2 * Math.PI * radius;

                Console.WriteLine("La circumferència del cercle és: " + circumference);

                // Imprimeix un missatge basat en el valor de l'àrea
                if (area > 50)
                {
                    Console.WriteLine("L'àrea és més gran de 50");
                }
                else if (area > 20)
                {
                    Console.WriteLine("L'àrea és entre 20 i 50");
                }
                else
                {
                    Console.WriteLine("L'àrea és menor o igual a 20");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
