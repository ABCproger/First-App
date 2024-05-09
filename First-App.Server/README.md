# First-app.Server

## Requierements
- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)

## Installation
1. Clone this repository to your local machine.
2. Ensure you have the required dependencies installed (listed in the Prerequisites section).
3. Open the solution in Visual Studio or your preferred IDE.

### NuGet Packages
Ensure the following NuGet packages are updated to the specified versions:
- AutoMapper v12.0.1
- AutoMapper.Extensions.Microsoft.DependencyInjection v12.0.1
- FluentValidation.AspNetCore v11.3.0
- Microsoft.EntityFrameworkCore v8.0.4
- Microsoft.EntityFrameworkCore.Design v8.0.4
- Microsoft.EntityFrameworkCore.Tools v8.0.4
- Npgsql.EntityFrameworkCore.PostgreSQL v8.0.2

## Configuration for local setup
*If you run the application with Docker Compose, these actions are not necessary.*

1. Configure your database connection string in `appsettings.json`.
2. Run database migrations using the Package Manager Console:
```Package Manager Console
Update-Database
```
   
