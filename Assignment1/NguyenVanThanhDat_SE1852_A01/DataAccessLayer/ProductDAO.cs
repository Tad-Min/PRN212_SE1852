using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();

        public void InitializeDataset()
        {
            if (products.Count > 0) return;
            products.Add(new Product { ProductId = 1, ProductName = "Chai", CategoryId = 1, UnitPrice = 18.00, UnitsInStock = 39 });
            products.Add(new Product { ProductId = 2, ProductName = "Chang", CategoryId = 1, UnitPrice = 19.00, UnitsInStock = 17 });
            products.Add(new Product { ProductId = 3, ProductName = "Aniseed Syrup", CategoryId = 2, UnitPrice = 10.00, UnitsInStock = 13 });
            products.Add(new Product { ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", CategoryId = 2, UnitPrice = 22.00, UnitsInStock = 53 });
            products.Add(new Product { ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", CategoryId = 2, UnitPrice = 21.35, UnitsInStock = 0 });
            products.Add(new Product { ProductId = 6, ProductName = "Grandma's Boysenberry Spread", CategoryId = 2, UnitPrice = 25.00, UnitsInStock = 120 });
            products.Add(new Product { ProductId = 7, ProductName = "Uncle Bob's Organic Dried Pears", CategoryId = 7, UnitPrice = 30.00, UnitsInStock = 15 });
            products.Add(new Product { ProductId = 8, ProductName = "Northwoods Cranberry Sauce", CategoryId = 2, UnitPrice = 40.00, UnitsInStock = 6 });
            products.Add(new Product { ProductId = 9, ProductName = "Mishi Kobe Niku", CategoryId = 6, UnitPrice = 97.00, UnitsInStock = 29 });
            products.Add(new Product { ProductId = 10, ProductName = "Ikura", CategoryId = 8, UnitPrice = 31.00, UnitsInStock = 31 });
            products.Add(new Product { ProductId = 11, ProductName = "Queso Cabrales", CategoryId = 4, UnitPrice = 21.00, UnitsInStock = 22 });
            products.Add(new Product { ProductId = 12, ProductName = "Queso Manchego La Pastora", CategoryId = 4, UnitPrice = 38.00, UnitsInStock = 86 });
            products.Add(new Product { ProductId = 13, ProductName = "Konbu", CategoryId = 8, UnitPrice = 6.00, UnitsInStock = 24 });
            products.Add(new Product { ProductId = 14, ProductName = "Tofu", CategoryId = 7, UnitPrice = 23.25, UnitsInStock = 35 });
            products.Add(new Product { ProductId = 15, ProductName = "Genen Shouyu", CategoryId = 2, UnitPrice = 15.50, UnitsInStock = 39 });
            products.Add(new Product { ProductId = 16, ProductName = "Pavlova", CategoryId = 3, UnitPrice = 17.45, UnitsInStock = 29 });
            products.Add(new Product { ProductId = 17, ProductName = "Alice Mutton", CategoryId = 6, UnitPrice = 39.00, UnitsInStock = 0 });
            products.Add(new Product { ProductId = 18, ProductName = "Carnarvon Tigers", CategoryId = 8, UnitPrice = 62.50, UnitsInStock = 42 });
            products.Add(new Product { ProductId = 19, ProductName = "Teatime Chocolate Biscuits", CategoryId = 3, UnitPrice = 9.20, UnitsInStock = 25 });
            products.Add(new Product { ProductId = 20, ProductName = "Sir Rodney's Marmalade", CategoryId = 3, UnitPrice = 81.00, UnitsInStock = 40 });
            products.Add(new Product { ProductId = 21, ProductName = "Sir Rodney's Scones", CategoryId = 3, UnitPrice = 10.00, UnitsInStock = 3 });
            products.Add(new Product { ProductId = 22, ProductName = "Gustaf's Knäckebröd", CategoryId = 5, UnitPrice = 21.00, UnitsInStock = 104 });
            products.Add(new Product { ProductId = 23, ProductName = "Tunnbröd", CategoryId = 5, UnitPrice = 9.00, UnitsInStock = 61 });
            products.Add(new Product { ProductId = 24, ProductName = "Guaraná Fantástica", CategoryId = 1, UnitPrice = 4.50, UnitsInStock = 20 });
            products.Add(new Product { ProductId = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", CategoryId = 3, UnitPrice = 14.00, UnitsInStock = 76 });
            products.Add(new Product { ProductId = 26, ProductName = "Gumbär Gummibärchen", CategoryId = 3, UnitPrice = 31.23, UnitsInStock = 15 });
            products.Add(new Product { ProductId = 27, ProductName = "Schoggi Schokolade", CategoryId = 3, UnitPrice = 43.90, UnitsInStock = 49 });
            products.Add(new Product { ProductId = 28, ProductName = "Rössle Sauerkraut", CategoryId = 7, UnitPrice = 45.60, UnitsInStock = 26 });
            products.Add(new Product { ProductId = 29, ProductName = "Thüringer Rostbratwurst", CategoryId = 6, UnitPrice = 123.79, UnitsInStock = 0 });
            products.Add(new Product { ProductId = 30, ProductName = "Nord-Ost Matjeshering", CategoryId = 8, UnitPrice = 25.89, UnitsInStock = 10 });
            products.Add(new Product { ProductId = 31, ProductName = "Gorgonzola Telino", CategoryId = 4, UnitPrice = 12.50, UnitsInStock = 0 });
            products.Add(new Product { ProductId = 32, ProductName = "Mascarpone Fabioli", CategoryId = 4, UnitPrice = 32.00, UnitsInStock = 9 });
            products.Add(new Product { ProductId = 33, ProductName = "Geitost", CategoryId = 4, UnitPrice = 2.50, UnitsInStock = 112 });
            products.Add(new Product { ProductId = 34, ProductName = "Sasquatch Ale", CategoryId = 1, UnitPrice = 14.00, UnitsInStock = 111 });
            products.Add(new Product { ProductId = 35, ProductName = "Steeleye Stout", CategoryId = 1, UnitPrice = 18.00, UnitsInStock = 20 });
            products.Add(new Product { ProductId = 36, ProductName = "Inlagd Sill", CategoryId = 8, UnitPrice = 19.00, UnitsInStock = 112 });
            products.Add(new Product { ProductId = 37, ProductName = "Gravad lax", CategoryId = 8, UnitPrice = 26.00, UnitsInStock = 11 });
            products.Add(new Product { ProductId = 38, ProductName = "Côte de Blaye", CategoryId = 1, UnitPrice = 263.50, UnitsInStock = 17 });
            products.Add(new Product { ProductId = 39, ProductName = "Chartreuse verte", CategoryId = 1, UnitPrice = 18.00, UnitsInStock = 69 });
            products.Add(new Product { ProductId = 40, ProductName = "Boston Crab Meat", CategoryId = 8, UnitPrice = 18.40, UnitsInStock = 123 });
            products.Add(new Product { ProductId = 41, ProductName = "Jack's New England Clam Chowder", CategoryId = 8, UnitPrice = 9.65, UnitsInStock = 85 });
            products.Add(new Product { ProductId = 42, ProductName = "Singaporean Hokkien Fried Mee", CategoryId = 5, UnitPrice = 14.00, UnitsInStock = 26 });
            products.Add(new Product { ProductId = 43, ProductName = "Ipoh Coffee", CategoryId = 1, UnitPrice = 46.00, UnitsInStock = 17 });
            products.Add(new Product { ProductId = 44, ProductName = "Gula Malacca", CategoryId = 2, UnitPrice = 19.45, UnitsInStock = 27 });
            products.Add(new Product { ProductId = 45, ProductName = "Rogede sild", CategoryId = 8, UnitPrice = 9.50, UnitsInStock = 5 });
            products.Add(new Product { ProductId = 46, ProductName = "Spegesild", CategoryId = 8, UnitPrice = 12.00, UnitsInStock = 95 });
            products.Add(new Product { ProductId = 47, ProductName = "Zaanse koeken", CategoryId = 3, UnitPrice = 9.50, UnitsInStock = 36 });
            products.Add(new Product { ProductId = 48, ProductName = "Chocolade", CategoryId = 3, UnitPrice = 12.75, UnitsInStock = 15 });
            products.Add(new Product { ProductId = 49, ProductName = "Maxilaku", CategoryId = 3, UnitPrice = 20.00, UnitsInStock = 10 });
            products.Add(new Product { ProductId = 50, ProductName = "Valkoinen suklaa", CategoryId = 3, UnitPrice = 16.25, UnitsInStock = 65 });
            products.Add(new Product { ProductId = 51, ProductName = "Manjimup Dried Apples", CategoryId = 7, UnitPrice = 53.00, UnitsInStock = 20 });
            products.Add(new Product { ProductId = 52, ProductName = "Filo Mix", CategoryId = 5, UnitPrice = 7.00, UnitsInStock = 38 });
            products.Add(new Product { ProductId = 53, ProductName = "Perth Pasties", CategoryId = 6, UnitPrice = 32.80, UnitsInStock = 0 });
            products.Add(new Product { ProductId = 54, ProductName = "Tourtière", CategoryId = 6, UnitPrice = 7.45, UnitsInStock = 21 });
            products.Add(new Product { ProductId = 55, ProductName = "Pâté chinois", CategoryId = 6, UnitPrice = 24.00, UnitsInStock = 115 });
            products.Add(new Product { ProductId = 56, ProductName = "Gnocchi di nonna Alice", CategoryId = 5, UnitPrice = 38.00, UnitsInStock = 21 });
            products.Add(new Product { ProductId = 57, ProductName = "Ravioli Angelo", CategoryId = 5, UnitPrice = 19.50, UnitsInStock = 36 });
            products.Add(new Product { ProductId = 58, ProductName = "Escargots de Bourgogne", CategoryId = 8, UnitPrice = 13.25, UnitsInStock = 62 });
            products.Add(new Product { ProductId = 59, ProductName = "Raclette Courdavault", CategoryId = 4, UnitPrice = 55.00, UnitsInStock = 79 });
            products.Add(new Product { ProductId = 60, ProductName = "Camembert Pierrot", CategoryId = 4, UnitPrice = 34.00, UnitsInStock = 19 });
            products.Add(new Product { ProductId = 61, ProductName = "Sirop d'érable", CategoryId = 2, UnitPrice = 28.50, UnitsInStock = 113 });
            products.Add(new Product { ProductId = 62, ProductName = "Tarte au sucre", CategoryId = 3, UnitPrice = 49.30, UnitsInStock = 17 });
            products.Add(new Product { ProductId = 63, ProductName = "Vegie-spread", CategoryId = 2, UnitPrice = 43.90, UnitsInStock = 24 });
            products.Add(new Product { ProductId = 64, ProductName = "Wimmers gute Semmelknödel", CategoryId = 5, UnitPrice = 33.25, UnitsInStock = 22 });
            products.Add(new Product { ProductId = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", CategoryId = 2, UnitPrice = 21.05, UnitsInStock = 76 });
            products.Add(new Product { ProductId = 66, ProductName = "Louisiana Hot Spiced Okra", CategoryId = 2, UnitPrice = 17.00, UnitsInStock = 4 });
            products.Add(new Product { ProductId = 67, ProductName = "Laughing Lumberjack Lager", CategoryId = 1, UnitPrice = 14.00, UnitsInStock = 52 });
            products.Add(new Product { ProductId = 68, ProductName = "Scottish Longbreads", CategoryId = 3, UnitPrice = 12.50, UnitsInStock = 6 });
            products.Add(new Product { ProductId = 69, ProductName = "Gudbrandsdalsost", CategoryId = 4, UnitPrice = 36.00, UnitsInStock = 26 });
            products.Add(new Product { ProductId = 70, ProductName = "Outback Lager", CategoryId = 1, UnitPrice = 15.00, UnitsInStock = 15 });
            products.Add(new Product { ProductId = 71, ProductName = "Flotemysost", CategoryId = 4, UnitPrice = 21.50, UnitsInStock = 26 });
            products.Add(new Product { ProductId = 72, ProductName = "Mozzarella di Giovanni", CategoryId = 4, UnitPrice = 34.80, UnitsInStock = 14 });
            products.Add(new Product { ProductId = 73, ProductName = "Röd Kaviar", CategoryId = 8, UnitPrice = 15.00, UnitsInStock = 101 });
            products.Add(new Product { ProductId = 74, ProductName = "Longlife Tofu", CategoryId = 7, UnitPrice = 10.00, UnitsInStock = 4 });
            products.Add(new Product { ProductId = 75, ProductName = "Rhönbräu Klosterbier", CategoryId = 1, UnitPrice = 7.75, UnitsInStock = 125 });
            products.Add(new Product { ProductId = 76, ProductName = "Lakkalikööri", CategoryId = 1, UnitPrice = 18.00, UnitsInStock = 57 });
            products.Add(new Product { ProductId = 77, ProductName = "Original Frankfurter grüne Soße", CategoryId = 2, UnitPrice = 13.00, UnitsInStock = 32 });
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product? GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.ProductId == id);
        }

        public bool SaveProduct(Product product)
        {
            Product old = products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (old != null)
                return false;
            products.Add(product);
            return true;
        }

        public bool UpdateProduct(Product product)
        {
            Product old = products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (old == null)
                return false;
            old.ProductName = product.ProductName;
            old.CategoryId = product.CategoryId;
            old.UnitPrice = product.UnitPrice;
            old.UnitsInStock = product.UnitsInStock;
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product old = products.FirstOrDefault(x => x.ProductId == id);
            if (old == null)
                return false;
            products.Remove(old);
            return true;
        }

        public List<Product> SearchProducts(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllProducts();
            return products.Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
