using Jungle_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository.IRepository
{
    public interface IReservationRepository : IRepository<Reservation>
    {

       void Update(Reservation reservation);
       bool VerificationDateDepart(DateTime dateDepart);
       bool ValidationRabais(DateTime dateDepart);
       bool ValidationPlacesDisponibles(int placesAReserver, Travel travelID);
       double CalculePrixFinal(int placesAReserver, Travel travel);
       void ValidationStatutConfirme(int placesAReserver, Travel travel);
        void insertOption(List<Option> options, Reservation reservation);
    }
}
