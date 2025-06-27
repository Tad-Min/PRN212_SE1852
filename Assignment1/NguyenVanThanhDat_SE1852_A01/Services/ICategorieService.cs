using BusinessObjects;

namespace Services
{
    public interface ICategorieService
    {
        public List<Category> GetAllCategories();
        public void InitializeDataset();
        public Category? GetCategoryById(int id);
        public bool SaveCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int id);
        public List<Category> SearchCategories(string keyword);
    }
}
