using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO categoryDAO = new CategoryDAO();

        public List<Category> GetAllCategories()
        {
            return categoryDAO.GetAllCategories();
        }

        public void InitializeDataset()
        {
            categoryDAO.InitializeDataset();
        }

        public Category? GetCategoryById(int id)
        {
            return categoryDAO.GetCategoryById(id);
        }

        public bool SaveCategory(Category category)
        {
            return categoryDAO.SaveCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            return categoryDAO.UpdateCategory(category);
        }

        public bool DeleteCategory(int id)
        {
            return categoryDAO.DeleteCategory(id);
        }

        public List<Category> SearchCategories(string keyword)
        {
            return categoryDAO.SearchCategories(keyword);
        }
    }
}
