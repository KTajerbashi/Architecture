# 🏗️ Architecture

> **A living .NET architecture reference and engineering patterns laboratory.**

This repository is a continuously evolving collection of **software architecture patterns, engineering practices, infrastructure techniques, security patterns, distributed-system patterns, and reusable .NET building blocks**.

This is **not a business application**.

There is intentionally no specific business domain. Instead, the goal is to provide a practical environment where architectural concepts and real-world engineering techniques can be designed, implemented, tested, compared, and evolved.

---

## 🎯 Purpose

Software architecture is not about finding one "perfect" structure.

Every architecture exists to solve specific problems and introduces its own trade-offs.

The purpose of this repository is to document and implement those solutions through practical .NET examples.

The repository evolves as new technologies, patterns, lessons learned, and engineering practices are encountered in real-world software development.

### The main goals are:

* Explore modern software architecture
* Implement architectural patterns in real code
* Understand architectural trade-offs
* Experiment with distributed systems
* Build reusable .NET infrastructure
* Validate architectural rules automatically
* Document architectural decisions
* Keep practical examples of lessons learned
* Provide a reference for future projects

---

# 🧭 Architecture Philosophy

The core philosophy of this repository is:

> **Problem → Pattern → Implementation → Trade-offs → Tests → Decision**

Instead of simply demonstrating a technology, each important implementation should answer:

1. What problem does it solve?
2. Why is this pattern appropriate?
3. How is it implemented?
4. What are the alternatives?
5. What are the trade-offs?
6. When should it be used?
7. When should it NOT be used?
8. How can the architecture be tested?

---

# 🏛️ Architecture Areas

The repository is organized around architectural concerns rather than a single business domain.

| Area                      | Description                                     | Status |
| ------------------------- | ----------------------------------------------- | ------ |
| Clean Architecture        | Dependency inversion and separation of concerns | 🚧     |
| DDD                       | Strategic and tactical Domain-Driven Design     | 🚧     |
| CQRS                      | Command and Query separation                    | 🚧     |
| Modular Monolith          | Modular application architecture                | 🚧     |
| Microservices             | Distributed service architecture                | 🚧     |
| Event-Driven Architecture | Event-based communication                       | 🚧     |
| Event Sourcing            | Event-based state management                    | 🚧     |
| Authentication            | Identity and authentication patterns            | 🚧     |
| Authorization             | RBAC, policies and permissions                  | 🚧     |
| JWT                       | Token-based authentication                      | 🚧     |
| JWE                       | Encrypted JSON Web Tokens                       | 🚧     |
| OAuth 2.0                 | Authorization framework                         | 🚧     |
| OpenID Connect            | Identity layer                                  | 🚧     |
| Message Broker            | Asynchronous communication                      | 🚧     |
| Outbox Pattern            | Reliable event publishing                       | 🚧     |
| Inbox Pattern             | Reliable message processing                     | 🚧     |
| Saga                      | Distributed transaction coordination            | 🚧     |
| Idempotency               | Safe repeated operations                        | 🚧     |
| Redis                     | Distributed caching                             | 🚧     |
| Entity Framework Core     | Persistence patterns                            | 🚧     |
| SQL Server                | Relational persistence                          | 🚧     |
| Docker                    | Containerization                                | 🚧     |
| Kubernetes                | Container orchestration                         | 🚧     |
| OpenTelemetry             | Observability                                   | 🚧     |
| Testing                   | Unit, integration and architecture testing      | 🚧     |
| CI/CD                     | Automated build and deployment                  | 🚧     |

> 🚧 = Under development
> ✅ = Implemented
> 🧪 = Experimental

---

# 📁 Repository Structure

The target structure of the repository is organized into independent architectural areas:

