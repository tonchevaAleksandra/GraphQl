using GraphQL.Types;

namespace GraphqlProject.Type
{
    public class ReservationInputType:InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("phoneNumber");
            Field<StringGraphType>("specialRequest");
            Field<IntGraphType>("partySize");
            Field<DateGraphType>("reservationDate");
        }
    }
}
