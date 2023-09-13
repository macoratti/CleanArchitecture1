var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.ConfigurePersistenceApp(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//CreateDatabase(app);

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();

//static void CreateDatabase(WebApplication app)
//{
//    var serviceScope = app.Services.CreateScope();
//    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
//    dataContext?.Database.EnsureCreated();
//}