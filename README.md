# Puppies
dotnet aspnet-codegenerator Identity -dc PuppiesPet.Data.ApplicationDbContext --files "Account.Register;Account.Login"



dotnet aspnet-codegenerator controller -name ProductoController -m Producto -dc PuppiesPet.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries



dotnet ef migrations add SecondMigration --context PuppiesPet.Data.ApplicationDbContext -o "D:\gycy\Puppies\PuppiesPet\Data\Migrations"




dotnet aspnet-codegenerator identity -dc plantitas.Data.ApplicationDbContext --files "Account.Manage"