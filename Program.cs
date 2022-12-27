using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy =>
   policy.RequireRole("Admin"));
});

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Hoteluri");
    options.Conventions.AuthorizeFolder("/Rezervari");
    options.Conventions.AuthorizeFolder("/Reviews");
    options.Conventions.AuthorizeFolder("/Orase");
    options.Conventions.AuthorizeFolder("/Tari");
    options.Conventions.AuthorizeFolder("/Membrii");
    options.Conventions.AllowAnonymousToPage("/Hoteluri/Index");
    options.Conventions.AllowAnonymousToPage("/Hoteluri/Details");
    options.Conventions.AllowAnonymousToPage("/Reviews/Index");
    options.Conventions.AllowAnonymousToPage("/Reviews/Details");
    options.Conventions.AuthorizeFolder("/Membri", "AdminPolicy");
    options.Conventions.AuthorizeFolder("/Tari", "AdminPolicy");
    options.Conventions.AuthorizeFolder("/Orase", "AdminPolicy");



});
builder.Services.AddDbContext<ProiectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProiectContext") ?? throw new InvalidOperationException("Connection string 'ProiectContext' not found.")));

builder.Services.AddDbContext<ProiectIdentityContextContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("ProiectContext") ?? throw new InvalidOperationException("Connectionstring 'ProiectContext' not found.")));
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()

 .AddEntityFrameworkStores<ProiectIdentityContextContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
