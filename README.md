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
