using GraphqlProject.Models;

namespace GraphqlProject.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(int reservationId, Reservation reservation);
        void DeleteReservation(int id);
    }
}
