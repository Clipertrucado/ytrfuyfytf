using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Dtos
{
    internal class PacienteDto
    {

        int idPaciente;
        string dniPaciente = "aaaaaaa";
        string nombrePaciente = "aaaaaaa";
        DateTime fechaNacimientoPaciente;


        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public DateTime FechaNacimientoPaciente { get => fechaNacimientoPaciente; set => fechaNacimientoPaciente = value; }

        public PacienteDto(int idPaciente, string dniPaciente, string nombrePaciente, DateTime fechaNacimientoPaciente)
        {
            this.idPaciente = idPaciente;
            this.dniPaciente = dniPaciente;
            this.nombrePaciente = nombrePaciente;
            this.fechaNacimientoPaciente = fechaNacimientoPaciente;
        }

        public PacienteDto()
        {


        }

        override
        public String ToString()
        { 
            return  "ID: "+idPaciente+
                    "\nDNI: "+dniPaciente+
                    "\nNombre: "+nombrePaciente+
                    "\nFecha naci: "+ fechaNacimientoPaciente.ToString();
        }

    }
}
