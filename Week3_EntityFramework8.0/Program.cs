using RetailInventory.Data;
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

var products = await context.Products.ToListAsync();
Console.WriteLine("All Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - {p.Price}");
}

var product = await context.Products.FindAsync(1);
Console.WriteLine($"\nProduct with ID 1: {product?.Name}");

var expensiveProduct = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\nFirst expensive product (> 50000): {expensiveProduct?.Name}");

Console.ReadLine(); 
