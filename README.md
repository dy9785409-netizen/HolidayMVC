# Holiday Management System

A web-based Holiday Management System developed using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQL Server**. The application allows users to manage holiday records with complete CRUD functionality through a clean and responsive user interface.

## Features

- Add New Holiday
- View Holiday List
- Update Holiday Details
- Delete Holiday
- Form Validation
- Responsive UI with Bootstrap
- SQL Server Database Integration
- Entity Framework Core Code First Approach

## Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- Bootstrap 5
- HTML5
- CSS3
- Visual Studio 2022

## Project Structure

```
HolidayMVC
│
├── Controllers
├── Models
├── Views
├── Data
├── wwwroot
├── appsettings.json
├── Program.cs
└── README.md
```

## Database

This project uses **SQL Server** with **Entity Framework Core (Code First)**.

Example Holiday Table Fields:

- Id
- EnglishName
- ArabicName
- FromDate
- ToDate
- UserId

## Installation

### 1. Clone the Repository

```bash
git clone https://github.com/dy9785409-netizen/HolidayMVC.git
```

### 2. Open the Project

Open the solution in **Visual Studio 2022**.

### 3. Update Connection String

Update the SQL Server connection string in **appsettings.json**.

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=HolidayDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4. Apply Migrations

Run the following command:

```powershell
Update-Database
```

### 5. Run the Application

Press **F5** or click **Start** in Visual Studio.

## Future Enhancements

- User Authentication & Authorization
- Role-Based Access (Admin/User)
- Holiday Search & Filter
- Export Holidays to Excel/PDF
- Dashboard with Statistics
- API Integration

## Author

**Dinesh Kumar**

GitHub: https://github.com/dy9785409-netizen

---

⭐ If you found this project useful, consider giving it a star on GitHub.
