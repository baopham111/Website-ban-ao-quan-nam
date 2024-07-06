using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using website_ban_ao_quan_nam_bao;
using website_ban_ao_quan_nam_bao.Data;
using website_ban_ao_quan_nam_bao.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<CartService>();
builder.Services.AddSingleton<PaidProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
