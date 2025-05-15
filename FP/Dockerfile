FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FP/FP.fsproj", "FP/"]
RUN dotnet restore "FP/FP.fsproj"
COPY . .
WORKDIR "/src/FP"
RUN dotnet build "FP.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FP.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FP.dll"]
