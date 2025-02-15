# SalesWebMvc

SalesWebMvc is a web application developed using Blazor and ASP.NET Core, focused on sales management. The application allows users to manage departments, sellers, and sales records, providing an interactive and responsive interface.

## Project Structure

### Main Directories

1. **Controllers**:
   - Contains the controllers that handle HTTP requests and return appropriate responses.
   - Example: `DepartmentsController`, `SalesRecordsController`.

2. **Models**:
   - Contains the model classes that represent the application's data.
   - Example: `Department`, `Seller`, `SalesRecord`.

3. **Views**:
   - Contains the views (Razor pages) that define the user interface.
   - Example: `Views/Home/Index.cshtml`, `Views/Departments/Create.cshtml`.

4. **wwwroot**:
   - Contains static files such as CSS, JavaScript, and images.
   - Example: `wwwroot/css/site.css`, `wwwroot/js/site.js`.

### Main Files

1. **Program.cs**:
   - The entry point of the application. Configures and starts the application host.

2. **Startup.cs**:
   - Configures the services and the request pipeline of the application.

3. **SalesWebMvcContext.cs**:
   - Entity Framework context for accessing the database.

## Main Features

1. **Department Management**:
   - Create, edit, view, and delete departments.
   - Example view: `Views/Departments/Create.cshtml`.

2. **Seller Management**:
   - Create, edit, view, and delete sellers.
   - Example view: `Views/Sellers/Create.cshtml`.

3. **Sales Records**:
   - Simple and grouped search of sales records.
   - Example view: `Views/SalesRecords/SimpleSearch.cshtml`.

## Example View

### Views/Home/Index.cshtml

The `Index.cshtml` view serves as the home page of the application. It displays a welcome message, information about the creator of the project, and a link to the project's GitHub repository.
- **Title**: The title of the page is set to "Home Page".
- **Welcome Message**: A large welcome message is displayed using Bootstrap's `display-4` class.
- **Creator Information**: The name of the creator is displayed using `ViewData["Aluno"]`.
- **Additional Message**: An additional message is displayed using `ViewData["Message"]`.
- **GitHub Link**: A link to the project's GitHub repository is provided, which opens in a new tab.

## Services

### SalesRecordService

The `SalesRecordService` class provides methods for querying sales records from the database. It includes methods for finding sales records by date and grouping them by department.
- **FindByDateAsync**: Retrieves sales records within a specified date range.
- **FindByDateGroupingAsync**: Retrieves and groups sales records by department within a specified date range.

## Summary

The SalesWebMvc project is a web application for sales management, developed with Blazor and ASP.NET Core. It allows the management of departments, sellers, and sales records, providing an interactive and responsive interface.
