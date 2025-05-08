**Last Read at 05.08.2025**

# Pros

- **Independent Scaling:** CQRS allows the read and write workloads to scale independently, and may result in fewer lock contention.
- **Optimized Data Schemas:** The read side can use a schema that is optimized for queries, while the write side uses a schema that is optimized for updates.
- **Security:** It's easier to ensure that only the write right domain entities are performing writes on the data.
- **Seperation of Concerns:** Segregating the read and write side can result in models that are more maintainable and flexible. Most of the complex business logic goes into the write model. The read model can be relatively simple.


# Challenges to Implement

- **Complexity:** The basic idea of CQRS is simple. But it can lead to a more complex application design, especially if they include the Event Sourcing Pattern.
- **Messaging:** Although CQRS does not require messaging, it's common to use messaging to process commands and publish update events. In that case, the application must handle message failures and duplicate messages.
- **Eventual Consistency:** If you separate the read and write databases, the read data may be stale. The read model store must be updated to reflect changes to the write model store and it can be difficult to detect when a user has issued a request based on stale read data.


# When to use CQRS Pattern

- Scenarios where performance of data reads must be fine-tuned separately from performance of data writes, especially when the number of reads is much greater than the number of writes. In this scenario, you can scale out the read model.
- Scnearios where one team of developers can focus on the complex domain model that is part of the write model, and another team can focus on the read model and the user interfaces.


# Reference

- https://code-maze.com/cqrs-mediatr-in-aspnet-core/
- https://docs.aws.amazon.com/prescriptive-guidance/latest/modernization-data-persistence/cqrs-pattern.html