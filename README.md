# EmployeeManagement Project

## Overview

The EmployeeManagement project is a web-based application developed using ASP.NET Core MVC. It provides functionalities to manage employee data, including creating, editing, viewing, and deleting employee records. The project also includes reporting features for generating employee-wise, designation-wise, combination of designations-wise, and an entire employee list-designation hierarchy-wise data.

## Features

- **Employee Management**
  - Add new employees
  - Edit employee details
  - View a list of employees
  - Delete employees

- **Reporting**
  - Employee-wise reports
  - Designation-wise reports
  - Combination of designations-wise reports
  - Entire employee list-designation hierarchy-wise reports

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other compatible database)
- [Visual Studio](https://visualstudio.microsoft.com/) (recommended)
- NuGet packages:
  - `Microsoft.EntityFrameworkCore.SqlServer`
  - `Microsoft.EntityFrameworkCore.Tools`
  - `Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation`
  - `CrystalReports.Engine`
  - `CrystalReports.Shared`

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/your-username/EmployeeManagement.git
    cd EmployeeManagement
    ```

2. Set up the database:
    - Update the `appsettings.json` file with your database connection string.
    - Run the following command to apply migrations:
      ```sh
      dotnet ef database update
      ```

3. Install the required NuGet packages:
    - In Visual Studio, open the Package Manager Console and run:
      ```sh
      Install-Package Microsoft.EntityFrameworkCore.SqlServer
      Install-Package Microsoft.EntityFrameworkCore.Tools
      Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
      Install-Package CrystalReports.Engine
      Install-Package CrystalReports.Shared
      ```

## Usage

1. Run the application:
    ```sh
    dotnet run
    ```

2. Navigate to `https://localhost:5001` (or the port specified in your `launchSettings.json`) to access the application.

3. Use the application to manage employee data:
    - **Home Page:** View the list of employees.
    - **Create Employee:** Add a new employee to the system.
    - **Edit Employee:** Update existing employee information.
    - **Delete Employee:** Remove an employee from the system.
    - **Reports:** Generate various reports related to employees and their designations.

## Reporting

The project uses Crystal Reports for generating various types of reports. The reports can be accessed through the reporting section of the application. You can filter data using LINQ and bind the results to the report viewer.

### Creating Reports

1. **Add a new report:**
   - Navigate to the `Reports` folder in the project.
   - Add a new Crystal Report (.rpt file).
   - Design the report according to the requirements.

2. **Filter Data:**
   - Use LINQ queries in the controllers to filter data as needed.
   - Bind the filtered data to the report.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.

