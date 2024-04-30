using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Servicios
{
    internal class MenuImplemanetacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("       MENU");
            Console.WriteLine("----------------------"); 
            Console.WriteLine("1. Dar alta paciente");
            Console.WriteLine("2. Dar alta cita");
            Console.WriteLine("3. Asistencia cita");
            Console.WriteLine("4. Mostrar clientes");
            Console.WriteLine("0. salir");

            int i = Convert.ToInt32(Console.ReadLine());

            return(i);
        }
    }
}
