using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public Category(int catID, string catName)
        {
            this.CategoryID = catID;
            this.CategoryName = catName;
        }

        public int CategoryID {get;set;} 
        public string CategoryName {get;set;}
        public virtual ICollection<Product> Products {get;set;}
    }
}
