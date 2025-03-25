using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialFace.DaraAcces
{
    [Table("Amigo")]
    public class Amigo
    {
        [Key]
        [Column("CodigoAmigo", TypeName = "nvarchar(50)")]
        public string CodigoAmigo { get; set; }

        [Column("seguir", TypeName = "nvarchar(10)")]
        public string Seguir { get; set; }

        // Relación con Usuarios
        // Asumiendo que 'Usuarios' se identifica por 'identificacion'
        // y que 'Amigo' hace referencia al usuario que se está siguiendo
        [Column("identificacion", TypeName = "nvarchar(50)")]
        public string Identificacion { get; set; }
        public virtual Usuario Usuario { get; set; }

        // Un Amigo puede tener varios Chats
        public virtual ICollection<Chat> Chats { get; set; }
    }
}
