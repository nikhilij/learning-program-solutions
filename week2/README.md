# Week 2 - Unit Testing and Mocking

This directory contains Week 2 assignments focusing on unit testing with NUnit framework and mocking with Moq library.

## Projects Overview

### 1. NUnit Hands-on - Calculator Testing
**Location:** `1. NUnit-Handson/NUnitCalculatorTest/`

This project demonstrates unit testing using the NUnit framework with a simple calculator application.

**Structure:**
- **CalcLibrary/** - Core calculator logic
  - `Calculator.cs` - Calculator class with Add method
- **CalculatorTests/** - Test project
  - `CalculatorTests.cs` - NUnit test cases for calculator functionality
- `Program.cs` - Console application demonstrating simulated tests
- `Output image.docx` - Screenshots of test execution

**Features:**
- Basic arithmetic operations (Add method)
- NUnit test framework implementation
- Test assertions and validation
- Console-based test simulation

**How to run:**
```bash
cd "1. NUnit-Handson/NUnitCalculatorTest"
dotnet build
dotnet run
```

### 2. Moq Hands-on - Mail Sender Testing
**Location:** `1. Moq-Handson/MoqMailSenderTest/`

This project demonstrates mocking using the Moq framework for testing email functionality without actual email sending.

**Structure:**
- **CustomerCommLib/** - Business logic library
  - `IMailSender.cs` - Interface for mail sending operations
  - `MailSender.cs` - Concrete implementation of mail sender
  - `CustomerComm.cs` - Customer communication service
- **CustomerComm.Tests/** - Test project with mocking
  - `CustomerCommTests.cs` - Moq-based unit tests
- `Output image.docx` - Screenshots of test execution

**Features:**
- Dependency injection pattern implementation
- Interface-based design for testability
- Moq framework for creating mock objects
- Unit testing without external dependencies

**How to run:**
```bash
cd "1. Moq-Handson/MoqMailSenderTest"
dotnet build
dotnet run
```

### 3. SQL Solutions
**File:** `SQL_Solutions.docx`

Contains SQL query solutions and database-related exercises for Week 2.

## Key Learning Objectives

### Unit Testing with NUnit
- Understanding test-driven development (TDD)
- Writing effective unit tests
- Test assertions and validation
- Test organization and naming conventions

### Mocking with Moq
- Understanding dependency injection
- Creating and configuring mock objects
- Testing without external dependencies
- Verifying method calls and behaviors

### Best Practices Demonstrated
- **Separation of Concerns**: Business logic separated from infrastructure
- **Interface Segregation**: Using interfaces for better testability
- **Dependency Injection**: Injecting dependencies for loose coupling
- **Test Isolation**: Each test runs independently

## Technologies Used

- **Framework:** .NET Core
- **Testing Framework:** NUnit
- **Mocking Framework:** Moq
- **Language:** C#
- **IDE:** Visual Studio / Visual Studio Code

## Running Tests

Each project can be built and executed using standard .NET CLI commands:

1. **Build the project:** `dotnet build`
2. **Run the application:** `dotnet run`
3. **Run unit tests:** `dotnet test` (if test projects are properly configured)

## Notes

- Both projects include output documentation with screenshots
- Examples demonstrate real-world testing scenarios
- Code follows industry best practices for unit testing and mocking
