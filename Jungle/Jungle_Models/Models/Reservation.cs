using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Reservation
    {
        [Key]
        [Column("ReservationID")]
        public int ReservationId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateReservation { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateDepart { get; set; }

        public int PourcentageRabais { get; set; }

        public int NombrePlaces { get; set; }

        public double PrixFinal { get; set; }

        public bool StatusConfirme { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Travel")]
        public int Id { get; set; }
        public Travel Travel { get; set; }

    }
}
