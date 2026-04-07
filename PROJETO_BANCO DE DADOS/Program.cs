using PROJETO_BANCO_DE_DADOS.Models;
using PROJETO_BANCO_DE_DADOS.Repository;
using PROJETO_BANCO_DE_DADOS.Repository.Contrato;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adicionando a interface como serviço
builder.Services.AddScoped<IUsuariorepository, UsuarioRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
