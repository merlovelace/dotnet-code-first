using Microsoft.EntityFrameworkCore;

public class ECommerceDb : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContectOptionsBuilder
        optionsBuilder)
    {
        optionsBuilder.UseSqlServer()
    }
}

//Entity 
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
}

public class Customer
{
    public int Id { get; set;  }
    public string FirstName { get; set; }
    public string LastName { get; set; }
 
}