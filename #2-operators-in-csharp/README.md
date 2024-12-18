# Operators in C#

## Introduction
Operators in C# are special symbols that perform operations on operands. Operands can be variables, constants, or expressions. Operators are categorized based on the type of operation they perform.

## Types of Operators

### 1. Arithmetic Operators
Arithmetic operators perform mathematical operations such as addition, subtraction, multiplication, division, and modulus.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `+`      | Addition              | `a + b`       |
| `-`      | Subtraction           | `a - b`       |
| `*`      | Multiplication        | `a * b`       |
| `/`      | Division              | `a / b`       |
| `%`      | Modulus (remainder)   | `a % b`       |

### 2. Relational Operators
Relational operators compare two values and return a boolean result.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `==`     | Equal to              | `a == b`      |
| `!=`     | Not equal to          | `a != b`      |
| `>`      | Greater than          | `a > b`       |
| `<`      | Less than             | `a < b`       |
| `>=`     | Greater than or equal | `a >= b`      |
| `<=`     | Less than or equal    | `a <= b`      |

### 3. Logical Operators
Logical operators are used to combine conditional statements.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `&&`     | Logical AND           | `a && b`      |
| `||`     | Logical OR            | `a || b`      |
| `!`      | Logical NOT           | `!a`          |

### 4. Bitwise Operators
Bitwise operators perform bit-level operations on integer types.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `&`      | Bitwise AND           | `a & b`       |
| `|`      | Bitwise OR            | `a | b`       |
| `^`      | Bitwise XOR           | `a ^ b`       |
| `~`      | Bitwise Complement    | `~a`          |
| `<<`     | Left shift            | `a << 2`      |
| `>>`     | Right shift           | `a >> 2`      |

### 5. Assignment Operators
Assignment operators assign values to variables.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `=`      | Assign                | `a = b`       |
| `+=`     | Add and assign        | `a += b`      |
| `-=`     | Subtract and assign   | `a -= b`      |
| `*=`     | Multiply and assign   | `a *= b`      |
| `/=`     | Divide and assign     | `a /= b`      |
| `%=`     | Modulus and assign    | `a %= b`      |
| `&=`     | Bitwise AND and assign| `a &= b`      |
| `|=`     | Bitwise OR and assign | `a |= b`      |
| `^=`     | Bitwise XOR and assign| `a ^= b`      |
| `<<=`    | Left shift and assign | `a <<= 2`     |
| `>>=`    | Right shift and assign| `a >>= 2`     |

### 6. Unary Operators
Unary operators operate on a single operand.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `+`      | Unary plus            | `+a`          |
| `-`      | Unary minus           | `-a`          |
| `++`     | Increment             | `a++` or `++a`|
| `--`     | Decrement             | `a--` or `--a`|
| `!`      | Logical NOT           | `!a`          |
| `~`      | Bitwise NOT           | `~a`          |

### 7. Conditional Operator
The conditional operator, also known as the ternary operator, returns one of two values depending on the value of a boolean expression.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `?:`     | Conditional           | `a ? b : c`   |

### 8. Null-Coalescing Operators
Null-coalescing operators provide a default value for nullable types.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `??`     | Null-coalescing       | `a ?? b`      |
| `??=`    | Null-coalescing assignment | `a ??= b` |

### 9. Type Testing and Cast Operators
These operators are used to test and cast types.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `is`     | Type compatibility    | `a is T`      |
| `as`     | Type conversion       | `a as T`      |
| `typeof` | Type information      | `typeof(T)`   |
| `sizeof` | Size of type          | `sizeof(T)`   |

### 10. Other Operators
Other miscellaneous operators in C#.

| Operator | Description           | Example       |
|----------|-----------------------|---------------|
| `new`    | Create object         | `new T()`     |
| `checked`| Overflow checking     | `checked(a + b)`|
| `unchecked`| No overflow checking| `unchecked(a + b)`|
| `default`| Default value         | `default(T)`  |
| `delegate`| Delegate declaration | `delegate { }`|
| `=>`     | Lambda expression     | `x => x + 1`  |

## Conclusion
Understanding operators is fundamental to programming in C#. This guide provides a comprehensive overview of the various operators available in C#. Practice using these operators to become proficient in their application.
