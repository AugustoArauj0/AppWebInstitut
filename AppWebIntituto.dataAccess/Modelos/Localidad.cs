using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWebInstitut.DataAccess.Modelos
{
    public class Localidad
    {
        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int LocalidadId { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public string? NombreLocalidad { get; set; }

        [StringLength(5, ErrorMessage = "El largo máximo es de 5 caracteres")]
        [RegularExpression("[A-Z]{1})([0-9]{4})$")]
        public string? CodigoPostal { get; set; }

        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        [DataType(DataType.Text)]
        public int ProvinciaId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMMM/yyyy}")]
        public DateTime FechaActualizacion { get; set; }

    }
}
