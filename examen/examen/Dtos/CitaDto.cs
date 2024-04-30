using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Dtos
{
    internal class CitaDto
    {

        int idCita;
        int dniPacienteCita;
        string nombrePacienteCita ="aaaaaaaa";
        string nombreMedicoCita = "aaaaaaaa";
        DateTime fechaCita;
        int consultCita = 9999;

        public CitaDto() { 
        
        }

        public CitaDto(int idCita, int dniPacienteCita, string nombrePacienteCita, string nombreMedicoCita, DateTime fechaCita, int consultCita)
        {
            this.IdCita = idCita;
            this.DniPacienteCita = dniPacienteCita;
            this.NombrePacienteCita = nombrePacienteCita;
            this.NombreMedicoCita = nombreMedicoCita;
            this.FechaCita = fechaCita;
            this.ConsultCita = consultCita;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public int DniPacienteCita { get => dniPacienteCita; set => dniPacienteCita = value; }
        public string NombrePacienteCita { get => nombrePacienteCita; set => nombrePacienteCita = value; }
        public string NombreMedicoCita { get => nombreMedicoCita; set => nombreMedicoCita = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public int ConsultCita { get => consultCita; set => consultCita = value; }

        override
        public String ToString()
        {
            return "";  
        }
    }
}
