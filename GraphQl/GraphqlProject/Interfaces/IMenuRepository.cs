using GraphqlProject.Models;

namespace GraphqlProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu AddMenuItem(Menu menu);
        Menu UpdateMenu(int menuId, Menu menu);
        void DeleteMenu(int menuId);
    }
}
