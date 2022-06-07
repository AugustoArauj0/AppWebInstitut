using System.ComponentModel.DataAnnotations;

namespace AppWebInstitut.DataAccess.Modelos
{
    public class Domicilio
    {
        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int DomicilioId { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public string? Calle { get; set; }

        [StringLength(4, ErrorMessage = "El largo máximo es de 4 caracteres")]
        [RegularExpression("([0-9]+)")]
        public int Numero { get; set; }

        [StringLength(3, ErrorMessage = "El largo máximo es de 3 caracteres")]
        [RegularExpression("([0-9]+)")]
        public int Piso { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public string? Departamento { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public string? Barrio { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public string? Manzana { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int Casa { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaActualizacion { get; set; }

    }
}
