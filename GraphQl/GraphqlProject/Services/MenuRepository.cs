using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Services
{
    public class MenuRepository(GraphQLDbContext dbContext) : IMenuRepository
    {
        private GraphQLDbContext dbContext = dbContext;

        public Menu AddMenuItem(Menu menu)
        {
            ArgumentNullException.ThrowIfNull(menu);
            if (!dbContext.Menus.Any(x => x.Id == menu.Id))
                dbContext.Menus.Add(menu);

            dbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int menuId)
        {
            var menu = dbContext.Menus.Find(menuId) ?? throw new InvalidOperationException($"Menu with id {menuId} doesn't exist.");
            dbContext.Menus.Remove(menu);
            dbContext.SaveChanges();
        }

        public List<Menu> GetAllMenus()
        {
            return dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return dbContext.Menus.Find(id) ?? throw new InvalidOperationException($"Menu with Id {id} doesn't exist.");
        }

        public Menu UpdateMenu(int menuId, Menu menu)
        {
            ArgumentNullException.ThrowIfNull(menu);

            if (dbContext.Menus.Any(x => x.Id == menuId))
            {
                var menuResult = dbContext.Menus.Find(menuId);
                menuResult.Name = menu.Name;
                menuResult.Description = menu.Description;
                menuResult.Price = menu.Price;
            }

            dbContext.SaveChanges();
            return menu;
        }
    }
}
