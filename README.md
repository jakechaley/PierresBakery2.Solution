# Pierre's Bakery 2.0

#### By Jake Haley

#### Application using Authorization and Autentication to let a user Create, Update, and Delete flavors and Treats.

## Technologies Used

* C#
* .NET
* Microsoft Entity FrameworkCore
* Microsoft Identity 
* Razor
* ASP.NET MVC 
* MySQL WorkBench

## Description

This project is a continuation of using MAny-to-Many relationships. This time around it includes authentication and authorization.

## Setup/Installation Requirements

* To use this application you have to have MySql Workbench installed. Follow setup instructions [here!](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Clone this repository down to your local machine.
* In the top directory (PierresBakery2.Solution) create an appsettings.json file with the following information `{ "ConnectionStrings":{ "DefaultConnection":"Server=localhost;Port=3306;database=firstname_lastname;uid=root; pwd=[YOURPASSWORDHERE];" } }`
* Save this file then navigate to the main project folder by typing `cd PierresBakery` into your terminal.
* Type `dotnet restore` into the terminal to install project dependencies.
* Type `dotnet ef database update` into the terminal to ensure database is properly connected.
* To run program, type `dotnet run` into the terminal in the main project folder. (PierresBakery)


## Known Bugs

* No Known Issues yet!
* Please Let me know if any are found.

## License

ISC License

Copyright (c) [2022] [Jake C. Haley]

Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.