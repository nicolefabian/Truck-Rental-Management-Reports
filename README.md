# Truck Rental Management System - Reports
A .NET 6.0 desktop application created with WPF, XAML, C#, SQL stored procedures, Entity Framework.

## Introduction
This application displays 5 different reports from multiple entities showed using SQL stored procedures for Administrator Functionality. 

Packages installed using Tools> Nuget Package Manager > Manage Nuget Packages for Solution
* Microsoft.EntityFrameworkCore (7.0)
* Microsoft.EntityFramework.SqlServer (7.0)
* Microsoft.EntityFramework.Tools (7.0)

Scaffold-Command
```
Scaffold-DbContext "Server=citizen.manukautech.info,6306;Initial Catalog=DAD_Nicole;Persist Security Info=True;User ID=DAD_Nicole;Password=DAD_1935;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -Tables IndividualTruck-PB, TruckModel-PB, TruckFeature-PB, TruckRental-PB, TruckPerson-PB, TruckCustomer-PB, TruckEmployee-PB, Truck_Feature_Association-PB -OutputDir Models/DB
```

## Installation
* Clone repository using this link:
```
 https://github.com/nicolefabian/Truck-Rental-Management-Reports.git
 ```
 * Run MainWindows.xaml to start the application


## Top Rented Trucks
![TopRentedTrucks](https://user-images.githubusercontent.com/102332600/219547972-00fbe127-98b3-445d-8a5c-3d509cad5e85.png)

## Least Rented Trucks
![LeastRentedTrucks](https://user-images.githubusercontent.com/102332600/219548217-1ac7223f-89f3-4251-96cd-f245a88d0062.png)

## Month Total Sale
![MonthTotalSale](https://user-images.githubusercontent.com/102332600/219548453-01116c03-c72a-497e-a2d2-28e8c833a4e4.png)

## Selected Date Range
![SelectedDateRange](https://user-images.githubusercontent.com/102332600/219548721-67fbdefa-a3d3-436c-9830-9b8b6390d3f7.png)