```text
Architecture/
│
├── .github/
│   ├── workflows/
│   └── ISSUE_TEMPLATE/
│
├── docs/
│   ├── architecture/
│   │   ├── c4/
│   │   └── diagrams/
│   │
│   ├── adr/
│   └── principles/
│
├── building-blocks/
│   ├── domain/
│   ├── application/
│   ├── infrastructure/
│   └── cross-cutting/
│
├── patterns/
│   ├── clean-architecture/
│   ├── hexagonal/
│   ├── onion/
│   ├── ddd/
│   ├── cqrs/
│   ├── event-driven/
│   ├── event-sourcing/
│   ├── modular-monolith/
│   └── microservices/
│
├── security/
│   ├── authentication/
│   ├── authorization/
│   ├── jwt/
│   ├── jwe/
│   ├── oauth2/
│   └── oidc/
│
├── messaging/
│   ├── rabbitmq/
│   ├── kafka/
│   ├── outbox/
│   ├── inbox/
│   ├── retry/
│   └── dead-letter/
│
├── persistence/
│   ├── ef-core/
│   ├── sql-server/
│   ├── postgresql/
│   ├── mongodb/
│   └── redis/
│
├── distributed-systems/
│   ├── idempotency/
│   ├── distributed-lock/
│   ├── distributed-cache/
│   ├── saga/
│   ├── resilience/
│   └── eventual-consistency/
│
├── observability/
│   ├── logging/
│   ├── metrics/
│   ├── tracing/
│   ├── health-check/
│   └── opentelemetry/
│
├── testing/
│   ├── unit/
│   ├── integration/
│   ├── architecture/
│   ├── contract/
│   ├── e2e/
│   └── testcontainers/
│
├── deployment/
│   ├── docker/
│   ├── docker-compose/
│   ├── kubernetes/
│   └── github-actions/
│
├── samples/
│   ├── clean-ddd/
│   ├── modular-monolith/
│   └── microservices/
│
└── tests/
```

The structure may change over time as the architecture evolves.

---

# 🧱 Building Blocks

Common building blocks are maintained independently from specific architecture implementations.

Examples include:

### Domain

* Entity
* Aggregate Root
* Value Object
* Domain Event
* Domain Exception
* Specification
* Domain Service
* Result Pattern

### Application

* Command
* Query
* Command Handler
* Query Handler
* Pipeline Behavior
* Unit of Work
* Transaction Abstraction

### Infrastructure

* Persistence
* Messaging
* Caching
* Authentication
* External Services

### Cross-Cutting

* Logging
* Validation
* Error Handling
* Exception Handling
* Serialization
* Auditing
* Correlation ID

---

# 🧩 Architectural Patterns

The repository explores multiple architectural styles.

## Clean Architecture

Separation of:

```text
Presentation
     ↓
Application
     ↓
Domain
     ↑
Infrastructure
```

The central principle is the **Dependency Rule**:

> Dependencies should point toward the core of the application.

---

## Domain-Driven Design

Both strategic and tactical DDD concepts are explored.

### Strategic DDD

* Bounded Context
* Context Map
* Ubiquitous Language
* Shared Kernel
* Anti-Corruption Layer
* Customer/Supplier
* Conformist

### Tactical DDD

* Entity
* Value Object
* Aggregate
* Aggregate Root
* Domain Service
* Domain Event
* Repository
* Factory
* Specification

---

## CQRS

Command and Query responsibilities are separated:

```text
             Application
                 │
        ┌────────┴────────┐
        ↓                 ↓
     Command            Query
        ↓                 ↓
     Write Model       Read Model
```

CQRS implementations may range from simple in-process separation to distributed read/write models.

---

## Modular Monolith

A modular monolith is used to explore strong module boundaries without immediately introducing distributed-system complexity.

Example:

```text
Application
│
├── Identity
├── Catalog
├── Orders
└── Notifications
```

Modules should communicate through explicit contracts rather than depending directly on each other's internal implementation.

---

## Microservices

Microservice examples focus on the problems that appear after introducing distribution:

* Service boundaries
* API Gateway
* Service-to-service communication
* Messaging
* Eventual consistency
* Distributed transactions
* Saga
* Outbox
* Inbox
* Idempotency
* Resilience
* Observability

---

# 🔐 Security

Security is treated as an architectural concern rather than just an authentication implementation.

Areas include:

```text
Authentication
Authorization
JWT
JWS
JWE
OAuth 2.0
OpenID Connect
PKCE
Refresh Token Rotation
Token Revocation
RBAC
ABAC
Permissions
Claims
Encryption
Hashing
Secrets Management
```

---

# 📨 Messaging

Messaging patterns are explored independently from specific brokers.

```text
Application
     │
     ↓
 Message
     │
     ↓
 Message Broker
     │
     ├── Consumer A
     ├── Consumer B
     └── Consumer C
```

