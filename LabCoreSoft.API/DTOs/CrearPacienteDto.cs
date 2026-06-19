namespace LabCoreSoft.API.DTOs
{
    public class CrearPacienteDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdCiudad { get; set; }
    }
}
