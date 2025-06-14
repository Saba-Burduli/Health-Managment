<h2>High-Level Architecture</h2>
                      
                      ┌─────────────────────────────────────┐
                      │          API Gateway (YARP)         │
                      │    - Handles incoming HTTP calls    │
                      │    - Applies Consistent Hashing     │
                      │    - Forwards requests to Workers   │
                      └─────────────────────────────────────┘
                                    │
        ┌───────────────────────────┼────────────────────────────┐
        │                           │                            │
    ┌───────────────┐        ┌────────────────────┐        ┌────────────────────┐
    │  Worker A     │        │    Worker B        │        │    Worker C        │
    │ (Background   │        │ (Background        │        │ (Background        │
    │  Service App) │        │  Service App)      │        │  Service App)      │
    └───────────────┘        └────────────────────┘        └────────────────────┘
            │                           │                            │
            └──────────────┬────────────┴────────────┬──────────────┘
                           ▼                         ▼
                 ┌────────────────────┐     ┌────────────────────┐
                 │      Database      │     │   Message Queue     │ (optional)
                 └────────────────────┘     └────────────────────┘
Solution Structure (Example Layout)

          /HealthManagementSystem.sln
    │
    ├── /HealthManagement.Gateway       ← API Gateway (YARP-based or custom)
    │   └── Program.cs / Startup.cs
    │
    ├── /HealthManagement.API           ← API that receives core business requests
    │   ├── Controllers/
    │   ├── Services/
    │   ├── DTOs/
    │   └── Program.cs / Startup.cs
    │
    ├── /HealthManagement.Worker        ← Background worker service(s)
    │   ├── Services/
    │   └── Worker.cs (inherits from BackgroundService)
    │
    ├── /HealthManagement.Core          ← Shared logic, domain models, interfaces
    │   ├── Entities/
    │   ├── Interfaces/
    │   └── Hashing/ConsistentHashRing.cs
    │
    ├── /HealthManagement.Infrastructure← Data access, persistence, external calls
    │   ├── Repositories/
    │   ├── DbContext/
    │   └── Cassandra/MSSQL/etc.
