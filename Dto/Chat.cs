using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialFace.Dto
{
    [Table("Chat")]
    public class Chat
    {
        [Key]
        [Column("codigoChat")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoChat { get; set; }

        [Column("chat", TypeName = "nvarchar(350)")]
        [Required]
        public string Mensaje { get; set; }

        [Column("CodigoAmigo", TypeName = "nchar(10)")]
        public string CodigoAmigo { get; set; }

        // Relación con Amigo: muchos Chats pueden pertenecer a un Amigo
    }
}
