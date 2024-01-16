﻿using GraphQL.Types;

namespace GraphqlProject.Query
{
    public class RootQuery:ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery").Resolve(context=> new());
            Field<CategoryQuery>("categoryQuery").Resolve(context=> new());
            Field<ReservationQuery>("reservationQuery").Resolve(context=> new());
        }
    }
}
