using examen.Dtos;
using examen.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Controladores
{
    internal class Program
    {
        public static List<PacienteDto> listaPacientes = new List<PacienteDto>();
        public static List<CitaDto> listaCitas = new List<CitaDto>();

        static void Main() {

            MenuInterfaz mi = new MenuImplemanetacion();
            OperaivaInterfaz oi = new OperativaImplemenacion();

            

            bool continuar = true;
            while (continuar)
            {
                int seleccion = mi.mostrarMenu();
                switch (seleccion)
                {
                    case 0:
                        continuar = false;
                        return;

                    case 1:
                        oi.darAltaPaciente();
                        break;

                    case 4:

                        oi.mostrarPacientes();

                        break;

                    case 3:

                        return;

                }
            }
        }

    }
}
