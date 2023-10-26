# FizzBuzz
This project is created to tackle the fizz buzz project with SOLID programming principles.

## Use of system.reflection
I've used system.reflection in a manner such that it looks through for processors in the domain's dll file and automatically runs them in the order they are declared. The beauty of this solution is that to create another processor, one must simple create another class that derives from IProessor and follow suit by just providing an order value and a process method. The program will automatically detect and apply all processors making it very easy to extend and maintain.

## Tests
This project has been created with TDD in mind.

Tests have been made with the NUnit framework.

## How to run this program
1. Clone it and open it visual studio
2. Build all project files (Ctrl + Shift + B)
3. Right click the console application project and set it as startup project
4. Click the run button

## How to run the tests
The tests should automatically appear in the project test runner window available in visual studio. Choose individual tests or the whole lot to run. All tests have been confirmed to pass.
