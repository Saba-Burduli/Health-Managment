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
<h2>Solution Structure (Example Layout)</h2>

      /HealthManagementSystem.sln
    │
    ├── /HealthManagement.Gateway             ← API Gateway (YARP-based or custom)
    │   └── Program.cs / Startup.cs
    │
    ├── /HealthManagement.API                 ← Main API for handling core business logic
    │   ├── Controllers/
    │   ├── DTOs/
    │   ├── Services/
    │   └── Program.cs / Startup.cs
    │
    ├── /HealthManagement.Worker              ← Background worker services (long-running tasks)
    │   ├── Services/
    │   └── Worker.cs (inherits from BackgroundService)
    │
    ├── /HealthManagement.SERVICE             ← Shared logic, domain models, utilities
    │   ├── Interfaces/
    │   ├── Services/
    │   └── Hashing/
    │       └── ConsistentHashRing.cs
    │
    ├── /HealthManagement.DAL                 ← Data access layer (persistence)
    │   ├── Repositories/
    │   ├── DbContext/
    │   ├── Entities/
    │   └── Cassandra/ or MSSQL/
