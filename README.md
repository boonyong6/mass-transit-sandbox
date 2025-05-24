# Quick Starts

- Everything builds off of the in-memory.
- Install MassTransit templates.

  ```bash
  dotnet new -i MassTransit.Templates
  ```

- Getting started template (in-memory transport) - `mtworker`
- In-memory transport - Useful for testing.
- Things to be defined:

  - Consumer

    ```bash
    # Command to scaffold a consumer.
    dotnet new mtconsumer
    ```

  - Message
