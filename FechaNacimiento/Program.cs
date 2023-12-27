using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaNacimiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO Y EXCELENTE");
            //Hacer un programa que le pida al usuariola fecha de nacimiento y nosotros le diremos que dia de la semana era

            //Variables necesarias
            string cadenaFechaNacimiento;
            DateTime dateTimeFechaNacimiento;

            //Pedimos la fecha de nacimiento
            Console.Write("Dime la fecha de tu nacimiento (dia mes y año ) y te dire que sia de la semana era:  ");
            cadenaFechaNacimiento = Console.ReadLine();
            //Convertimos la cadena en un objeto DateTime
            dateTimeFechaNacimiento = DateTime.Parse(cadenaFechaNacimiento);

            //Aplicamos formato de fecha personalizado ("dddd") para mostrar el dia de la semana
            Console.WriteLine($"Naciste un {dateTimeFechaNacimiento.ToString("dddd")}");
        }
    }
}
