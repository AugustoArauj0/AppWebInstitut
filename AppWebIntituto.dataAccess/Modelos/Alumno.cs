using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Alumno
    {
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public int AlumnoId { get; set; }
        public string? Apellido { get; set; }
        public string? Nombre { get; set; } = null!; 
        public string? NumeroDocumento { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")] 
        public DateTime FechaNacimiento { get; set; }
        public Domicilio? Domicilio { get; set; } 
        public int ProvinciaId { get; set; } 
        public int LocalidadId { get; set; } 
        public string? NumeroTelefono { get; set; }
        public string? NumeroCelular { get; set; }
        public string? EMail { get; set; }
        public int NumeroLegajo { get; set; }
        public bool Eliminado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string NombreCompleto()
        {
            return Apellido + ", " + Nombre;
        }
        public string Documento()
        {
            return NumeroDocumento;
        }
        public DateTime Nacimiento()
        {
            return FechaNacimiento;
        }
        public string NroTel()
        {
            return NumeroTelefono;
        }
        public string NroCel()
        {
            return NumeroCelular;
        }
        public string Mail()
        {
            return EMail;
        }
        public int NroLegajo()
        {
            return NumeroLegajo;
        }
        public bool estado()
        {
            return Eliminado;
        }
        public DateTime Date()
        {
            return FechaActualizacion;
        }
    }
}
