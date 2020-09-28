# dotnet build
# dotnet run
# dotnet watch run
# dotnet ef database update  
  cria db (executar dentro do WebAPI )

# dotnet new classlib -n CrudIrpf.Domain   
# dotnet new sln -n CrudIrpf.Domain   
# dotnet add CrudIrpf.Repository/CrudIrpf.Repository.csproj reference CrudIrpf.Domain/CrudIrpf.Domain.csproj

# dotnet add CrudIrpf.WebAPI/CrudIrpf.WebAPI.csproj reference CrudIrpf.Domain/CrudIrpf.Domain.csproj

# dotnet sln CrudIrpf.sln add CrudIrpf.Domain/CrudIrpf.Domain.csproj CrudIrpf.Repository/CrudIrpf.Repository.csproj CrudIrpf.WebAPI/CrudIrpf.WebAPI.csproj

# dotnet ef --startup-project ../CrudIrpf.WebAPI migrations add init
  Executar Dentro do Repository

# dotnet ef --startup-project ../CrudIrpf.WebAPI database update
  Executar Dentro do Repository

# dotnet publish -o ./dist
# dotnet CrudIrpf.WebAPI.dll

