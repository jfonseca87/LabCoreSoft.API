# LabCoreSoft.API

A medical records management API built with ASP.NET Core. It provides CRUD operations for patients (pacientes), cities (ciudades), departments (departamentos), and document types (tipos de documento) in the context of a Colombian healthcare system.

The API follows a layered architecture with Controllers, Business (service) layer, Repositories, DTOs, and AutoMapper profiles. It integrates with SQL Server via Entity Framework Core (database-first, using EF Core Power Tools) and includes an Angular front-end client located in the `lab-core-soft-client` folder.

The SQL script `Script_LabCoreSoft_Test.sql` creates the `LabCoreSoftMedico` database with tables for `TiposDocumento`, `Departamentos`, `Ciudades`, and `Pacientes`, along with seed data.

## Technologies / Libraries

- .NET 7
- ASP.NET Core Web API
- Entity Framework Core 7 + SQL Server
- AutoMapper 13
- FluentValidation 11
- Swashbuckle / Swagger (OpenAPI)
- CORS enabled for local development
- Angular (front-end client)

## Key Features / Components

- **Patient Management** — Create and list patients with document type, city, and date of birth validation.
- **Reference Data** — Endpoints for departments, cities (grouped by department), and document types.
- **Layered Architecture** — Clear separation: Controllers → Business (service) → Repository → EF Core.
- **AutoMapper** — Maps between domain models and DTOs (e.g., `CrearPacienteDto`, `ObtenerPacienteDto`).
- **Angular Client** — A separate front-end application in `lab-core-soft-client/` for the user interface.

## How to Run

1. Run `Script_LabCoreSoft_Test.sql` against a SQL Server instance to create the database and seed data.
2. Update the `LabCoreSoftMedicoConn` connection string in `appsettings.json`.
3. Start the API project. Swagger UI will be available at `/swagger` in development mode.
4. (Optional) Navigate to the `lab-core-soft-client/` folder and run `npm start` to launch the Angular front-end.
