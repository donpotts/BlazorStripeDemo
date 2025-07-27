using BlazorStripeDemo.Components;
using BlazorStripeDemo.Services;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<StripeSettings>(
    builder.Configuration.GetSection("Stripe"));

// Configure Stripe
var stripeSecretKey = builder.Configuration["Stripe:SecretKey"]
    ?? throw new InvalidOperationException("Stripe SecretKey not found in configuration");

StripeConfiguration.ApiKey = stripeSecretKey;

//if (builder.Environment.IsProduction())
//{
//    // Add Azure Key Vault or other secure config providers
//    builder.Configuration.AddAzureKeyVault(/* your key vault config */);
//}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
