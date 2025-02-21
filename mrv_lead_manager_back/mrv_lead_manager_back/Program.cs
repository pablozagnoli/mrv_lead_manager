using mrv_lead_manager_back.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Chame o método AddApplicationServices para configurar as dependências
builder.Services.AddApplicationServices("Server=localhost;Database=MyDatabase;User Id=myUsername;Password=myPassword;");

builder.Services.AddCors(options =>
{
    options.AddPolicy("anyorigin", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("anyorigin");

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
