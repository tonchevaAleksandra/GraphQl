using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using GraphqlProject.Type;

namespace GraphqlProject.Query
{
    public class MenuQuery: ObjectGraphType
    {
        public MenuQuery(IMenuRepository menuRepository)
        {
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenus();
            });
            Field<MenuType>("Menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                return menuRepository.GetMenuById(context.GetArgument<int>("menuId"));
            });
            Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" }, new QueryArgument<MenuType> { Name = "menu" })).Resolve(context =>
            {
                return menuRepository.UpdateMenu(context.GetArgument<int>("menuId"), context.GetArgument<Menu>("menu"));
            });
        }
    }
}
