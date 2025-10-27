# 🚆 TrainSchedule Automation Framework
*A .NET Test Automation Demo by Faraaz Husain*

This project simulates a lightweight version of V/Line’s **TrackR** test environment.  
It demonstrates professional **.NET test automation** using modern frameworks and data-generation tools.

---

## 🧱 Project Overview
The solution contains two projects:

| Project | Purpose |
|----------|----------|
| **TrainSchedule** | Core business logic for managing train schedules. |
| **TrainSchedule.Tests** | Automated unit + integration tests validating system behaviour. |

---

## 🧰 Tech Stack
| Area | Tool | Description |
|-------|-------|-------------|
| Test Framework | **xUnit** | Core testing framework. |
| Assertions | **Shouldly** | Human-readable assertions (`result.ShouldBe(expected)`). |
| Mocking | **Moq** | Mocks repositories / APIs for isolation. |
| Data Generation | **AutoFixture** | Automatically creates structured test objects. |
| Realistic Data | **Bogus** | Generates real-world-like destinations & times. |
| Language / Platform | **C# / .NET 9** | Implemented using the latest .NET SDK. |

---

## ⚙️ Running the Tests
1. Ensure .NET 9 SDK is installed  
   ```bash
   dotnet --info
   ```
2. Clone this repository  
   ```bash
   git clone https://github.com/<your-github-username>/TrainScheduleDemo.git
   cd TrainScheduleDemo
   ```
3. Run all tests  
   ```bash
   dotnet test
   ```
4. You’ll see output like:
   ```
   🚆 Generated Train Schedule Data:
   ID: 0 | Destination: Ballarat | Departure: 09:45 AM
   ID: 1 | Destination: Geelong | Departure: 11:15 AM
   ...
   ```

---

## 🧠 Concepts Demonstrated
- Unit & Integration Testing  
- Mocking and Dependency Injection  
- Data-Driven Testing  
- AI-Assisted Development (Copilot / Cursor)  
- CI/CD Integration (`dotnet test` in Azure DevOps YAML)

---

## 🧩 Azure DevOps CI/CD Integration
This project includes an example **Azure DevOps pipeline configuration** file — [`azure-pipelines.yml`](./azure-pipelines.yml) — to demonstrate how automated builds and test runs could be integrated into a real-world CI/CD process.

The pipeline performs the following steps:
1. **Restore dependencies** – Downloads NuGet packages.  
2. **Build** – Compiles the solution in `Release` mode.  
3. **Test** – Executes all `xUnit` tests with full logging and code coverage.  
4. **Publish Results** – Uploads test results and coverage data to the Azure DevOps dashboard.  
5. **Artifacts** – Optionally stores compiled outputs for downstream deployments.

This configuration is fully functional and can be connected to an Azure DevOps project by linking your GitHub repository, but it’s included here primarily to illustrate **CI/CD best practices** for automated testing.

> 💡 Even without an active Azure DevOps account, this file showcases familiarity with professional .NET test automation pipelines and cloud-based DevOps workflows.

---

## 🗣️ Interview Summary
> “I built a .NET automation project that simulates a train scheduling system.  
> It uses xUnit + Shouldly for tests, AutoFixture for data scaffolding, Bogus for realistic inputs, and Moq for dependency mocking.  
> The suite runs automatically through `dotnet test`, demonstrating maintainable and scalable test automation aligned with TrackR-style systems.”

---

## 👨‍💻 Author
**Faraaz Husain**  
Melbourne, Australia  
[LinkedIn](https://www.linkedin.com/in/faraazhusain)
