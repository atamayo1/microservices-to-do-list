# Dockerfile
FROM mcr.microsoft.com/dotnet/core/sdk:latest AS build
WORKDIR /app

# Copiar archivos del proyecto y restaurar dependencias
COPY . .
RUN dotnet restore

# Compilar la aplicación
RUN dotnet build -c Release -o out

# Ejecutar la aplicación
CMD ["dotnet", "out/ToDoList.dll"]
