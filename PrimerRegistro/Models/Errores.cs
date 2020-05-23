using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerRegistro.Models
{
    public class Errores
    {
        [Key]
        public int ErrorId { get; set; }

        [Required(ErrorMessage ="El campo Hallazgo es obligatorio")]
        public string Hallazgo { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")] 
        public string Ruta { get; set; }

        [Range(minimum:1, maximum:10)]
        public int Importancia { get; set; }

        public DateTime Fecha { get; set; }



    }
}
