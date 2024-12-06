Basic Jwt with dotNet for beginners

1. Build the project file with VS2022 or command line `dotnet build`
2. Run the project or with `dotnet run`
3. POST 
{
  "username" : "admin",
  "password" : "password"
}
using curl to the localhost url (i.e. http://localhost:[port]/api/auth/login)
4. if step 3 succeeds, then try GETting secure data message from "http://localhost:[port]/api/secure/"
   
