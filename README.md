# EDU-ASP-NET-Core-Basic-Web-API

Microsoft ASP.NET Core tutorial overview: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api
In this project we weill use in-memory database to store records  

## Prerequisites

* [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)

## Installation
* Clone repository via command: "git clone https://github.com/Mikhail-Vilms/EDU-ASP-NET-Core-Basic-Web-API.git"
* Launch application via command executed from repository root folder: "dotnet run"

## Testing
- Create record by executing POST request with next parameters:
  - Target URL: https://localhost:5001/api/TodoItems
  - Body: {"name":"walk dog","isComplete":true}
- Retrieve record by its id by executing GET request with next parameters:
  - Target URL: https://localhost:5001/api/TodoItems/{targetId}
- Retrieve all existing records by executing GET request:
  - Target URL: https://localhost:5001/api/TodoItems
- Update existing record by executing PUT request:
  - Target URL: https://localhost:5001/api/TodoItems
  - Body: {"id": 1, "name":"walk dog updated","isComplete":true}