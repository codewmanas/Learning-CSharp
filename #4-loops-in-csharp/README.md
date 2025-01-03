# Loops in C#

## Introduction
Loops are used in programming to execute a block of code repeatedly. In C#, there are several types of loops, each with its own use cases. This documentation provides an overview of the different types of loops available in C#.

## Types of Loops

### 1. `for` Loop
The `for` loop is used when the number of iterations is known beforehand. It consists of three parts: initialization, condition, and iteration.

**Syntax:**
```csharp
for (initialization; condition; iteration)
{
    // Code to be executed
}
```

**Example:**
```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

### 2. `while` Loop
The `while` loop is used when the number of iterations is not known and depends on a condition. The loop continues as long as the condition is true.

**Syntax:**
```csharp
while (condition)
{
    // Code to be executed
}
```

**Example:**
```csharp
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
```

### 3. `do-while` Loop
The `do-while` loop is similar to the `while` loop, but it guarantees that the code block is executed at least once before the condition is tested.

**Syntax:**
```csharp
do
{
    // Code to be executed
} while (condition);
```

**Example:**
```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);
```

### 4. `foreach` Loop
The `foreach` loop is used to iterate over a collection or an array. It simplifies the code by eliminating the need for an explicit counter.

**Syntax:**
```csharp
foreach (type variable in collection)
{
    // Code to be executed
}
```

**Example:**
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

## Conclusion
Loops are a fundamental concept in C# programming, allowing for efficient and concise code execution. Understanding the different types of loops and their use cases is essential for writing effective C# programs.
