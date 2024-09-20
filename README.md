## .NET Core API Practice

Implemented using:
- Entity Framework Core provides ORM capabilities to interact with databases using .NET models.
- Swagger offers a testing and documentation UI for API endpoints.
- Entity Framework Core Sql Server is the provider that integrates EF Core with SQL Server databases.
- Entity Framework Core Tools is a set of utilities to manage database migrations, scaffolding, and schema updates in the development workflow.


1. Entity Framework Core
Entity Framework Core (EF Core) is an Object-Relational Mapper (ORM) that allows developers to work with databases using .NET objects, without needing to write much SQL code. It provides a way to interact with the database (CRUD operations) through strongly typed models.

Key Features:
- Maps your .NET classes to database tables and vice versa.
- Provides a high-level abstraction over database operations.
- Supports LINQ (Language Integrated Query) for querying data.
- Automatic database migrations and updates.

2. Swagger (for testing)
Swagger (specifically Swashbuckle in the .NET ecosystem) is used to auto-generate interactive API documentation. Swagger UI allows you to explore and test your API's endpoints directly in a web interface without needing an external API client like Postman.
Key Features:

- Generates OpenAPI (formerly Swagger) specifications for your API.
- Provides an interactive UI for testing the API's HTTP endpoints.
- Shows available routes, expected parameters, response formats, and example requests.
- Improves API development by allowing developers to test and understand the API's behavior.

4. Entity Framework Core Sql Server
This is the EF Core provider for Microsoft SQL Server, allowing EF Core to connect to a SQL Server database. It enables the use of SQL Server as the database engine for your .NET Core application, leveraging EF Core's ORM capabilities.

Key Features:
- Provides the necessary drivers and tools to integrate SQL Server with EF Core.
- Maps your models and LINQ queries to SQL Server-specific SQL queries.
- Supports SQL Server-specific features such as migrations, data seeding, and advanced querying options.

5. Entity Framework Core Tools
These tools are used for managing database migrations, scaffolding, and other database-related operations in the EF Core environment. These typically work from the command line or package manager console in Visual Studio.

Key Features:
- Migrations: Helps you apply schema changes (e.g., adding a new table or modifying a column) to your database over time.
- Scaffolding: Allows you to reverse-engineer an existing database into EF Core models.
- Command-line support: Enables the use of commands like dotnet ef migrations add, dotnet ef database update, etc., to manage the database schema.
- Helps with database updates and rollbacks during development.
