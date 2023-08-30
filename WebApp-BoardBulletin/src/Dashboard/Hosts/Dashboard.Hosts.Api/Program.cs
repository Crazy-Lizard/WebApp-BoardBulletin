using Dashboard.Contracts;
using Dashboard.Contracts.Attachment;
using Dashboard.Hosts.Api.Controllers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(s =>
{
    var includeDocsTypesMarkers = new[]
    {
        typeof(PostDto),
        typeof(PostController)
    };

    foreach (var marker in includeDocsTypesMarkers)
    {
        var xmlName = $"{marker.Assembly.GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlName);

        if (File.Exists(xmlPath))
            s.IncludeXmlComments(xmlPath);
    }
});

//builder.Services.AddSwaggerGen(options =>
//{
//    //using System.Reflection;
//    var hostsXmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, hostsXmlFilename));

//    var referencedAssemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
//    foreach (var referencedAssembly in referencedAssemblies)
//    {
//        if (!referencedAssembly.Name!.Contains("BulletinBoard"))
//            continue;
//        var xmlFilename = $"{referencedAssembly.Name}.xml";
//        options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
//    }
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
