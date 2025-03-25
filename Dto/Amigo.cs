using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialFace.Dto
{
    internal class Amigo
    {
        [Key]
        [Column("CodigoAmigo", TypeName = "nvarchar(10)")]
        public string CodigoAmigo { get; set; }

        [Column("seguir", TypeName = "nvarchar(10)")]
        [Required]
        public string Seguir { get; set; }

        // Relación con Chat: un Amigo puede tener muchos Chats
        public virtual ICollection<Chat> Chats { get; set; }
    }
}
