# 🚀 Notification Web API - Minimal API with Factory Pattern

This is a simple ASP.NET Core Minimal Web API demonstrating the **Factory Pattern** to switch between different types of notification services (e.g., Email, SMS).

## ✨ Features

- Minimal API (`Program.cs` only)
- Factory Pattern for service creation
- Supports Email and SMS (via console logging)

## 🎯 Goal
Expose a /send endpoint that accepts a notification type (email or sms) and sends a message using the Factory Pattern.

## 📦 Requirements

- .NET 6 or later

## 🛠 How to Run

```bash
dotnet run
