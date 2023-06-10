using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

// Run the serve command when running in development mode.
if (app.Environment.IsDevelopment())
{
    Process.Start(new ProcessStartInfo
    {
        FileName = OperatingSystem.IsWindows() ? "cmd" : "bash",
        RedirectStandardInput = true,
        WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "client")
    })!.StandardInput.WriteLine("npm run serve");
}

app.MapControllerRoute("default", "api/{controller=Home}/{action=Index}/{id?}");

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();

app.Run();
