# Objectives

1. Understand logic-planning tools and decision making
2. Learn how to make decisions using the if statement
3. Learn how to make decisions using the if/else statement
4. Use compound expressions in if statements
5. Make decisions using the switch statement
6. Use the conditional operator
7. Use the NOT notation
8. Learn to avoid common errors when making decisions
9. Learn about decision-making issues in GUI programs

## Understanding Logic-Planning Tools and Decision Making

-   Pseudocode
    A tool that helps programmers plan a program's logic by writing plain English statements
-   Flowchart
    You write steps in diagram form as a series of shapes connected by arrows
-   Sequence structure
    One step follows another unconditionally and sequentially
    Sometimes, logical steps do not follow in an unconditional sequence
-   Decision structure
    Involves choosing between alternative courses of action based on some value within a program
    All computer decisions are yes-or-no decisions when reduced to their most basic form

## Making Decisions Using if Statement

-   if statement
    Used to make a single-alternative decision
-   Block
    One or more statements contained within a pair of curly braces

## Nested if

-   One decision structure, or if statement that is contained within another
-   Decision strucutres can be nested to multiple levels
-   If an outer level if statement fails or retuns a false result, all inner blocks of code are ignored
-   Creating too many levels can result in code that is difficult to understand and maintain

## Making Decisions Using if/else Statement

-   Dual-alternative decisions
    Have two possible outcomes
-   if-else statement
    Used to perform one acion when Boolean expression evaluates to true, and an alternative action whe it evaluates to false

## Using the conditional AND operator

-   Determines whether two expressions are both true
-   Written as two ampersands (&&)
-   You must include a complete Boolean expression on each side of the operator

## Short-circuit evaluation

-   Expressions in each part of an AND expression are evaluated only as much as necessary to determine whether the entire expression is true or false

## Using the conditional OR operator

-   Used when you want some action to occur even if only one of two conditions is true
-   Written as two pipes ||
-   You must include a complete Boolean expression on each side of the operator
-   This conditional will usually the false when both conditions are false

## Short-circuit evaluation

-   Expressions in each part of an OR expression are evaluated only as much as necessary to determine whether the entire expression is true or false

## Making decisions using the switch statement

-   switch structure
    Tests a single variable agains a series of exact matches
-   keywords
    switch, case, break, and default
-   Governing types
    sbyte, byte, short, ushort, int, uint, long, ulong, char, string, and enum
-   A switch does not need a default case
    Good programming practice to include one
-   "No fall through rule"
    Not allowing code to reach the end of a case
    Not allowed in C#
    Use a break statement at the end of each case
-   You can use multiple labels to govern a list of statements

*   Example of switch structure using multiple labels to execute a single statement block:

```
switch(year) {
    case 1:
        Console.WriteLine("Freshman");
        break;
    case 2:
        Console.WriteLine("Sophomore");
        break;
    case 3:
    case 4:
        Console.WriteLine("Upperclass");
        break;
    default:
        Console.WriteLine("Invalid year")
        break;
}
```

case 3 and case 4 are both "Upperclass", showcasing fall through.

-   Using an enumeration with a switch structure is often convenient

```
using System;

class DivisionBasedOnMajor
{
    enum Major
    {
        ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING
    }

    static void Main()
    {
        int major;
        string message;
        Console.Write("Enter major code >> ");
        major = Convert.ToInt32(Console.ReadLine());

        switch((Major) major)
        {
            case Major.ACCOUNTING:
            case Major.CIS:
            case Major.MARKETING:
                message = "Major is in the Business Division";
                break;
            case Major.ENGLISH:
            case Major.MATH:
                message = "Major is in the Humanities Division";
            default:
                message = "Department number is invalid";
                break;
        }
        Console.WriteLine(message);
    }
}
```

## Using the conditional operator

-   Conditional operator
    Used as an abbreviated version of the if-else statement
    A ternary operator that takes three parameters
-   Syntax
    testExpression ? trueResult : falseResult
-   Example
    Console.WriteLine((testScore >= 60) ? "Pass" : "Fail");

## Using the NOT operator

-   NOT operator
    Written as an exclamation point (!)
    Negates the result of any Boolean expression

    -   If the Boolean expression is true, ! makes it false
    -   If the Boolean expression is false, ! makes it true

    Logic using the ! operator can be difficult to read and analyse
    The ! operator has higher precendance than && and ||

## Avoiding common errors when making decisions

-   Most frequent errors include:
    Using the assignment operator (=) instead of the comparison operator (==)
    Inserting a semicolon after the Boolean expression in an if statement
    Failing to block a set of statements with curly braces
    Failing to include a complete Boolean expression on each side of an && or || operator

## Performing accurate and efficient range checks

-   Range check
    A series of if statements that determine whether a value falls within a specified range

-   Problem

    ```
    if (saleAmount >= 1000)
        commissionRate = 0.08;
    if (saleAmount >= 500)
        commissionRate = 0.06;
    if (saleAmount <= 499)
        commissionRate = 0.05;
    ```

    Don't Do It
    Although it wasn't the programmer's intention,
    both of the first two if statements are true for any saleAmount
    greater than or equal to 1000.

-   Solution

    ```
    if (saleAmount >= 1000)
    {
        commissionRate = 0.08;
    }
    else if (saleAmount >= 500)
    {
        commissionRate = 0.06;
    }
    else
    {
        commissionRate = 0.05;
    }
    ```

## Using && and || appropriately

-   Problem
    Print an error message when an employee's hourly pay rate is less than $5.65 and when an employee's hourly pay rate is greater than $60

-   Solution
    ```
    if (payRate < 5.65 || payRate > 60)
    {
        Console.WriteLine("Error in pay rate");
    }
    ```

## Using the ! operator correctly

-   Problem
    Make sure that if the sales code is not 'A' or 'B', the customer gets a 10% discount

-   Solutions

    ```
    if (salesCode != 'A' && salesCode != 'B')
    {
    discount = 0.10;
    }

    if (!(salesCode == 'A' || salesCode == 'B'))
    {
    discount = 0.10;
    }
    ```
