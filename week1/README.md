# Week 1 - Cognizant Learning Program

This directory contains the Week 1 assignments focusing on Data Structures & Algorithms and Design Principles & Patterns.

## Data Structures and Algorithms

### Exercise 2: E-commerce Platform Search
**Location:** `Data structures and Algorithms/Exercise 2/EcommercePlatformSearch/`

This project implements search algorithms for an e-commerce platform.

**Files:**
- `Product.cs` - Product data model
- `ProductDataGenerator.cs` - Generates sample product data
- `SearchAlgorithms.cs` - Implements linear and binary search algorithms
- `SearchResult.cs` - Search result data structure
- `Program.cs` - Main program entry point

**How to run:**
```bash
cd "Data structures and Algorithms/Exercise 2/EcommercePlatformSearch"
dotnet build
dotnet run
```

### Exercise 7: Financial Forecasting
**Location:** `Data structures and Algorithms/Exercise 7/FinancialForecasting/`

This project implements financial forecasting algorithms using recursion.

**Files:**
- `FinancialForecaster.cs` - Main forecasting logic
- `FinancialScenario.cs` - Financial scenario data model
- `PerformanceMetrics.cs` - Performance measurement utilities
- `Program.cs` - Main program entry point

**How to run:**
```bash
cd "Data structures and Algorithms/Exercise 7/FinancialForecasting"
dotnet build
dotnet run
```

## Design Principles & Patterns

### Exercise 1: Singleton Pattern Example
**Location:** `Design principles & Patterns/Exercise 1/SingletonPatternExample/`

This project demonstrates the Singleton design pattern implementation.

**Files:**
- `Logger.cs` - Singleton logger implementation
- `Program.cs` - Demonstration of singleton pattern usage

**How to run:**
```bash
cd "Design principles & Patterns/Exercise 1/SingletonPatternExample"
dotnet build
dotnet run
```

### Exercise 2: Factory Method Pattern Example
**Location:** `Design principles & Patterns/Exercise 2/FactoryMethodPatternExample/`

This project demonstrates the Factory Method design pattern for document creation.

**Files:**
- `IDocument.cs` - Document interface
- `DocumentFactory.cs` - Abstract document factory
- `PdfDocument.cs`, `WordDocument.cs`, `ExcelDocument.cs` - Concrete document implementations
- `PdfDocumentFactory.cs`, `WordDocumentFactory.cs`, `ExcelDocumentFactory.cs` - Concrete factory implementations
- `Program.cs` - Demonstration of factory method pattern

**How to run:**
```bash
cd "Design principles & Patterns/Exercise 2/FactoryMethodPatternExample"
dotnet build
dotnet run
```

## Technologies Used

- **Framework:** .NET 9.0
- **Language:** C#
- **Build Tool:** dotnet CLI

## Notes

All projects are configured to use .NET 9.0 and can be built and run using the `dotnet` command-line tool.
