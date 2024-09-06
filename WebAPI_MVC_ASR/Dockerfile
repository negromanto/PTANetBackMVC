#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

ENV DB_CONNECTION_STRING="Server=service-sql;Database=FeedsDB;trustServerCertificate=true;User Id=sa;Password=BDasr*123456;MultipleActiveResultSets=true"

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WebAPI_MVC_ASR/WebAPI_MVC_ASR.csproj", "WebAPI_MVC_ASR/"]
RUN dotnet restore "WebAPI_MVC_ASR/WebAPI_MVC_ASR.csproj"
COPY . .
WORKDIR "/src/WebAPI_MVC_ASR"
RUN dotnet build "WebAPI_MVC_ASR.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAPI_MVC_ASR.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI_MVC_ASR.dll"]