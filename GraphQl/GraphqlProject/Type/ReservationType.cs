using GraphQL.Types;
using GraphqlProject.Models;

namespace GraphqlProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(r => r.Id);
            Field(r => r.CustomerName);
            Field(r => r.Email);
            Field(r => r.PhoneNumber);
            Field(r => r.SpecialRequest);
            Field(r => r.PartySize);
            Field(r => r.ReservationDate);
        }
    }
}
