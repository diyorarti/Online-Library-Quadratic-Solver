# Quadratic Equation Solver with XUnit Tests

This project implements a simple quadratic equation solver in C# and includes automated unit tests using the XUnit framework. It is part of a Software Quality Control task to demonstrate understanding of automated regression testing and Git version control practices.

---

## 🧮 Functionality

Solves the quadratic equation:


Supports the following cases:
- No real roots
- One real root (discriminant = 0)
- Two real roots (discriminant > 0)

---

## 📁 Project Structure


---

## 🚀 How to Run the Project

### 1. Prerequisites
- .NET SDK installed
- VS Code or any C# compatible IDE
- Git installed

### 2. Commands to Set Up and Run Tests

```bash
# Create solution and projects
dotnet new sln -n QuadraticSolverSolution
dotnet new classlib -n QuadraticSolver
dotnet new xunit -n QuadraticSolver.Tests

# Add projects to solution
dotnet sln add QuadraticSolver/QuadraticSolver.csproj
dotnet sln add QuadraticSolver.Tests/QuadraticSolver.Tests.csproj

# Add reference to the main library from the test project
dotnet add QuadraticSolver.Tests/QuadraticSolver.Tests.csproj reference QuadraticSolver/QuadraticSolver.csproj

# Run the tests
dotnet test
