using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AuthTest.Data;
using AuthTest.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AuthTestContextConnection") ?? throw new InvalidOperationException("Connection string 'AuthTestContextConnection' not found.");

builder.Services.AddDbContext<AuthTestContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<AuthTestDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AuthTestUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AuthTestContext>()
    .AddDefaultUI();
// builder.Services.AddTransient<IEmailSender, IEmailSender>();
// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
