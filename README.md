# CAD Automation & REST API Orchestrator (PoC)

[![.NET 8](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12-green.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

An enterprise-grade proof of concept demonstrating the decoupling of heavy desktop CAD automation (Autodesk Inventor COM API) into scalable, asynchronous backend web services using **C#**, **.NET 8**, and **ASP.NET Core**.

---

## 🏗 Why This Architecture?
In heavy manufacturing and Engineer-to-Order (ETO) environments, CAD automation is often trapped in brittle, monolithic desktop scripts or manual macros. This project showcases how to modernize CAD workflows by:
1. **Decoupling execution:** Moving from local file-locking scripts to a clean REST API controller model.
2. **Eliminating license bottlenecks:** Utilizing dependency injection to swap real CAD engines with mocks for local testing and CI/CD pipelines.
3. **Ensuring memory safety:** Managing COM interop lifecycles explicitly to prevent memory leaks and orphaned background processes.

---

## 📂 Project Structure

```text
cad-automation-orchestrator/
├── src/
│ ├── CadAutomation.Core/ # Domain models, Request/Response DTOs, and Interfaces
│ │ ├── Interfaces/
│ │ └── Models/
│ ├── CadAutomation.Services/ # Business logic, COM memory cleaners, & Mock engines
│ │ ├── ComMemoryCleaner.cs
│ │ └── MockInventorService.cs
│ └── CadAutomation.Api/ # ASP.NET Core Web API controllers & startup configuration
│ └── Controllers/
└── README.md
