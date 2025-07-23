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
