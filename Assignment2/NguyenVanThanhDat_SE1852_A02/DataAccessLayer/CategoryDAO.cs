using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        private readonly LucySalesDataContext _context;
        
        public CategoryDAO()
        {
            _context = new LucySalesDataContext();
        }
        public CategoryDAO(LucySalesDataContext context)
        {
            _context = context;
        }

        public async Task<List<Category>?> GetAllCategories()
        {
            try
            {
                return await _context.Categories.OrderBy(x => x.CategoryId).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetAllCategories Detail: "+ex.Message);
            }
        }

    }
}
