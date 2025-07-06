//Lab 7: Writing Queries with LINQ
using Microsoft.EntityFrameworkCore;
using RetailInventory;

using var context = new AppDbContext();

var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

Console.WriteLine("\nFiltered & Sorted Products:");
foreach (var p in filtered)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

var productDTOs = await context.Products
    .Select(p => new { p.Name, p.Price })
    .ToListAsync();

Console.WriteLine("\nProduct DTOs:");
foreach (var dto in productDTOs)
{
    Console.WriteLine($"{dto.Name} → ₹{dto.Price}");
}


// Uncomment the following lines to test the database operations
//---------------------------------------------------------------

/* using Microsoft.EntityFrameworkCore;
using RetailInventory;

using var context = new AppDbContext();

var productToUpdate = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");

if (productToUpdate != null)
{
    productToUpdate.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine("Product price updated.");
}
else
{
    Console.WriteLine("Laptop not found.");
}

var productToDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (productToDelete != null)
{
    context.Products.Remove(productToDelete);
    await context.SaveChangesAsync();
    Console.WriteLine("Product deleted.");
}
else
{
    Console.WriteLine("Rice Bag not found.");
} */


// uncomment the following lines to test the database operations
//---------------------------------------------------------------

/* using Microsoft.EntityFrameworkCore;
using RetailInventory;

using var context = new AppDbContext();

var products = await context.Products.ToListAsync();
Console.WriteLine("\nAll Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

var productById = await context.Products.FindAsync(1);
Console.WriteLine($"\nFind ID 1: {productById?.Name ?? "Not found"}");

var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\nExpensive Product: {expensive?.Name ?? "None"}"); */


// Uncomment the following lines to insert data into the database
//---------------------------------------------------------------

/* using RetailInventory;
using RetailInventory.Models; 

var context = new AppDbContext();

var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);

var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

await context.Products.AddRangeAsync(product1, product2);
await context.SaveChangesAsync();

Console.WriteLine("Data inserted successfully."); */



// Uncomment the following lines to test the database connection
//---------------------------------------------------------------
/* using (var context = new AppDbContext())
{
    Console.WriteLine("Connected to DB successfully!");
} */
