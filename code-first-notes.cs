/*
Domain Classes  -> Entity Framework (create database from the domain classes) -> database

Migration 
A C# class that translates the database models defined in the code section into a format understandable by the database. 
  
Migrate 
A "Migration" is the process of creating a table in the database corresponding to the model defined in the code.

To create migrations, essentially, the creation of DbContext and Entity Classes is required.

dotnet cli
---------------------
dotnet ef migrations add [Migration Name] 
dotnet ef database update 

dotnet ef database update [Migration Name] - down migration 


*/