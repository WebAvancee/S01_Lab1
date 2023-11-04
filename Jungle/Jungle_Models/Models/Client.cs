using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Client
    {
        [Key]
        [Column("ClientID")]
        public int ClientId { get; set; }
        [StringLength(50)]
        public string Prenom { get; set; } = null!;
        [StringLength(50)]
        public string Nom { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string NoTelephone1 { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string NoTelephone2 { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateNaissance { get; set; }
        [StringLength(100)]
        public string Adresse { get; set; } = null!;
        [StringLength(50)]
        public string Ville { get; set; } = null!;
        [StringLength(16)]
        public string CodePostal { get; set; } = null!;
        [StringLength(2)]
        [Unicode(false)]
        public string Province { get; set; } = null!;
        [StringLength(100)]
        public string Courriel { get; set; } = null!;
        [StringLength(16)]
        public string NoCarteCredit { get; set; } = null!;
        public int LimiteCredit { get; set; }

        public List<Reservation> Reservations { get; set; }
        
    }
}
