# ApiRestCoreAspiria
Net Core 3.1 CRUD mediante Api Rest con conexion a SqlServer

1.-Ejecutar archivo Script de la base de datos "CRUDAspiria.sql" para la conexión con SqlServer.
2.-Modificar en "ApiRestCoreAspiria/Models/CRUDAspiriaContext.cs" el nombre del servidor (linea 27), se encuentra asi: "Server=LAPTOP-AOQJ9PD7".
3.-Modificar en "BlazorCRUDAspiria/appsettings.json" el nombre del servidor (linea 3), se encuentra asi: "Server=LAPTOP-AOQJ9PD7".
4.-Corroborar el puerto en el que esta corriendo la api, en "BlazorCRUDAspiria/Startup.cs", se encuentra asi: "BaseAddress = new Uri("https://localhost:44388")" (linea 55).
5.-Ejecutar primero el Api y luego Blazor.
