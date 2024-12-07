using DataLayer.DbRepository;
using Microsoft.EntityFrameworkCore;
using TradeHistory.Data.Interfaces;
using TradeHistory.Data.Services;
using TradeHistory.DbRepository;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddDbContext<HistoryDbContext>(options => options.UseNpgsql(connection));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IAccountDataService, AccountDataService>();
builder.Services.AddScoped<IDealDataService, DealDataService>();
builder.Services.AddScoped<IInstrumentDataService, InstrumentDataService>();
builder.Services.AddScoped<IPositionDataService, PositionDataService>();
builder.Services.AddScoped<IStrategyDataService, StrategyDataService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
