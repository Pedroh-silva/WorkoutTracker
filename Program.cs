using Workout_Tracker.Data;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Services;
using Workout_Tracker.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connection = builder.Configuration["MySQlConnection:MySQlConnectionString"];
builder.Services.AddDbContext<WorkoutTrackerDbContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 29))));
builder.Services.AddScoped<WorkoutService>();
builder.Services.AddScoped<ExerciseService>();
builder.Services.AddScoped<MuscleService>();
//builder.Services.AddScoped<SeedingService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();//
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

