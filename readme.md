# Winform with origin UI

## Table of contents
1. [Architecture](#1-architecture)
2. [Technical Guideline](#2-technical-guideline-winforms-di-architecture-non-scoped-model)


## 1. Architecture

### Backend

#### Current Structure Overview
The solution is divided into three main layers, following the principle of Separation of Concerns:
- `WinformApp.Domain` (**The Core**): Contains the business logic, entities, and rules. In DDD, this layer must be independent of any external frameworks or technologies.
	- `Entities`: Core business objects with identity.
	- `DomainServices`: Logic that doesn't naturally belong to a single Entity.
	- `Repositories` (**Interfaces**): Definitions for data persistence (Contract only).
- `WinformApp.Infrastructure` (**The Implementation**): Handles technical concerns and interacts with external systems (Databases, APIs).
	- `Contexts`: Likely EF Core DBContext.
	- `Repositories` (**Implementation**): Concrete classes that talk to the database.
	- `ExternalServices`: Integrations with 3rd party providers (Email, SMS, etc.).
- `WinformApp.Application` (**The Orchestrator**): Coordinates the flow of data between the UI and the Domain layer.
	- `ApplicationServices`: Implements use cases (e.g., RegisterUser).
	- `Dtos`: Data Transfer Objects to move data across layers without exposing Entities.

#### Recommended Enhancements for DDD Compliance
To strictly follow DDD patterns, you should consider adding or refining the following components:

**A. In the Domain Layer**

1. **Value Objects**: Add a folder for ValueObjects. These are objects that have no identity and are defined only by their attributes (e.g., Address, Money, DateRange).
2. **Aggregates & Aggregate Roots**: Ensure that your Entities are organized into Aggregates. Define Aggregate Roots to maintain consistency boundaries. All access to the aggregate should go through the root.
3. **Domain Events**: Add a Events folder. These represent "something that happened in the domain" (e.g., OrderPlacedEvent). This allows for decoupling via a "Publish/Subscribe" pattern.
4. **Exceptions**: Create Exceptions specific to business rule violations (e.g., InsufficientFundsException).

**B. In the Application Layer**

1. **CQRS (Command Query Responsibility Segregation)**: Instead of generic services, split logic into:
2. **Commands**: Actions that change state (Create, Update, Delete).
3. **Queries**: Actions that retrieve data (Read-only).
4. **Mappers**: Use a tool like AutoMapper or Mapster to handle the conversion between Entities and Dtos.
5. **Validators**: Add FluentValidation to validate incoming DTOs before they reach the Domain layer.

**C. In the Infrastructure Layer**

The Infrastructure layer serves as the "support mechanism" for all other layers. In a strict DDD approach, it implements the technical details required by the Domain and Application layers while remaining decoupled from the business logic.

1. **Infrastructure Services (Gateways & Adapters)**
	- **External API Integrations**: This layer should house the concrete implementation of external services such as Email providers (SendGrid, MailKit), SMS gateways, or third-party Data Providers (Market Data, Weather APIs).
	- **Anti-Corruption Layer (ACL)**: When consuming data from external legacy systems or third-party APIs, implement an ACL within the Infrastructure layer to translate external data models into your internal Domain Models, preventing "model pollution."
2. **Persistence Logic**
	- **Repository Implementations**: While the interfaces reside in the Domain layer, the actual SQL/NoSQL logic (using EF Core, Dapper, etc.) belongs here.
	- **Data Configurations**: Move EF Core Fluent API configurations into separate EntityTypeConfiguration classes to keep the DbContext clean and maintainable.
3. **Cross-Cutting Concerns**
	- **Caching & Logging**: Implement caching strategies (Redis, Distributed Cache) and logging providers (Serilog, NLog) that fulfill the requirements of the higher layers.
	- **Background Jobs**: Host the implementation for scheduled tasks or background workers (e.g., Hangfire, Quartz.NET) that handle asynchronous processing.
4. **Messaging & Event Bus**
	- Implement the transport mechanism for **Domain Events** or **Integration Events**. This includes the logic for publishing/subscribing to message brokers like RabbitMQ, Azure Service Bus, or MediatR (In-process).

#### Proposed Project Structure (DDD Standard)	

1. **WinformApp.Domain (The Core)**
This layer is the heart of the application. It has no dependencies on any other projects or frameworks (like EF Core).
- `Aggregates/`: (Optional if the app is large) Group related Entities and Value Objects.
- `Entities/`: Business objects with a unique Identity (e.g., User.cs, Product.cs).
- `ValueObjects/`: Objects defined by their attributes, no identity (e.g., Address.cs, Money.cs).
- `Interfaces/`:
	- `Repositories/`: Definitions for data access (e.g., IUserRepository.cs).
	- `Services/`: Definitions for external communication (e.g., IEmailService.cs).
- `DomainServices/`: Logic that involves multiple entities and doesn't fit into a single Entity.
- `Events/`: Domain Events (e.g., OrderPlacedEvent.cs).
- `Exceptions/`: Custom domain-specific exceptions (e.g., InsufficientStockException.cs).

2. **WinformApp.Application (The Orchestrator)**
This layer coordinates tasks. It depends only on the Domain layer.

- `Interfaces/`: Application-specific interfaces (e.g., ICurrentUserContext.cs).
- `UseCases/` (or `Services/`):
	- `Orders/`: (Grouped by feature)
		- `PlaceOrderService.cs`
		- `GetOrderHistoryQuery.cs`
- `Dtos/`: Data Transfer Objects for input/output (e.g., `UserDto.cs`, `CreateOrderRequest.cs`).
- `Mappings/`: Configuration for object mapping (e.g., AutoMapper profiles).
- `Validators/`: Input validation logic (e.g., FluentValidation classes).

3. **WinformApp.Infrastructure (The Implementation)**
This layer implements the interfaces defined in Domain and Application. It depends on Domain.

- `Persistence/`:
	- `Contexts/`: EF Core AppDbContext.cs.
	- `Repositories/`: Concrete SQL/NoSQL implementations.
	- `Configurations/`: Fluent API entity mappings (keeps the DbContext clean).
	- `Migrations/`: Database migration files.
- `ExternalServices/`:
	- `Email/`: Implementation of IEmailService (e.g., Using SendGrid or SMTP).
	- `ApiClients/`: Logic for calling 3rd party APIs (e.g., WeatherApiClient.cs).
- `Logging/`: Implementation of logging adapters (e.g., Serilog).
- `Caching/`: Redis or MemoryCache implementations.

#### Visualizing the Dependency Flow
1. `Domain` is the center (Depends on nothing).
2. `Application` depends on `Domain`.
3. `Infrastructure` depends on `Domain` (to implement its interfaces).
4. `UI` depends on `Application` and `Infrastructure`.


### Presentation Layer (Winform classic)

## 2. Technical Guideline: WinForms DI Architecture (Non-Scoped Model)

### 2.1. Overview
In this architecture, we eliminate direct `DbContext` usage in UI or Business layers. The **Unit of Work** acts as the gatekeeper for the `DbContext`, and **Generic Repositories** handle data access. Since we are not using `Scoped` lifetime, we rely on **Transient UnitOfWork** to ensure "Unit of Work" integrity.

In the absence of `Scoped` lifetime, we categorize every component into two buckets based on **State**:
- **Stateless/Global Infrastructure**: Registered as `Singleton`.
- **Stateful/UI/Unit of Work**: Registered as `Transient`.
  
### 2.2. Component Registration Strategy
|**Category**|**Lifetime**|**Examples**|
|---|---|---|
|**Infrastructure**|`Singleton`|`IConfiguration`, `ILogger`, `IEventAggregator`, `HttpClient`
|**Business Logic**|`Transient`|`IConfiguration`, `IOrderService`, `IProductRepository`, `ICalculationEngine`
|**Data Access**|`Transient`|`IUnitOfWork` (UnitOfWork\<TContext\>)
|**Database**|`Factory`|`IDbContextFactory<TContext>`
|**UI Components**|`Transient`|`MainForm`, `UserControl`, `CustomDialog`
