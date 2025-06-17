# 🚀 Notification Web API - Minimal API with Factory Pattern

This is a simple ASP.NET Core Minimal Web API demonstrating the **Factory Pattern** to switch between different types of notification services (e.g., Email, SMS).
The Factory Pattern is a creational design pattern that provides a way to create objects without specifying the exact class of the object being created.


## 🔍 Real-World Analogy
Imagine you own a pizza store. When someone orders a pizza, they might choose:

Cheese pizza
Pepperoni pizza
Veggie pizza

You don’t want the customer to know how the pizza is made — they just say what they want, and the kitchen (factory) handles the rest.
The kitchen is the factory: it knows how to create different types of pizza and gives back the right one. We can easly create a new pizza without

## ✅ When to Use the Factory Pattern
Use it when:

You have a superclass/interface with multiple subclasses.
You want to hide the instantiation logic from the client.
You need to choose a concrete class based on input, environment, or logic.

Hide the object creation (implementation) from the client code, and let a factory method decide which class to instantiate based on some input or logic.

## ✨ Features

- Minimal API (`Program.cs` only)
- Factory Pattern for service creation
- Supports Email and SMS (via console logging)

## 🎯 Goal
Expose a /send endpoint that accepts a notification type (email or sms) and sends a message using the Factory Pattern.

## 📦 Requirements

- .NET 9 or later

## 🛠 How to Run

```bash
dotnet run
