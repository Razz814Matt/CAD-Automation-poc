using CadAutomation.Core.Interfaces;
using CadAutomation.Services;

var builder = webAppplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.isDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
