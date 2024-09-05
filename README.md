# Cornerstech ASP.NET MVC Project
## Table of Contents
- [How to Use](#how-to-use)
- [Database Relationships](#database-relationships)
- [Data Management](#data-management)
- [Key Modules](#key-modules)
- [Object-Oriented Programming in the project](#object-oriented-programming-in-the-project)
- [Built With](#built-with)

## How to Use
1. Clone the repository to your local machine:
2. Set up the SQL Server connection string in the **appsettings.json**
3. Run migrations to set up the database on Cornerstech.Web project:
```
dotnet ef database update
```
4. Build and run the project:
```
dotnet run
```
5. Navigate to https://localhost:5001 to view the application. To test admin and partner users, you can use the following name-password combinations:
   
| Role | Username | Password |
|--------|-------|----------|
| admin  |    admin | 1234  |
| partner  | beyza | 1234   |

## Database Relationships
### UML Class Diagram
![](https://github.com/beyzanc/cornerstech-case/blob/master/uml.drawio.png)

## Data Management
The system relies on **Entity Framework Core (EF Core)** for handling all data-related operations:

### Layered Architecture:
The application is divided into four layers:

- **Entity Layer**: Defines models like `Agreement`, `Risk`, `Partner`, and `Notification`, which map directly to the database tables.
- **Data Access Layer (DAL)**: Manages database interactions through repositories. Each entity has a corresponding repository that handles CRUD operations.
- **Business Layer**: Implements the business logic in service classes like `AgreementManager` and `RiskManager`.
- **Web Layer**: Handles the presentation logic and user interaction through controllers and views in **ASP.NET Core MVC**.

### Query Optimization:
- Uses **LINQ** to query data efficiently.
- Eager loading (`.Include()`) retrieves related entities in one go, reducing the number of database queries.

### Unit of Work Pattern:
- This pattern ensures that multiple database operations are treated as a single transaction, maintaining data integrity across related operations.

### Multi-Tenant Data Security:
- Different user roles (e.g., admin and partner) have controlled access, with partners only able to view data associated with them, ensuring data privacy.
  
### Data Seeding:
- During initialization, **data seeding** provides meaningful default data for testing purposes, ensuring that the system is ready to use out-of-the-box.
  
## Key Modules
### Agreement Module:
- Manages the creation, editing, and deletion of agreements.
- Handles the assignment of partners and risks to agreements.

### Risk Management Module:
- Provides tools for risk calculation and analysis.
- Includes scoring based on factors like frequency, level, and possibility.

### Notification Module:
- Notifies users when key changes occur (not yet in real time).

### Partner Management Module:
- Allows the admin to manage partners.
- Handles the association of partners with their respective agreements.

## Object-Oriented Programming (OOP) in the Project
### Encapsulation:
- Data and functionality are bundled into distinct classes (e.g., `Agreement`, `Risk`, `Partner`), with methods that manage the data's internal state.

### Inheritance:
- Common properties like `Id`, `CreatedDate`, and `IsActive` are encapsulated in a `BaseEntity` class.
- Other entities like `Agreement` and `Risk` inherit these properties from `BaseEntity`.

### Polymorphism:
- Through interfaces (e.g., `IGenericService<T>`), the system supports flexible service management.
- Each service (`AgreementService`, `RiskService`) implements its own logic while adhering to the contract defined by the interface.

### Abstraction:
- The system abstracts complex database logic behind repositories and services.
- This makes it easy to manage data without needing to directly handle SQL queries.

## Built With
- .NET Core for backend development
- Entity Framework Core for ORM and database management
- ASP.NET MVC Core for the frontend
- HTML, CSS, JavaScript for UI components
- MSSQL Server for database management
