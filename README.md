**React with Asp.Net Core Full Stack**

This project demonstrates how to make Crud Application using Asp.net Core Entity Framework with React as Frontend application and Sqlserver Database.

**SETTING UP BACKEND CODE**
Pre-requisites - You should have VS 2022, SQL Server 2022 and SSMS installed in your local machine.

**Install the required Dependencies**

Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Newtonsoft.Json

**To establish Database Connection, Add the connection string of SQL Server running on your local machine to appsettings.json file and also to DbContect Class.**

After that Go to Tools->NuGet Package Manager->Package Manager Console, then in the console window type :- add-migration initial
Upon successful addition of migration files, type :- update-database
Now your database has been created. You just need to open the sqlserver and check the database that has been created.

**SETTING UP FRONTEND CODE**

Pre-requisites -  You should have Node JS, NPM and VS code installed in your local machine.

Refer to https://create-react-app.dev/docs/getting-started/ to getting started with REACT.

**Command for installing Axios and Bootstrap**
>npm i axios
>npm i bootstrap
