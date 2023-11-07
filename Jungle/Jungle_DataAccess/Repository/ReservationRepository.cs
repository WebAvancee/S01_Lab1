using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;
using Microsoft.AspNetCore.Mvc;
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

       
        public bool ValidationPlacesDisponibles(int placesAReserver, Travel travel)
        {                                            
            IEnumerable<Reservation> reservations = _db.Reservations.Where(r => r.Id == travel.Id && r.StatusConfirme == true).ToList();    

            int placesReservees = reservations.Sum(r => r.NombrePlaces);

           int placesDisponibles = travel.NombrePlacesMinimun - placesReservees; //

            if (placesDisponibles >= placesAReserver)
            {
                return true;
            }

            return false;

        }


        public double CalculePrixFinal (int placesAReserver, Travel travel)
        {

            double prixFinal = 0;
            if (placesAReserver <= 0 || travel.Id <= 0)
                return 0;                     

            if (placesAReserver == 1)
            {
                prixFinal = travel.Price;

            }
            if (placesAReserver > 1)
            {
                prixFinal = travel.Price*(1 + (placesAReserver-1)*0.8) ;

            }

            return prixFinal;
        }

        public void ValidationStatutConfirme(int placesAReserver, Travel travel) 
        {
            
            IEnumerable<Reservation> reservations = _db.Reservations.Where(r => r.Id == travel.Id && r.StatusConfirme == true).ToList();

            int placesReservees = reservations.Sum(r => r.NombrePlaces);

            int placesDisponibles = travel.NombrePlacesMinimun - placesReservees;

            if(placesDisponibles == placesAReserver)
            {
                var travelAModifier = _db.Travels.FirstOrDefault(t => t.Id == travel.Id);

                if (travelAModifier != null)
                {
                    travelAModifier.StatusConfirme = true;
                    _db.SaveChanges();
                }
            }
             
        }

        public void insertOption(List<Option> options,Reservation reservation ) 
        {

            if (options.Count <= 3)
            { 
                foreach (Option option in options) 
                {
                   // crear una tabla optionReservation 1 reservation tiene varias opciones max 3
                }
            }
               
            throw new NotImplementedException();
            
        }


    }
}
