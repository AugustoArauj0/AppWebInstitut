using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Alumno
    {
        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int AlumnoId { get; set; }

        [StringLength(15, ErrorMessage = "El largo máximo es de 15 caracteres")]
        [DataType(DataType.Text)]
        public string? Apellido { get; set; }

        [StringLength(15, ErrorMessage = "El largo máximo es de 15 caracteres")]
        [DataType(DataType.Text)]
        public string? Nombre { get; set; } = null!;

        [StringLength(11, ErrorMessage = "El largo máximo es de 9 caracteres, evite ingresar puntos")]
        [RegularExpression("^[0-9]{1,3}[0-9]{3,3}[0-9]{3,3}$")]
        public string? NumeroDocumento { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public Domicilio? Domicilio { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int ProvinciaId { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int LocalidadId { get; set; }

        [StringLength(15, ErrorMessage = "El largo máximo es de 15 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string? NumeroTelefono { get; set; }

        [StringLength(17, ErrorMessage = "El largo máximo es de 17 caracteres")]
        [RegularExpression(@"^(\+)[0-9]{7,16}$")]
        public string? NumeroCelular { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$")]
        public string? EMail { get; set; }

        [StringLength(12, ErrorMessage = "El largo máximo es de 12 caracteres")]
        [RegularExpression(@"([A-Za-z])\w+")]
        public int NumeroLegajo { get; set; }

        [RegularExpression("([0-1]+)")]
        public bool Eliminado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaActualizacion { get; set; }

        public string NombreCompleto()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
