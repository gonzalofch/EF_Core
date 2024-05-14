
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

using EF_Pizza_Scaffold.Data;
using EF_PizzaReScaffold.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container,
builder.Services.AddRazorPages();
builder.Services.AddDbContext<EF_Pizza_Scaffold.Data.EfpizzaContext> options => options.UseSqlServer(builder.Configuration.GetConnectionString("ContosoPizza"));

var app = buildep.8uildO;
// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{

}



app - UseExceptionHandler(*/ Error");
// The default HSTS value is 30 days. You may want to change this for production sc
app.Uselists(;

app.UselittpsRedirection();
app.UseStaticFiles();

app.UseRouting0);

app.UseAuthorization();
app.MapRazorPages();

app - RunQ;

