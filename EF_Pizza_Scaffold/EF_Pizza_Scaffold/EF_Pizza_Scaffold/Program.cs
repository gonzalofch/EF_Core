// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//DESCRIPCION DE PASOS 
/*
 PARA TRAER UNA BASE DE DATOS A CLASES 
Scaffold-DbContext "String de conexion a base de datos" -ContextDir NombreCarpetaDondeSeGuardaElContext (Por convencion Data) -OutputDir NombreCarpeta (Models , es donde se guardan las clases que trae informacion de las tablas de la db)
//De esta manera nos trae unos archivos donde guarda las configuraciones aparte del data anotations descripciones de los campos como por ejemplo el decimal, required, etc

 Scaffold-DbContext "Server=localhost,1434;Database=EFPizza;User=sa;Password=SqlServer_Docker2024;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotations
// con el -DataAnnotations trae las anotaciones de cada campo dentro de la clase, que es lo mismo


//SI SE REALIZAN CAMBIOS DE CONFIGURACION DE LOS DATOS (COLUMNAS) 
//HAY DOS MANERAS DE HACER QUE NOS LLEGUEN LOS CAMBIOS

//HACERLO MANUAL

//BORRAR LO QUE YA TENÍAMOS (DATA Y MODELS) Y RE SCAFFOLDEAR LA BASE DE DATOS
 */