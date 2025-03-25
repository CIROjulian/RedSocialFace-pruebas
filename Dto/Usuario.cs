using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedSocialFace.DaraAcces
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Column("identificacion", TypeName = "nvarchar(50)")]
        public string identificacion { get; set; }

        [Column("gmail", TypeName = "nvarchar(50)")]
        [Required]
        public string gmail { get; set; }

        [Column("contraseña", TypeName = "nvarchar(50)")]
        [Required]
        public string contraseña { get; set; }

        [Column("CodigoPerfil", TypeName = "nvarchar(50)")]
        public string CodigoPerfil { get; set; }
    }
}
