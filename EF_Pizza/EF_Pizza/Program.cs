using EF_Pizza.Data;
using EF_Pizza.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
public class Program
{
    public static void Main(string[] args)
    {
        using PizzaContext context = new PizzaContext();

        var changeTracker = context.ChangeTracker;
        
        //contexto.SaveChanges() guarda todos los cambios que detecte que han cambiado
        //AsNoTracking evita que Productos sea trackeado, por lo tanto no guarda
        //esto es util al momento de hacer consultar y demás que no requieran que un producto no cambie de valor
        var id1 = context.Products.AsNoTracking().First(_ => _.Id == 1);

        var changes= changeTracker.Entries<Product>().ToList();

        id1.Name = "Pizza ASDASDA2";

        var changes2 = changeTracker.Entries<Product>().ToList();

        context.Remove(id1);

        context.SaveChanges();


        //Product pizzaVegana = new Product()
        //{
        //    Name = "Pizza Especial Vegana ",
        //    Price = 14.99M,
        //};

        //context.Products.Add(pizzaVegana);

        //Product pizzaCarne = new Product()
        //{s
        //    Name = "Pizza Especial de Carne ",
        //    Price = 7.99M,
        //};

        //context.Add(pizzaCarne);
        //context.SaveChanges();

        //SELECT DE PRODUCTOS DE BASE DE DATOS TABLA PRODUCTOS

        GetProductsFilterByPrice(context, 5);
    }

    public static void GetProductsFilterByPrice(PizzaContext context, int? priceFilter = 0)
    {
        var filteredProducts = context.Products
                            .Where(x => x.Price > priceFilter)
                            .OrderBy(x => x.Name)
                            .ToList();

        foreach (var item in filteredProducts)
        {
            Console.WriteLine($"Id: {item.Id}");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Price: {item.Price}");
        }
    }

}