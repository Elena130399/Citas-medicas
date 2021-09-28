using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); //metodo que retorna todos los pacientes
        Paciente AddPaciente(Paciente paciente);
<<<<<<< HEAD
        IRepositorioPaciente UpdatePaciente(IRepositorioPaciente paciente);
        void DeletePaciente(int idPaciente);
        IRepositorioPaciente GetPaciente(int idPaciente);
=======
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
>>>>>>> 8b331db5f3de762e9e9546d0efc251406e435797
    }
}
//Interfaz: Conjunto de métodos-encabe
