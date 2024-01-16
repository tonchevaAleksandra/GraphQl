using GraphQL.Types;

namespace GraphqlProject.Type
{
    public class CategoryInputType :InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
            //Field<ListGraphType<MenuInputType>> ("menus");
        }
    }
}
