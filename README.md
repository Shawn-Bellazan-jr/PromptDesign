# .NET Clean Architecture Template

### 1. Application Layer 
> Use Cases, Services

This layer will contain application-specific logic, including use cases that define interactions between ViewModels and the Domain Layer.
Services will handle tasks like data access and external communication.

 ### 2. Domain Layer 
> Entities, Business Rules

This layer will represent the core domain model with entities and business rules. It remains independent of other layers, ensuring reusability and maintainability.

### 3. Infrastructure Layer 
> Data Access, External Services

This layer will handle interactions with external resources, such as databases, APIs, or file systems. We can use dependency injection to keep this layer loosely coupled.


### 4. Presentation Layer 
> Views, ViewModels

This layer will house ViewModels built with CommunityToolkit.Mvvm, handling UI logic and interacting with the Application Layer. 
Views will bind to ViewModels using data binding. 

