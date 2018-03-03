using GAP.Seguros.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.Seguros.Entities
{
    [Table("Polizas")]
    public class Poliza
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
        [MaxLength(200)]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 2)]
        public string Descripción { get; set; }

        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 3)]
        public int TipoCubrimientoId { get; set; }


        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal", Order = 4)]
        public decimal Cobertura { get; set; }



        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "datetime", Order = 5)]
        public DateTime Vigencia { get; set; }


        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 6)]
        public int Periodo { get; set; }


        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal", Order = 7)]
        public decimal Precio { get; set; }


        [Required(ErrorMessage = "@El campo es requerido")]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 8)]
        public RiesgosEnum Riesgo { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("TipoCubrimientoId")]

        public virtual TipoCubrimiento TipoCubrimiento { get; set; }
    }
}
