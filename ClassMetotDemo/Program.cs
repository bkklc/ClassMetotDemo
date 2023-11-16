using ClassMetotDemo;

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.FirstName = "Berk";
customer1.LastName = "Kılıç";
customer1.Phone = "0123 456 7899";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.FirstName = "Ahmet";
customer2.LastName = "Kılıç";
customer2.Phone = "0123 456 7899";

CustomerManager manager = new CustomerManager();
manager.Add(customer1);
manager.Update(customer1);
manager.Delete(customer1);

Console.WriteLine("------------------------------");

manager.Add(customer2);
manager.Update(customer2);
manager.Delete(customer2);

Console.WriteLine("------------------------------");


List<Customer> customers = new List<Customer> {customer1, customer2 };

foreach (var c in customers)
{
    manager.List(c);
}