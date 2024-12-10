# Introduction to C#

This section introduces the fundamentals of **C#**, covering its syntax, structure, and core concepts. By the end, you'll be equipped to write your first C# program.

---

## C# Syntax and Structure

C# programs follow a structured and organized approach. Here's an overview of its components:

- **Namespace**: Organizes code and prevents naming conflicts.
- **Class**: Acts as a blueprint for creating objects.
- **Main Method (`Main`)**: The entry point of a C# program.

### Example Code
```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // Outputs a message
        }
    }
}
```

## Data Types in C#

C# is a strongly typed language with predefined data types:
| **Data Type** | **Description**              | **Example**        |
|---------------|------------------------------|--------------------|
| `int`         | Integer values               | `42`               |
| `float`       | Floating-point numbers       | `3.14f`            |
| `string`      | Text or character arrays     | `"Hello"`          |
| `bool`        | Boolean values               | `true`, `false`    |


## Declaring Variables

A variable stores data and must be declared with a specific type:


```csharp
int age = 25;
string name = "John";
float pi = 3.14f;
bool isActive = true;
```

# Type Casting

Convert one data type to another:
## Implicit Casting

```csharp
int num = 10;
double bigNum = num; // Implicit casting
```

Automatic conversion from smaller to larger types:

## Explicit Casting

Manual conversion with casting syntax:
```csharp
double bigNum = 9.78;
int num = (int)bigNum; // Explicit casting
```

# Writing Your First C# Program

Let’s combine what we've learned to write a simple program:
Code:
```csharp
using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome to C#!");
        }
    }
}

```
## How It Works:

    Console.WriteLine(): Outputs a message to the console.
    Console.ReadLine(): Accepts user input.
    String Interpolation ($"{value}"): Embeds values within a string.

output:

```bash
Enter your name:
John
Hello, John! Welcome to C#!

```