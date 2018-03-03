using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.Seguros.Entities
{
    [Table("Clientes")]
    public class Cliente
    {

        [Key]
        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "@El campo es requerido")]
        [MaxLength(200)]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 1)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "@El campo es requerido")]
        [MaxLength(50)]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 2)]
        public string Identificacion { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("Cliente")]
        public virtual ICollection<Poliza> Polizas
        {
            get;
            set;
        }
    }
}
