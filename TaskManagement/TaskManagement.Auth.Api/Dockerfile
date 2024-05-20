# Utiliza una imagen base de SDK de .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Define el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia el archivo csproj y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia todos los archivos y compila la aplicación
COPY . .
RUN dotnet build -c Release -o /app/build

# Publica la aplicación
RUN dotnet publish -c Release -o /app/publish

# Etapa de producción
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TaskManagement.Auth.Api.dll"]