Topics include:

* RabbitMQ
* Kafka
* Publish/Subscribe
* Point-to-Point
* Retry
* Dead Letter Queue
* Delayed Messages
* Outbox
* Inbox
* Idempotent Consumers
* Message Ordering
* Message Deduplication

---

# 🔄 Distributed Systems

Distributed systems introduce problems that do not exist in simple monolithic applications.

This repository explores:

* Eventual Consistency
* Distributed Lock
* Distributed Cache
* Distributed Transactions
* Idempotency
* Retry
* Timeout
* Circuit Breaker
* Bulkhead
* Rate Limiting
* Backpressure
* Saga
* Outbox
* Inbox

---

# 📦 Persistence

Persistence experiments include:

* Entity Framework Core
* SQL Server
* PostgreSQL
* MongoDB
* Redis

And patterns such as:

* Repository
* Specification
* Unit of Work
* Transactions
* Optimistic Concurrency
* Pessimistic Concurrency
* Soft Delete
* Auditing
* Global Query Filters
* Multi-Tenancy
* Caching

---

# 📊 Observability

Production systems require visibility into their behavior.

The observability area explores:

```text
Logs
Metrics
Traces
Health Checks
```

with technologies such as:

* OpenTelemetry
* Prometheus
* Grafana

A major goal is distributed tracing across:

```text
Client
  ↓
API
  ↓
Service A
  ↓
Message Broker
  ↓
Service B
  ↓
Database
```

---

# 🧪 Testing

Architecture should not only be documented.

It should be **enforced**.

Testing areas include:

```text
Unit Testing
Integration Testing
Architecture Testing
Contract Testing
End-to-End Testing
Performance Testing
```

Architecture tests may verify rules such as:

```text
Domain
  ❌ Infrastructure

Domain
  ❌ ASP.NET Core

Domain
  ❌ EF Core

Application
  ❌ Presentation
```

The goal is to make architectural boundaries executable and enforceable.

---

# 🐳 Infrastructure & Deployment

Infrastructure experiments include:

### Docker

* Multi-stage builds
* API containers
* Worker containers
* Database containers
* Message broker containers

### Docker Compose

Example infrastructure:

```text
API
 │
 ├── SQL Server
 ├── Redis
 └── RabbitMQ
```

Future areas include:

* Kubernetes
* Helm
* GitHub Actions
* CI/CD
* Cloud deployment

---

# 📐 Architecture Decision Records

Important architectural decisions are documented using ADRs.

```text
docs/
└── adr/
    ├── 0001-clean-architecture.md
    ├── 0002-ddd.md
    ├── 0003-cqrs.md
    ├── 0004-message-broker.md
    └── ...
```

Each decision should explain:

```text
Context
Decision
Alternatives
Consequences
Trade-offs
```

This ensures that the repository preserves not only the final implementation, but also **why the implementation exists**.

---

# 📊 Pattern Matrix

Architectural patterns often interact with each other.

The repository therefore aims to maintain a relationship between patterns rather than treating them as isolated technologies.

| Pattern        | DDD | CQRS | Microservices | Messaging | Distributed |
| -------------- | --: | ---: | ------------: | --------: | ----------: |
| Repository     |   ✅ |    ⚪ |             ⚪ |         ⚪ |           ⚪ |
| CQRS           |   ✅ |    ✅ |             ✅ |         ⚪ |           ✅ |
| Domain Events  |   ✅ |    ✅ |             ✅ |         ✅ |           ✅ |
| Outbox         |   ✅ |    ✅ |             ✅ |         ✅ |           ✅ |
| Inbox          |   ⚪ |    ⚪ |             ✅ |         ✅ |           ✅ |
| Saga           |   ✅ |    ⚪ |             ✅ |         ✅ |           ✅ |
| Event Sourcing |   ✅ |    ✅ |             ✅ |         ✅ |           ✅ |
| Idempotency    |   ⚪ |    ⚪ |             ✅ |         ✅ |           ✅ |

Legend:

* ✅ Strong relationship
* ⚪ Optional / contextual

---

# 🧠 How Patterns Are Documented

Each significant pattern should follow a consistent structure:

```text
Pattern/
│
├── README.md
├── src/
├── tests/
├── docs/
└── docker-compose.yml
```

