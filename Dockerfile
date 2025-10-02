# Используем .NET 8 SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файлы проекта
COPY *.csproj .
RUN dotnet restore
COPY . .

# Публикуем приложение
RUN dotnet publish -c Release -o /app

# Финальный образ с runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app .

# Открываем порт API
EXPOSE 5000
ENTRYPOINT ["dotnet", "CourseWorkPIPS.dll"]# Используем .NET 8 SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файлы проекта
COPY *.csproj .
RUN dotnet restore
COPY . .

# Публикуем приложение
RUN dotnet publish -c Release -o /app

# Финальный образ с runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app .

# Открываем порт API
EXPOSE 5000
ENTRYPOINT ["dotnet", "CourseWorkPIPS.dll"]