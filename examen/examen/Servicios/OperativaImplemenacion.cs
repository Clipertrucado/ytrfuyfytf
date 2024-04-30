using examen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Servicios
{
    

    internal class OperativaImplemenacion : OperaivaInterfaz
    {
        
        public void darAltaPaciente()
        {
            Controladores.Program.listaPacientes.Add(crearPaciente());

        }

        private PacienteDto crearPaciente() { 
            PacienteDto paciente = new PacienteDto();

            Console.WriteLine("----------------------");
            Console.WriteLine("       PACIENTE");
            Console.WriteLine("----------------------");
            Console.WriteLine("Nombre del paciente");
            paciente.NombrePaciente = Console.ReadLine();

            bool fecha = true;
            do
            {
                try
                {
                    Console.WriteLine("Fecha de nacimiento (yyyy/MM/dd)");
                    paciente.FechaNacimientoPaciente = Convert.ToDateTime(Console.ReadLine());
                    fecha = false;
                }
                catch
                {

                    Console.WriteLine("La fecha introducida no es valida");
                    fecha = true;

                }


            }while (fecha);

            Console.WriteLine("DNI del paciente");
            paciente.DniPaciente = Console.ReadLine();

            paciente.IdPaciente = calcularId();

            return paciente;
        }

        private int calcularId() {

            int id = 1;

            for (int i = 1; i < 100; i++)
            {
                foreach (var Paciente in Controladores.Program.listaPacientes)
                {

                    if (i == Paciente.IdPaciente)
                    {

                    }
                    else
                    {
                        id = i;
                        i = 100;
                        break;
                    }

                }
            }

            return id;
        }

        public void mostrarPacientes()
        {
            foreach (var Paciente in Controladores.Program.listaPacientes) {

                Console.WriteLine("----------------------------------" +
                    "\n ID: " + Paciente.IdPaciente +
                    "\n DNI: " + Paciente.DniPaciente +
                    "\n Nombre: " + Paciente.NombrePaciente +
                    "\n Fecha naci: " + Paciente.FechaNacimientoPaciente.ToString());


            }
        }

        public void darAltaCita()
        {
             Controladores.Program.listaCitas.Add(crearCita());
        }

        private CitaDto crearCita() {
            CitaDto cita = new CitaDto();

            Console.WriteLine("----------------------");
            Console.WriteLine("       CITA");
            Console.WriteLine("----------------------");
            Console.WriteLine("Nombre del medico");
            cita.NombreMedicoCita = Console.ReadLine();

            Console.WriteLine("DNI del paciente");
            cita.NombreMedicoCita = Console.ReadLine();

            bool fecha = true;
            do
            {
                try
                {
                    Console.WriteLine("Fecha para la consulat (yyyy/MM/dd hh:mm)");
                    cita.FechaCita = Convert.ToDateTime(Console.ReadLine());
                    fecha = false;
                }
                catch
                {

                    Console.WriteLine("La fecha introducida no es valida");
                    fecha = true;

                }


            } while (fecha);

            cita.IdCita = calcularIdCita();



            return cita;
        }

        private int calcularIdCita()
        {

            int id = 1;

            for (int i = 1; i < 100; i++)
            {
                foreach (var cita in Controladores.Program.listaCitas)
                {

                    if (i == cita.IdCita)
                    {

                    }
                    else
                    {
                        id = i;
                        i = 100;
                        break;
                    }

                }
            }

            return id;
        }
    }
}
