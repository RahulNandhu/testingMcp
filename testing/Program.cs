using testing.Interfaces;
using testing.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(Int32.Parse(port));
});

//builder.Services.AddMcpSharp(options =>
//{
//    options.AddToolsFrom<IMCPTools>();
//});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICommonServices, CommonServices>();
builder.Services.AddScoped<IMCPTools, MCPTools>();
builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithTools<MCPTools>();




var app = builder.Build();

//app.UseMcpSharp();
// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


//app.UseHttpsRedirection();

app.UseCors(policy =>
  policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
);


app.UseAuthorization();

app.MapControllers();

app.MapMcp();

app.Run();
