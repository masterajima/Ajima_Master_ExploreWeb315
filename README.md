# Ajima_Master_ExploreWeb315
Add-Migration InitialCreate
Update-Database
//login error
SqlException: Cannot open database "RazorPagesMovieContext-GUID" requested by the login. The login failed.
Login failed for user 'User-name'.
@page "{searchString?}"
Update-Database
[StringLength(60, MinimumLength = 3)]
[Required]
public string Title { get; set; }
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet-aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite
dotnet-aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite
dotnet-aspnet-codegenerator razorpage -h
