// Escribir una función que recibe una cadena de caracteres como parámetro con una fecha de la forma
// “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
// Ej.: 10/11/1977 -> 1977­‐11­‐10
//
// La función para cambiar el forma de la fecha está implementada en el método de clase ChangeFormat de la
// clase Program. Ese método se invoca desde el método de clase Main de la clase Program que es el punto de
// entrada del programa.

using System;
using System.Collections;
using System.Text;

namespace DateFormat
{
    public class Program
    {
        public static void Main(string [] args)
        {
            string testDate = "10/11/1977";
            Format1 date1 = new Format1 (testDate);
            Format2 date2 = new Format2(testDate);
            Console.WriteLine($"{testDate} se convierte a: {date1.ChangeFormat1()} ");
            Console.WriteLine("--------  Con la otra funcion ----------");
            Console.WriteLine($"{testDate} se convierte a: {date2.ChangeFormat2()}");

        }
    }
}

