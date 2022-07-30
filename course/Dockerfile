#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["course/course.csproj", "course/"]
COPY ["CourseModels/CourseModels.csproj", "CourseModels/"]
COPY ["CourseBusnies/CourseBusnies.csproj", "CourseBusnies/"]
COPY ["CouseCommon/CouseCommon.csproj", "CouseCommon/"]
COPY ["CourseDataAccess/CourseDataAccess.csproj", "CourseDataAccess/"]
RUN dotnet restore "course/course.csproj"
COPY . .
WORKDIR "/src/course"
RUN dotnet build "course.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "course.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "course.dll"]