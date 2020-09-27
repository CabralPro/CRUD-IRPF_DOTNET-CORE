# dotnet build
# dotnet run
# dotnet watch run
# dotnet ef database update  
  create db

# dotnet new classlib -n CrudIrpf.Domain   
# dotnet new sln -n CrudIrpf.Domain   


# dotnet add CrudIrpf.Repository/CrudIrpf.Repository.csproj reference CrudIrpf.Domain/CrudIrpf.Domain.csproj

# dotnet add CrudIrpf.WebAPI/CrudIrpf.WebAPI.csproj reference CrudIrpf.Domain/CrudIrpf.Domain.csproj

# dotnet sln CrudIrpf.sln add CrudIrpf.Domain/CrudIrpf.Domain.csproj CrudIrpf.Repository/CrudIrpf.Repository.csproj CrudIrpf.WebAPI/CrudIrpf.WebAPI.csproj

# dotnet ef --startup-project ../CrudIrpf.WebAPI migrations add init
  Dentro do Repository


# dotnet ef --startup-project ../CrudIrpf.WebAPI database update


