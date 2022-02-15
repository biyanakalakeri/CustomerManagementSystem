using Newtonsoft.Json;

namespace CustomerManagementSystem.Moodels
{
    public class DBhandle
    {
        public string viewcustomer()
        {
            EFDBhandle context = new EFDBhandle();
            var listP = from e in context.Customers
                        select new
                        {
                            CustomerId = e.CustomerId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Country = e.Country,
                            CreatedDate = e.CreatedDate
                        };
            List<Customer> listS = new List<Customer>();
            foreach (var listE in listP)
            {
                Customer e = new Customer();
                e.CustomerId = listE.CustomerId;
                e.FirstName = listE.FirstName;
                e.LastName = listE.LastName;
                e.Country = listE.Country;
                e.CreatedDate = listE.CreatedDate;
                listS.Add(e);
            }

            return JsonConvert.SerializeObject(listS);
        }

        public void DeleteCus(int id)
        {
            EFDBhandle context = new EFDBhandle();
            context.Customers.Remove(context.Customers.FirstOrDefault(e => e.CustomerId == id));
            context.SaveChanges();
            return;
        }

        public void addcustomer(Customer c)
        {
            EFDBhandle context = new EFDBhandle();
            c.CreatedDate = DateTime.Now;
            context.Customers.Add(c);
            context.SaveChanges();
            return;
        }
        public Customer getcusonID(int CustomerId)
        {
            EFDBhandle context = new EFDBhandle();
            var cus = context.Customers.Find(CustomerId);
            return cus;
        }

        public void updatecustomer(Customer c)
        {
            EFDBhandle context = new EFDBhandle();
            Customer cus = context.Customers.Find(c.CustomerId);
            cus.FirstName = c.FirstName;
            cus.LastName = c.LastName;
            cus.Country = c.Country;

            context.SaveChanges();
            return;
        }
    }
}
