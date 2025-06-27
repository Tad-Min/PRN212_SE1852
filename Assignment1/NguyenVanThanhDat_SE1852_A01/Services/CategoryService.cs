using BusinessObjects;
using Repositories;

namespace Services
{
    public class CategoryService : ICategorieService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public void InitializeDataset()
        {
            _categoryRepository.InitializeDataset();
        }

        public Category? GetCategoryById(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }

        public bool SaveCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                return false;
            }

            return _categoryRepository.SaveCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                return false;
            }

            return _categoryRepository.UpdateCategory(category);
        }

        public bool DeleteCategory(int id)
        {
            return _categoryRepository.DeleteCategory(id);
        }

        public List<Category> SearchCategories(string keyword)
        {
            return _categoryRepository.SearchCategories(keyword);
        }
    }
}
