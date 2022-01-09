using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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
        FileName = "cmd",
        RedirectStandardInput = true,
        WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "client")
    })!.StandardInput.WriteLine("npm run serve");
}


app.MapGet("/api/test", () =>
{
    Console.WriteLine("/api/test route log.");
    return "Hello World!";
});

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

