# Pierre's Sweet and Savory Treats

#### An ASP.NET Core MVC bakery application using EF Core, MySQL and Identity by [Onur Kaymak](https://onurkaymak.com)

## Technologies Used

- C#
- .NET 6
- Entity Framework Core
- Entity Framework Core Identity
- MySQL
- MySQL Workbench

## Description

This bakery application allows the users implement CRUD operations for the matching Treat and Flavor options. Application database uses MySQL Join Table features to manage CRUD between two tables.

An independent C# / ASP .NET project assignment for [Epicodus](https://www.epicodus.com/), project is about "Authentication with Identity".

## Important - This project requires

- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

- [MySQL](https://dev.mysql.com/downloads/mysql)

- [MySQL WorkBench](https://dev.mysql.com/downloads/workbench)

## Setup/Installation Requirements

- Clone this project from the provided GitHub repository: [Repository Link](https://github.com/onurkaymak/bakeryV2).

- Navigate into the project's folder in your terminal.

- Navigate into `BakeryV2` directory in your terminal.

- Create a file called `appsettings.json`.

- Add the following code below in `appsettings.json` file.

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE];uid=[USERNAME];pwd=[PASSWORD];"
  }
}

```

- Replace the `USERNAME`,`PASSWORD` and `DATABASE` values with your own username and password for MySQL and your choice of database name.

### Creating the Database from Migrations

- Type `$ dotnet tool install --global dotnet-ef --version 6.0.0` to install a tool for Entity Framework Core, this tool allows us to create migrations and update our database. (This will install the EF Core migration tool globally in your machine.)

- To create your database by migrations, while you are in the `BakeryV2` directory, type `dotnet ef database update` to create a database in your MySQL with your MySQL credentials that you provided in `appsettings.json` file.

### Run the Application

- Type `$ dotnet run` in the terminal command line to compile and execute this application while in `BakeryV2` directory (Not the root directory BakeryV2.Solution).

- IMPORTANT: `$ dotnet run` compiles the project folders for you without needing `$ dotnet build` command, however you can still use `$ dotnet build` if you need to compile the folders without executing the application.

- You will have a new browser tab open to view the application, you can also navigate `https://localhost:5001` manually to view it.

### Create an Account for Create, Update and Delete Operations

- After run the project with `$ dotnet run`, click on `Create or Manage an Account` link to navigate into `Authentication` page.

- Click on `Register` to create an account, validation messages will guide you to create an account. 

- Once you created your account succesfully, you will be redirected back to `Authentication`.

- Click on `Login` and enter your credentials that used to create your account.

- After you logged in, you will have access to Create, Update and Delete functionalities beside Read.

## Known Bugs

There is no known bugs.

## License

MIT License

Copyright (c) [2023] [Onur Kaymak]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
