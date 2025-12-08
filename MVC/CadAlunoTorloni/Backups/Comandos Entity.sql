dotnet tool uninstall --global dotnet-ef
dotnet nuget locals all --clear
dotnet tool install --global dotnet-ef --version 8.0.6
dotnet tool uninstall --global dotnet-ef
dotnet tool list --global 
dotnet tool install --global dotnet-ef --version 9.0.0


--                                     AQUI
dotnet ef dbcontext scaffold "Server=localhost,1433;User Id=sa; Password=Odr20aude07; Database=CadAlunoTorloni;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c CadAlunoTorloniContext --data-annotations -f