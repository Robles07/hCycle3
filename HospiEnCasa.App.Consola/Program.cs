using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //IndexPacientes();
            //DeletePaciente();
            //IndexPacientes();
            //DeletePacienteAddMedico();
            //IndexPacientesIndexMedicos();
            //DeleteMedico();
            //IndexMedicos();
            AsignarMedico();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "NoSabe",//"Juanita",//"Pepito",
                Apellidos = "NoResponde",//"Gomez",//Perez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void IndexPacientes()
        {
            foreach (var paciente in _repoPaciente.GetAllPacientes())
            {
                Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
            }
        }
        private static void IndexMedicos()
        {
            foreach (var medico in _repoMedico.GetAllMedicos())
            {
                Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
            }
        }
        private static void DeletePaciente()
        {
            _repoPaciente.DeletePaciente(2);
        }
        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Prueba",//"Prueba",//"Elkin",//"Juanita",
                Apellidos = "Dos",//"Uno",//"Patarroyo",//Gomez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,//Genero.femenino,
                Especialidad = "Cientifico",//Internista",
                Codigo = "123456",
                RegistroRethus = "ABC123",
            };
            _repoMedico.AddMedico(medico);
        }
        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(4, 6);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }
        private static void DeleteMedico()
        {
            _repoMedico.DeleteMedico(5);
        }
    }
}

