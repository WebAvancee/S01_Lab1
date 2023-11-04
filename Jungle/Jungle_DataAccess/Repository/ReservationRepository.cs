using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {

        private readonly JungleDbContext _db;

        public ReservationRepository(JungleDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Reservation reservation)
        {
            _db.Update(reservation);
        }


        public bool VerificationDateDepart(DateTime dateDepart)
        {
            if(dateDepart <= DateTime.Today) 
            {
                return false;
            
            }

            return true;
        }

        public bool ValidationRabais (DateTime dateDepart) 
        {
        
            if(dateDepart < (DateTime.Today).AddDays(14))
            { 
                return true; 
            
            }

            return false;

        }

       
        public bool ValidationPlacesDisponibles(int placesAReserver, int travelID)
        {
             
                Travel travel = _db.Travels.Where(t => t.Id == travelID).FirstOrDefault();
                
            IEnumerable<Reservation> reservations = _db.Reservations.Where(r => r.Id == travelID && r.StatusConfirme == true).ToList();    

            int placesReservees = reservations.Sum(r => r.NombrePlaces);

            int placesDisponibles = travel.NombrePlaces - placesReservees; 
            
            if(placesDisponibles >= placesAReserver)
            {
                return true;
            }

            return false;

        }


        public double CalculePrixFinal (int placesAReserver, int travelID)
        {

            double prixFinal = 0;

            Travel travel = _db.Travels.Where(t => t.Id == travelID).FirstOrDefault();

            if (placesAReserver == 1)
            {
               // prixFinal = placesAReserver*0

            }


            return 0;
        }




    }
}
