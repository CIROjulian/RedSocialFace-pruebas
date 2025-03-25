using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialFace.DaraAcces
{
    [Table("Chat")]
    public class Chat
    {
        [Key]
        [Column("codigoChat")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoChat { get; set; }

        [Column("chat", TypeName = "nvarchar(350)")]
        public string Mensaje { get; set; }

        // Relación con Amigo
        [Column("CodigoAmigo", TypeName = "nvarchar(50)")]
        public string CodigoAmigo { get; set; }
        public virtual Amigo Amigo { get; set; }

        // Relación con Usuarios (si tu diagrama indica que Chat también
        // referencia a un Usuario)
        [Column("identificacion", TypeName = "nvarchar(50)")]
        public string Identificacion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}