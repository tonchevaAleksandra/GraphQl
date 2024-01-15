using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Services
{
    public class MenuRepository : IMenuRepository
    {
        private static List<Menu> MenuList = new List<Menu>()
        {
            new Menu{ Id = 1, Name = "1", Description = "1", Price = 1.0M},
            new Menu{ Id = 2, Name = "2", Description = "2", Price = 2.0M},
            new Menu{ Id = 3, Name = "3", Description = "3", Price = 3.0M},
            new Menu{ Id = 4, Name = "4", Description = "4", Price = 4.0M},
            new Menu{ Id = 5, Name = "5", Description = "5", Price = 5.0M},
        };
        public Menu AddMenuItem(Menu menu)
        {
            if (menu == null) throw new ArgumentNullException("Menu couldn't be null.");
            if (!MenuList.Any(x => x.Id == menu.Id))
                MenuList.Add(menu);
            return menu;
        }

        public void DeleteMenu(int menuId)
        {
            MenuList.RemoveAt(menuId);
        }

        public List<Menu> GetAllMenus()
        {
            return MenuList;
        }

        public Menu GetMenuById(int id)
        {
            return MenuList.Find(x => x.Id == id);
        }

        public Menu UpdateMenu(int menuId, Menu menu)
        {
            if (menu == null) throw new ArgumentNullException("Menu couldn't be null.");
            if (MenuList.Any(x => x.Id == menu.Id))
                MenuList[menuId] = menu;
            return menu;
        }
    }
}
