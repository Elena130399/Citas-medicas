using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); //metodo que retorna todos los pacientes
        Paciente AddPaciente(Paciente paciente);
        IRepositorioPaciente UpdatePaciente(IRepositorioPaciente paciente)
        void DeletePaciente(int idPaciente);
        IRepositorioPaciente GetPaciente(int idPaciente);
    }
}
//Interfaz: Conjunto de métodos-encabe
