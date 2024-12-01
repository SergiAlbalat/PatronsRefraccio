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
            const string Msg3 = "L'àrea del rectangle és: {0}";
            const string Msg4 = "Introdueix el radi del cercle:";
            const string Msg5 = "La circumferència del cercle és: {0}";
            const string Error = "El format del numero es incorrecte";
            double width, height, area, radius, circumference;

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
                area = MyMethods.CalculateRectangle(width, height);
                Console.WriteLine(Msg3, area);

                // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
                Console.WriteLine(Msg4);
                do
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                } while (!MyMethods.IsNatural(radius));
                circumference = MyMethods.CalculateCircumference(radius);

                Console.WriteLine(Msg5, circumference);

                // Imprimeix un missatge basat en el valor de l'àrea
                MyMethods.WriteArea(area);
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
