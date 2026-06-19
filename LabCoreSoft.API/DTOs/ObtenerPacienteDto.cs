namespace LabCoreSoft.API.DTOs
{
    public class ObtenerPacienteDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos { get; set; }
        public int IdTipoDocumento { get; set; }
        public string DocumentoNombre { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdCiudad { get; set; }
        public string CiudadNombre { get; set; }
    }
}
