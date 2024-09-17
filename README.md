# CSharpCourses3
1. ООП в программе:
Инкапсуляция - каждый класс отвечает за свою задачу и реализует интерфейсы (TaskManager, ITaskStorage)
Полиморфизм - различные реализации ITaskStorage (например в FileTaskStorage будет что-то вроде SaveTasksToDisk, LoadTasksFromDisk и т.д.)
Наследование - используется только наследование интерфейсов (MemoryTaskStorage : ITaskStorage)
Абстракция - опять же, использование интерейса ITaskStorage

2. Используемые паттерны:
Strategy - взаимозаменяемые хранилища, в мейн можно подставить любую реализацию (ITaskStorage storage = new MemoryTaskStorage(); // Or new FileTaskStorage, SomeOtherTaskStorage etc.).
Command - использование CommandHandler для обработки команд пользователя и использования необходимых функций (добавить, удалить и т.д.)

3. SOLID:
Single Responsibility Principle: Каждый класс отвечает за свою задачу. CommandHandler обрабатывает действия пользователя.
Open/Closed Principle: Приложение легко можно расширить, например реализовывая ITaskStorage.
Liskov Substitution Principle: Не важно, какую имплементацию ITaskStorage мы используем, остальной код будет работать так же.
Interface Segregation Principle: Использование интерфейса ITaskStorage.
Dependency Inversion Principle: Модули верхних уровней (CommandHandler и т.д.) не зависит от нижних уровней (MemoryTaskStorage). Детали зависят от абстракций (MemoryTaskStorage и FileTaskStorage от ITaskStorage)
