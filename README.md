<div align="center">

[![Language][language-shield]][language-url]
[![Language][languageH-shield]][languageH-url]
[![Language][languageC-shield]][languageC-url]
[![MIT License][license-shield]][license-url]

# Travel Reviews

</div>

#### an Epicodus project that allows the user to log and view travel Reviews

#### Created By: Chynna Lew and Paige Tiedeman

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* PostMan

## Description

This application was created to show proficiency in ASP.Net Core MVC API creation and access using mySql, Entity, and Razor. This app allows the user full CRUD functionality for their own reviews and search functionality for all reviews in the API.

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/chynnalew/Travel.Solution) repository, or download and open the Zip on your local machine
* Open the Travel.Solution folder in your preferred text editor
* To install required packages, navigate to Travel.Solution/Travel in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
* Create a file named "appsettings.json" in the Travel directory
  - add the following code to the appsettings.json file:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_reviews;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command `$ mySql -uroot -p[YOUR-PASSWORD-HERE]`, replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required API database:
  - In the terminal, navigate to Travel.Solution/Travel and run the command:
    - dotnet ef database update
* To Make Changes to the API Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to Travel.Solution/Travel:
    - `dotnet ef migrations add YourDescriptionHere`
    - `dotnet ef database update`
* To Restore, build, and launch the API project:
  - Navigate to the Travel.Solution/Travel folder in the command line or terminal
    - Run the command `$ dotnet restore` to restore the project dependencies
    - Run the command `$ dotnet build` to build and compile the project
    - Run the command `$ dotnet run` to build and compile the project
    - The ASP.NET Core MVC is viewable in the browser at http://localhost:5000 
    - Open postman 
    - If the styling is not appearing in the browser, open http://localhost:5000 in an incognito browser

## Review API Endpoints

Base URL: `http://localhost:5004`

#### HTTP Requests
```
GET /api/reviews
POST /api/reviews
GET /api/reviews/{id}
PUT /api/reviews/{id}
```
#### Path Parameters
| Parameter | Type | Description |  
| :---: | :---: | --- |
| name | string | Returns any review by Landmark names (i.e. Grand Canyon) |  
| city | string | Returns any review by city name |  
| country | string | Returns any review by country name |  
| rating | int | Returns any review with that number rating |  
| description | string | Returns any review by description |  

#### Example Query
```
http://localhost:5000/api/reviews/?city=flagstaff
```

#### Sample JSON
```
    {
        "reviewId": 1,
        "name": "San Francisco Peaks",
        "city": "Flagstaff",
        "country": "USA",
        "rating": 5,
        "description": "that's a mountain, alright!",
        "image": null
    }
```

## Known Bugs

* none at this time

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew, Paige Tiedeman

## Support and contact details

* [Chynna Lew](github.com/chynnalew) <ChynnaLew@yahoo.com>
* [Paige Tiedeman](github.com/paigetiedeman)  


[license-shield]: https://img.shields.io/badge/License-MIT-blue
[license-url]: https://opensource.org/licenses/MIT
[language-shield]: https://img.shields.io/badge/Language-C%23-green
[language-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[LanguageH-shield]: https://img.shields.io/badge/Language-HTML-red
[LanguageH-url]: https://developer.mozilla.org/en-US/docs/Web/HTML
[LanguageC-shield]: https://img.shields.io/badge/Language-CSS-blueviolet
[LanguageC-url]: https://developer.mozilla.org/en-US/docs/Web/CSS