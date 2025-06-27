using BusinessObjects;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();

        public void InitializeDataset()
        {
            if (customers.Count > 0) return;
            customers.Add(new Customer { CustomerId = 55, CompanyName = "Old World Delicatessen", ContactName = "Rene Phillips", ContactTitle = "Sales Representative", Address = "2743 Bering St.", Phone = "0" });
            customers.Add(new Customer { CustomerId = 56, CompanyName = "Ottilies Käseladen", ContactName = "Henriette Pfalzheim", ContactTitle = "Owner", Address = "Mehrheimerstr. 369", Phone = "1" });
            customers.Add(new Customer { CustomerId = 57, CompanyName = "Paris spécialités", ContactName = "Marie Bertrand", ContactTitle = "Owner", Address = "265, boulevard Charonne", Phone = "(1) 42.34.22.66" });
            customers.Add(new Customer { CustomerId = 58, CompanyName = "Pericles Comidas clásicas", ContactName = "Guillermo Fernández", ContactTitle = "Sales Representative", Address = "Calle Dr. Jorge Cash 321", Phone = "(5) 552-3745" });
            customers.Add(new Customer { CustomerId = 59, CompanyName = "Piccolo und mehr", ContactName = "Georg Pipps", ContactTitle = "Sales Manager", Address = "Geislweg 14", Phone = "6562-9722" });
            customers.Add(new Customer { CustomerId = 60, CompanyName = "Princesa Isabel Vinhos", ContactName = "Isabel de Castro", ContactTitle = "Sales Representative", Address = "Estrada da saúde n. 58", Phone = "(1) 356-5634" });
            customers.Add(new Customer { CustomerId = 61, CompanyName = "Que Delícia", ContactName = "Bernardo Batista", ContactTitle = "Accounting Manager", Address = "Rua da Panificadora, 12", Phone = "(21) 555-4252" });
            customers.Add(new Customer { CustomerId = 62, CompanyName = "Queen Cozinha", ContactName = "Lúcia Carvalho", ContactTitle = "Marketing Assistant", Address = "Alameda dos Canàrios, 891", Phone = "(11) 555-1189" });
            customers.Add(new Customer { CustomerId = 63, CompanyName = "QUICK-Stop", ContactName = "Horst Kloss", ContactTitle = "Accounting Manager", Address = "Taucherstraße 10", Phone = "0372-035188" });
            customers.Add(new Customer { CustomerId = 64, CompanyName = "Rancho grande", ContactName = "Sergio Gutiérrez", ContactTitle = "Sales Representative", Address = "Av. del Libertador 900", Phone = "(1) 123-5555" });
            customers.Add(new Customer { CustomerId = 65, CompanyName = "Rattlesnake Canyon Grocery", ContactName = "Paula Wilson", ContactTitle = "Assistant Sales Representative", Address = "2817 Milton Dr.", Phone = "(505) 555-5939" });
            customers.Add(new Customer { CustomerId = 66, CompanyName = "Reggiani Caseifici", ContactName = "Maurizio Moroni", ContactTitle = "Sales Associate", Address = "Strada Provinciale 124", Phone = "0522-556721" });
            customers.Add(new Customer { CustomerId = 67, CompanyName = "Ricardo Adocicados", ContactName = "Janete Limeira", ContactTitle = "Assistant Sales Agent", Address = "Av. Copacabana, 267", Phone = "(21) 555-3412" });
            customers.Add(new Customer { CustomerId = 68, CompanyName = "Richter Supermarkt", ContactName = "Michael Holz", ContactTitle = "Sales Manager", Address = "Grenzacherweg 237", Phone = "0897-034214" });
            customers.Add(new Customer { CustomerId = 69, CompanyName = "Romero y tomillo", ContactName = "Alejandra Camino", ContactTitle = "Accounting Manager", Address = "Gran Vía, 1", Phone = "(91) 745 6200" });
            customers.Add(new Customer { CustomerId = 70, CompanyName = "Santé Gourmet", ContactName = "Jonas Bergulfsen", ContactTitle = "Owner", Address = "Erling Skakkes gate 78", Phone = "07-98 92 35" });
            customers.Add(new Customer { CustomerId = 71, CompanyName = "Save-a-lot Markets", ContactName = "Jose Pavarotti", ContactTitle = "Sales Representative", Address = "187 Suffolk Ln.", Phone = "(208) 555-8097" });
            customers.Add(new Customer { CustomerId = 72, CompanyName = "Seven Seas Imports", ContactName = "Hari Kumar", ContactTitle = "Sales Manager", Address = "90 Wadhurst Rd.", Phone = "(171) 555-1717" });
            customers.Add(new Customer { CustomerId = 73, CompanyName = "Simons bistro", ContactName = "Jytte Petersen", ContactTitle = "Owner", Address = "Vinbæltet 34", Phone = "31 12 34 56" });
            customers.Add(new Customer { CustomerId = 74, CompanyName = "Spécialités du monde", ContactName = "Dominique Perrier", ContactTitle = "Marketing Manager", Address = "25, rue Lauriston", Phone = "(1) 47.55.60.10" });
            customers.Add(new Customer { CustomerId = 75, CompanyName = "Split Rail Beer & Ale", ContactName = "Art Braunschweiger", ContactTitle = "Sales Manager", Address = "P.O. Box 555", Phone = "(307) 555-4680" });
            customers.Add(new Customer { CustomerId = 76, CompanyName = "Suprêmes délices", ContactName = "Pascale Cartrain", ContactTitle = "Accounting Manager", Address = "Boulevard Tirou, 255", Phone = "(071) 23 67 22 20" });
            customers.Add(new Customer { CustomerId = 77, CompanyName = "The Big Cheese", ContactName = "Liz Nixon", ContactTitle = "Marketing Manager", Address = "89 Jefferson Way Suite 2", Phone = "(503) 555-3612" });
            customers.Add(new Customer { CustomerId = 78, CompanyName = "The Cracker Box", ContactName = "Liu Wong", ContactTitle = "Marketing Assistant", Address = "55 Grizzly Peak Rd.", Phone = "(406) 555-5834" });
            customers.Add(new Customer { CustomerId = 79, CompanyName = "Toms Spezialitäten", ContactName = "Karin Josephs", ContactTitle = "Marketing Manager", Address = "Luisenstr. 48", Phone = "0251-031259" });
            customers.Add(new Customer { CustomerId = 80, CompanyName = "Tortuga Restaurante", ContactName = "Miguel Angel Paolino", ContactTitle = "Owner", Address = "Avda. Azteca 123", Phone = "(5) 555-2933" });
            customers.Add(new Customer { CustomerId = 81, CompanyName = "Tradição Hipermercados", ContactName = "Anabela Domingues", ContactTitle = "Sales Representative", Address = "Av. Inês de Castro, 414", Phone = "(11) 555-2167" });
            customers.Add(new Customer { CustomerId = 82, CompanyName = "Trail's Head Gourmet Provisioners", ContactName = "Helvetius Nagy", ContactTitle = "Sales Associate", Address = "722 DaVinci Blvd.", Phone = "(206) 555-8257" });
            customers.Add(new Customer { CustomerId = 83, CompanyName = "Vaffeljernet", ContactName = "Palle Ibsen", ContactTitle = "Sales Manager", Address = "Smagsloget 45", Phone = "86 21 32 43" });
            customers.Add(new Customer { CustomerId = 84, CompanyName = "Victuailles en stock", ContactName = "Mary Saveley", ContactTitle = "Sales Agent", Address = "2, rue du Commerce", Phone = "78.32.54.86" });
            customers.Add(new Customer { CustomerId = 85, CompanyName = "Vins et alcools Chevalier", ContactName = "Paul Henriot", ContactTitle = "Accounting Manager", Address = "59 rue de l'Abbaye", Phone = "26.47.15.10" });
            customers.Add(new Customer { CustomerId = 86, CompanyName = "Die Wandernde Kuh", ContactName = "Rita Müller", ContactTitle = "Sales Representative", Address = "Adenauerallee 900", Phone = "0711-020361" });
            customers.Add(new Customer { CustomerId = 87, CompanyName = "Wartian Herkku", ContactName = "Pirkko Koskitalo", ContactTitle = "Accounting Manager", Address = "Torikatu 38", Phone = "981-443655" });
            customers.Add(new Customer { CustomerId = 88, CompanyName = "Wellington Importadora", ContactName = "Paula Parente", ContactTitle = "Sales Manager", Address = "Rua do Mercado, 12", Phone = "(14) 555-8122" });
            customers.Add(new Customer { CustomerId = 89, CompanyName = "White Clover Markets", ContactName = "Karl Jablonski", ContactTitle = "Owner", Address = "305 - 14th Ave. S. Suite 3B", Phone = "(206) 555-4112" });
            customers.Add(new Customer { CustomerId = 90, CompanyName = "Wilman Kala", ContactName = "Matti Karttunen", ContactTitle = "Owner/Marketing Assistant", Address = "Keskuskatu 45", Phone = "90-224 8858" });
            customers.Add(new Customer { CustomerId = 91, CompanyName = "Wolski  Zajazd", ContactName = "Zbyszek Piestrzeniewicz", ContactTitle = "Owner", Address = "ul. Filtrowa 68", Phone = "(26) 642-7012" });
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer? GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public Customer? GetCustomerByPhone(string phone)
        {
            return customers.FirstOrDefault(c => c.Phone == phone);
        }

        public bool SaveCustomer(Customer customer)
        {
            Customer cus = customers.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            if (cus != null)
                return false;
            customers.Add(customer);
            return true;
        }

        public bool UpdateCustomer(Customer customer)
        {
            Customer cus = customers.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            if (cus == null)
                return false;
            cus.CompanyName = customer.CompanyName;
            cus.ContactName = customer.ContactName;
            cus.ContactTitle = customer.ContactTitle;
            cus.Address = customer.Address;
            cus.Phone = customer.Phone;
            return true;
        }

        public bool DeleteCustomer(int id)
        {
            Customer cus = customers.FirstOrDefault(x => x.CustomerId == id);
            if (cus == null)
                return false;
            customers.Remove(cus);
            return true;
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllCustomers();
            return customers.Where(c => c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || c.ContactName?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true
                || c.Phone?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true)
                .ToList();
        }
    }
}
