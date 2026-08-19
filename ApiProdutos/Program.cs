using System.Reflection;
using ApiProdutos.Repositories;
using Microsoft.OpenApi;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<ProdutoRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Produtos",
        Version = "v1",
        Description = "API REST para cadastro e gerenciamento de produtos."
    });
    var nomeXml = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var caminhoXml = Path.Combine(AppContext.BaseDirectory, nomeXml);
    if (File.Exists(caminhoXml))
        options.IncludeXmlComments(caminhoXml);
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json",
            "API de Produtos v1");
    });
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();