using GraphqlProject.Query;

namespace GraphqlProject.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(MenuQuery menuQuery)
        {
            Query = menuQuery;
        }
    }
}
