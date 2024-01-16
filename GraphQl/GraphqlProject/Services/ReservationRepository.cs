using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Services
{
    public class ReservationRepository(GraphQLDbContext dbContext) : IReservationRepository
    {
        private GraphQLDbContext dbContext = dbContext;

        public Reservation AddReservation(Reservation reservation)
        {
            ArgumentNullException.ThrowIfNull(reservation);
            if (!dbContext.Reservations.Any(x => x.Id == reservation.Id))
                dbContext.Reservations.Add(reservation);

            dbContext.SaveChanges();
            return reservation;
        }

        public void DeleteReservation(int id)
        {
            var reservation = dbContext.Reservations.Find(id) ?? throw new InvalidOperationException($"Reservation with id {id} doesn't exist.");
            dbContext.Reservations.Remove(reservation);
            dbContext.SaveChanges();
        }

        public List<Reservation> GetReservations()
        {
            return dbContext.Reservations.ToList();
        }

        public Reservation UpdateReservation(int reservationId, Reservation reservation)
        {
            ArgumentNullException.ThrowIfNull(reservation);

            if (dbContext.Reservations.Any(x => x.Id == reservationId))
            {
                var reservationResult = dbContext.Reservations.Find(reservationId);
                reservationResult.CustomerName = reservation.CustomerName;
                reservationResult.Email = reservation.Email;
                reservationResult.PhoneNumber = reservation.PhoneNumber;
                reservationResult.PartySize = reservation.PartySize;
                reservationResult.ReservationDate = reservation.ReservationDate;
            }

            dbContext.SaveChanges();
            return reservation;
        }
    }
}
