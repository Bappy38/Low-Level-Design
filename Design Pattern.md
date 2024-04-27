## Design Principle vs Design Pattern

Design Principles provide high level guidelines to design batter software application. They do not provide implementation guidelines and are not bound to any programming language. The SOLID (SRP, OCP, LSP, ISP, DIP) principles are one of the most popular sets of design principles.

Design Pattern provides low-level solutions related to implementation of commonly occurring object-oriented problems. In other words, design pattern suggest a specific implementation for the specific object oriented programming problem.

## Types of Design Patterns

**Design patterns are categorized into three groups:**
- Creational
- Structural
- Behavioral

## Creational Design Pattern

Creational Design Pattern solve the problems related to object creation. They help to abstract away object creation process that spread accross multiple classes.

- **Singleton:** We have implemented Singleton Pattern in AWS SDK Wrappers (SNS, MediaConvert, S3), BulkRepoContext
- **Abstract Factory:**
- **Factory Method:**
- **Builder:** Used Builder Pattern in PlatformCommand, PlatformQuery
- **Prototype:**

## Structural Design Pattern

The structural design patterns suggest implementing relationships betwen classes and objects.

- **Adapter:**
- **Composite:** We have implemented Composite pattern in Custom ORM named BulkRepoContext's FieldCondition
- **Decorator:**
- **Facade:**
- **Proxy:**
- **Flyweight:**
- **Bridge:**

## Behavioral Design Pattern

The behavioral design patterns suggest ways of communication between classes and objects.

- **Chain of Responsibility:** We have implemented CoR in Logger Implementation
- **Strategy:** We have implemented Strategy for Different FileOpeners(ExcelOpener, VideoOpener) in FileStore, Different NodeConverters(ParagraphConverter, TableConverter, ImageConverter) in WordConverter and Different Exporters(WordExporter, PdfExporter)
- **Observer:**
- **Mediator:** Used Mediator along with CQRS