
## Prerequisites
- .NET 7
- Microsoft SQL Server
- Visual Studio or Visual Studio Code

## Setup Instructions
1. Update the connection string in the `RDbContext` class to match your SQL Server configuration.
2. Open the Package Manager Console in Visual Studio and execute the command `Update-Database`. This will create or update the database schema according to the current Entity Framework migrations.

## Running the Application
- **Saving Data:** Fill out the form and click the 'Save' button to save the data.
- **Editing Data:** Double-click on a cell in the data grid. The data will load into the form for editing. After making changes, click the 'Save' button to update the information.
- **Deleting Data:** Double-click on a cell in the data grid to enable the 'Delete' button. Click this button to delete the selected data.
- **Printing and Exporting Data:** Use the 'Print' and 'Export Csv' buttons to print or export the data currently loaded in the data grid. The data will be grouped by 'Staff Type' and ordered by 'First Name'.

## Architecture
- The project is implemented using a 3-tier architecture.
- It utilizes the Entity Framework with a 'Code First' approach.
- The DataAccess project employs the Repository design pattern for enhanced flexibility.