The README should explain:

```text
Problem
Solution
Architecture
Implementation
Alternatives
Advantages
Disadvantages
Trade-offs
When to use
When NOT to use
Testing
```

This repository intentionally focuses on **why**, not only **how**.

---

# 🛠️ Technology Stack

The primary ecosystem is:

* .NET
* C#
* ASP.NET Core
* Entity Framework Core
* SQL Server

Depending on the pattern being explored, additional technologies may be introduced:

* Redis
* RabbitMQ
* Kafka
* Docker
* Kubernetes
* OpenTelemetry
* Prometheus
* Grafana
* Testcontainers

Technologies may change as the repository evolves.

---

# 🚀 Development Philosophy

This project follows several principles:

### 1. No unnecessary complexity

A pattern should only be introduced when it solves a real problem.

### 2. Prefer explicit boundaries

Architectural boundaries should be visible in both code and project structure.

### 3. Architecture must be testable

Important architectural rules should be enforceable through automated tests.

### 4. Every abstraction has a cost

Abstractions are introduced deliberately, not automatically.

### 5. Patterns have trade-offs

No pattern is universally good.

### 6. Architecture evolves

The repository is intentionally a living project.

### 7. Technology is not architecture

Using RabbitMQ does not automatically make a system event-driven.

Using Docker does not automatically make it cloud-native.

Using DDD classes does not automatically make an application DDD.

The architecture is defined by the **relationships, boundaries, decisions, and constraints**.

---

# 🗺️ Roadmap

## Phase 1 — Foundation

* [ ] Repository structure
* [ ] Clean Architecture
* [ ] DDD
* [ ] Building Blocks
* [ ] Architecture Tests
* [ ] ADR
* [ ] C4 Documentation

## Phase 2 — Application Patterns

* [ ] CQRS
* [ ] Pipeline Behaviors
* [ ] Validation
* [ ] Specification
* [ ] Domain Events
* [ ] Integration Events

## Phase 3 — Distributed Systems

* [ ] RabbitMQ
* [ ] Kafka
* [ ] Outbox
* [ ] Inbox
* [ ] Saga
* [ ] Idempotency
* [ ] Eventual Consistency
* [ ] Distributed Lock
* [ ] Resilience

## Phase 4 — Security

* [ ] JWT
* [ ] JWS
* [ ] JWE
* [ ] OAuth 2.0
* [ ] OpenID Connect
* [ ] PKCE
* [ ] Refresh Token Rotation
* [ ] RBAC
* [ ] ABAC

## Phase 5 — Production Engineering

* [ ] Docker
* [ ] Docker Compose
* [ ] Kubernetes
* [ ] OpenTelemetry
* [ ] Prometheus
* [ ] Grafana
* [ ] Health Checks
* [ ] Rate Limiting
* [ ] Distributed Caching

## Phase 6 — Advanced Architecture

* [ ] Event Sourcing
* [ ] Advanced CQRS
* [ ] Multi-Tenancy
* [ ] Sharding
* [ ] Contract Testing
* [ ] Performance Testing
* [ ] Distributed Transactions
* [ ] Cloud Architecture

---

# 🤝 Contributing

This repository is primarily a personal architecture laboratory, but ideas, discussions, improvements, and alternative implementations are welcome.

When adding a new pattern or technology, prefer documenting:

```text
What problem does it solve?
Why was it selected?
What alternatives exist?
What are the trade-offs?
How is it tested?
```

---

# ⚠️ Important

This repository should **not** be considered a universal template for every .NET application.

Architecture should always be selected according to:

* Business requirements
* Team size
* System complexity
* Scalability requirements
* Operational requirements
* Security requirements
* Deployment model
* Performance requirements
* Organizational constraints

The purpose of this repository is to provide **options and practical knowledge**, not to prescribe one architecture.

---

# 📚 References

The repository may reference official documentation, books, research papers, open-source projects, and real-world implementations when appropriate.

Important architectural decisions should always be evaluated against the latest official documentation and real-world constraints.

---

# 📜 License

See [LICENSE](LICENSE) for details.

---

## ⭐ Philosophy

> **Good architecture is not about using more patterns.
> It is about solving the right problems with the right boundaries and accepting the right trade-offs.**

---

**Built as a continuously evolving .NET architecture laboratory.**
