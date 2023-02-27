using WatchDog;

var builder = WebApplication.CreateBuilder(args);

// configurazione dei servizi MVC per le funzionalità usate tramite controller API
builder.Services.AddControllers();

// servizio necessario per la documentazione automatica delle API usata da Swagger
builder.Services.AddEndpointsApiExplorer();

// abilitazione il supporto a Swagger
builder.Services.AddSwaggerGen();

// abilitazione il supporto al logging delle chiamate
builder.Services.AddWatchDogServices();

var app = builder.Build();

// attivazione Swagger solo in ambiente di sviluppo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// configurazione del logging delle chiamate
// https://localhost:[your-port]/watchdog
app.UseWatchDog(opt =>
{
    opt.WatchPageUsername = "admin";
    opt.WatchPagePassword = "admin";
});

// abilita https
app.UseHttpsRedirection();

// registrazione degli endpoint delle varie API
app.MapControllers();

app.Run();
