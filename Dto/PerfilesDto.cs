using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RedSocialFace.Dto;
using RedSocialFace.DaraAcces;

namespace RedSocialFace.Dto
{
    public class PerfilesDto
    {
        [Key]
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Codigo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string nombre { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string apellido { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string gmail { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string ciudad { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string pais { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string descripcion { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}
