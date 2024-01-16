using GraphQL.Types;

namespace GraphqlProject.Type
{
    public class MenuInputType:InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<DecimalGraphType>("price");
            Field<StringGraphType>("imageUrl");
            Field<IntGraphType>("categoryId");
        }
    }
}
