# Week 3 - Entity Framework Core 8.0 Labs Summary

This week, I completed Labs 1 through 7 from the EF Core 8.0 Hands-On Lab series, focused on building a retail inventory system using C# and SQL Server.

---

## ✅ Lab 1: Understanding ORM with a Retail Inventory System
- Learned about Object-Relational Mapping (ORM).
- Set up a new .NET Console App: `RetailInventory`.
- Installed EF Core packages via NuGet.

## ✅ Lab 2: Setting Up the Database Context
- Created `Product` and `Category` model classes.
- Implemented `AppDbContext` with `DbSet<Product>` and `DbSet<Category>`.
- Connected to SQL Server using a secured connection string.

## ✅ Lab 3: Using EF Core CLI for Migrations
- Installed `dotnet-ef` CLI globally.
- Created migration: `InitialCreate`.
- Ran `dotnet ef database update` to create tables.
- Verified tables in SQL Server Management Studio.

## ✅ Lab 4: Inserting Initial Data
- Inserted default categories and products using `AddRangeAsync()` and `SaveChangesAsync()`.
- Verified insertion through SSMS.

## ✅ Lab 5: Retrieving Data
- Retrieved all products using `ToListAsync()`.
- Retrieved a product by ID using `FindAsync()`.
- Queried expensive product using `FirstOrDefaultAsync()`.

## ✅ Lab 6: Updating and Deleting
- Updated the price of "Laptop" to ₹70000.
- Deleted "Rice Bag" from the database using `Remove()`.

## ✅ Lab 7: Writing Queries with LINQ
- Used `Where()`, `OrderByDescending()` to filter and sort products.
- Projected product details into DTOs using `Select()`.

---

📚 **Tools Used:**  
- .NET 8 Console App  
- EF Core 8.0  
- SQL Server Management Studio (SSMS)

🧠 **Skills Gained:**  
- ORM Concepts  
- Database Migrations  
- CRUD Operations  
- LINQ Querying
