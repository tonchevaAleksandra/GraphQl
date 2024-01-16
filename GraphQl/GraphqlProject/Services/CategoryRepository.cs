using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Services
{
    public class CategoryRepository(GraphQLDbContext dbContext) : ICategoryRepository
    {
        private GraphQLDbContext dbContext = dbContext;
        public Category AddCategory(Category category)
        {
            ArgumentNullException.ThrowIfNull(category);
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var category = dbContext.Categories.Find(id) ?? throw new InvalidOperationException($"Category with Id {id} doesn't exist.");
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return dbContext.Categories.ToList();
        }

        public Category UpdateCategory(int categoryId, Category category)
        {
            ArgumentNullException.ThrowIfNull(category);

            if (dbContext.Categories.Any(x => x.Id == categoryId))
            {
                var categoryResult = dbContext.Categories.Find(categoryId);
                categoryResult.Name = category.Name;
                categoryResult.Menus = category.Menus;
                categoryResult.ImageUrl = category.ImageUrl;
            }

            dbContext.SaveChanges();
            return category;
        }
    }
}
