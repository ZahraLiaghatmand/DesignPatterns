# Simple Code for Design Patterns

## Overview

This repository contains simple implementations of various design patterns in C#/.NET. Design patterns are reusable solutions to common problems in software design and can significantly improve the structure and maintainability of your code. This project serves as a reference for developers seeking to understand and apply design patterns in their own projects.

## Design Patterns Included

The following design patterns are implemented in this sample code:

1. **Factory Method Pattern**: Defines an interface for creating an object but leaves the choice of its type to the subclasses, creating instances of several derived classes.
2. **Observer Pattern**: 
- It is used when the state of an object changes and we need to notify other objects about this changes. 
- Defines an Interface called the Observer with a method called update(). Now the other objecs (observers) that had to be notified can implement the update() method and figure out how to update themselves. also the Observable object needs the methods: AddObserver(Observer observer), RemoveObserver(Observer observer), NotifyObservers() which iterarate over the list of observers and calls the update on every observer's update() method.
![Observer Pattern](<Images/Observer Pattern.png>)
- Push Style: We can push a value to the observer through the update() method, but if in the future there will be an observer that needs another set of values, you have to change the update method.
![Observer Pattern Push](<Images/Observer Pattern Push.png>)
- Pull Style: This way the concrete observer is dependent on the concrete observable which is fine.
![Observer Pattern pull](<Images/Observer Pattern pull.png>)
- Example: In excel if you change values of a data source the pie chart based on those values will change.
3. **Mediator Pattern**: 
- It is usefull when a bunch of objects need to talk to each other. 
- Defines an abstract class called owner with a changed(Object object) method and every object that has changed can call on this method, so every concrete object is coupled with the concrete owner that implements the changed() method.
![Mediator Pattern](<Images/Mediator Pattern.png>)
- Example: a dialogue box with some UI Controls that should be able to talk to each other like if a textbox is not empty, the button on that dialogue box should be enabled.
![Mediator Example](<Images/Mediator Example.png>)
- Mediator with Observer:
![Mediator with observer](<Images/Mediator with observer.png>)
## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed
- [Visual Studio](https://visualstudio.microsoft.com/) or your preferred C# development environment

### Running the Sample Code

1. Clone this repository:

   ```bash
   git clone https://github.com/liaghatmand/DesignPatterns.git

## ⭐ Star the Project

If you find this project helpful or interesting, please consider giving it a star on GitHub. It's a simple gesture that helps boost the project's visibility.

## 🤝 Contributing

We welcome contributions! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments
The code in this repository is based on the website [refactoring guru](https://refactoring.guru/)
