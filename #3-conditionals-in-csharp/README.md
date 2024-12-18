# Conditionals in C#

Conditionals are used to perform different actions based on different conditions. In C#, the primary conditional statements are `if`, `else if`, `else`, nested `if`, and `switch`.

## If Statement

The `if` statement executes a block of code if a specified condition is true.

```csharp
int number = 10;
if (number > 5)
{
    Console.WriteLine("Number is greater than 5");
}
```

## Else If Statement

The `else if` statement specifies a new condition to test if the first condition is false.

```csharp
int number = 10;
if (number > 15)
{
    Console.WriteLine("Number is greater than 15");
}
else if (number > 5)
{
    Console.WriteLine("Number is greater than 5 but less than or equal to 15");
}
```

## Else Statement

The `else` statement executes a block of code if none of the previous conditions are true.

```csharp
int number = 3;
if (number > 5)
{
    Console.WriteLine("Number is greater than 5");
}
else
{
    Console.WriteLine("Number is 5 or less");
}
```

## If-Else Ladder

An if-else ladder is a series of `if`, `else if`, and `else` statements to test multiple conditions.

```csharp
int number = 20;
if (number > 30)
{
    Console.WriteLine("Number is greater than 30");
}
else if (number > 20)
{
    Console.WriteLine("Number is greater than 20 but less than or equal to 30");
}
else if (number > 10)
{
    Console.WriteLine("Number is greater than 10 but less than or equal to 20");
}
else
{
    Console.WriteLine("Number is 10 or less");
}
```

## Nested If

A nested `if` is an `if` statement inside another `if` statement.

```csharp
int number = 10;
if (number > 5)
{
    if (number < 15)
    {
        Console.WriteLine("Number is between 5 and 15");
    }
}
```

## Switch Case

The `switch` statement selects one of many code blocks to execute.

```csharp
int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}
```

Conditionals are fundamental in controlling the flow of a program based on different conditions. Understanding and using them effectively is crucial for any C# programmer.