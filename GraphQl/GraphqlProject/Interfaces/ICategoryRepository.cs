using GraphqlProject.Models;

namespace GraphqlProject.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(int categoryId, Category category);
        void DeleteCategory(int id);
    }
}
