# Project
This is just a personal project that allows me to keep track of best practices with ASP.NET Clean Architecture. This project is what I'll be referring to whenever I am going to be creating new projects.

## Features
- Clean Architecture ft. API, Application, Domain, and Infrastructure Layers
- Scalar documentation
- Serilog logging
- Database Connection to PostgreSQL
- Add domain entities and pushing migrations
- Domain entity data annotations
- Entity type configurations

## Commands

#### Running the application
```
dotnet run --project Bested.api
```

#### Adding new migrations
```
dotnet ef migrations add MigrationName --project Bested.Infrastructure --startup-project Bested.Api
```

#### Removing new migrations
```
dotnet ef migrations remove --project Bested.Infrastructure --startup-project Bested.Api
```

#### Updating database with new migrations
```
dotnet ef database update --project Bested.Infrastructure --startup-project Bested.Api
```

#### Dropping the database
```
dotnet ef database drop --project Bested.Infrastructure --startup-project Bested.Api --force
```