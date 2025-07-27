# Blazor Stripe Demo

**Note:** This site is for demo purposes only. No products are actually purchased.

![Demo](./Assets/BlazorStripeDemo.gif)

A modern sample application demonstrating how to integrate Stripe payments with a Blazor Server app using .NET 9.

## 🚀 Features
- Blazor Server-side UI
- Stripe payment integration
- Modern .NET 9 stack
- Clean, modular code structure

## 🛠️ Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Stripe account](https://dashboard.stripe.com/register)

### Setup
1. Clone this repository:
   ```bash
   git clone https://github.com/donpotts/BlazorStripeDemo.git
   cd BlazorServerStripeApp
   ```
2. Configure your Stripe API keys:
   - Set your Stripe `SecretKey` and `PublishableKey` in `appsettings.json` or via [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets).
   - Example:
     ```json
     "Stripe": {
       "PublishableKey": "pk_test_...",
       "SecretKey": "sk_test_..."
     }
     ```
3. Run the app:
   ```bash
   dotnet run --project BlazorStripeDemo.csproj
   ```
4. Open your browser at the URL shown in the console (e.g., https://localhost:7278).

## ⚙️ Configuration
- All Stripe settings are managed in `appsettings.json` or via User Secrets for development.
- See `Services/StripeSettings.cs` for strongly-typed configuration.

## 🧰 Technologies Used
- .NET 9
- Blazor Server
- Stripe .NET SDK

## 🙏 Acknowledgements
- [Stripe](https://stripe.com/docs)
- [Microsoft Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)

---

Created by [Don Potts](https://www.donpotts.com) — Powered by Blazor Server and Stripe Payments