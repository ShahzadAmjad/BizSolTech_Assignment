using System;

var builder = WebApplication.CreateBuilder(args);


//// Add services to the container.
//builder.Services.AddControllersWithViews();

////db connection string

//builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ETL_DBConnection"), sqlServerOptions => sqlServerOptions.CommandTimeout(60)));

//builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

//builder.Services.AddScoped<IServiceRepository, SQLServiceRepository>();



var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.UseMvcWithDefaultRoute();


//app.MapGet("/", () => "Hello World!");

app.Run();
