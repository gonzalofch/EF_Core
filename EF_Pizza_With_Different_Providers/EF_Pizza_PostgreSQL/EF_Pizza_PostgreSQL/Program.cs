using EF_Pizza_PostgreSQL.Data;
using EF_Pizza_PostgreSQL.Models;

using EfpizzaContext context = new EfpizzaContext();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
context.Add(veggieSpecial);
context.Add(deluxeMeat);
context.SaveChanges();