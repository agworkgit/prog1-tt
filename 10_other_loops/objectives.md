# Objectives

-   Learn how to create loops using the while statement
-   Learn how to create loops using the for statement
-   Learn how to create loops using the do statement
-   Use nested loops
-   Accumulate totals
-   Understand how to improve loop performance
-   Learn about looping issues in GUI programs (SKIP for this course)

## Using the while loop

1. Loop

-   A structure that allows repeated execution of a block of statements
-   We use it when we don't know exactly how many times we want to loop, or if we want to loop indefinitely

2. Loop body

-   A block of statements within a looping structure

3. C# types of loops

-   while loop
-   for loop
-   do loop (or do...while loop)

## Using the for loop

1. for loop

-   A shorthand way to create definite loops
-   Use use this form when we know exactly how many times we want to loop

2. Sections of the loop

-   Control variable initialization
-   Control variable testing
-   Control variable updating

3. Other tasks

-   Initialize more than one variable
-   Declare a new variable
-   Perform more than one test

4. Other tasks (continued)

-   Decrement or perform some other task at the end of the loop's execution
-   Perform multiple tasks at the end of the loop's execution
-   Leave one or more portions of the "for" expression empty

5. Example (while vs for loop)

```
    // Declare loop control variable and limit
    int x;
    const int LIMIT = 10;

    // Using a while loop to display 1 through 10
    x = 1;
    while (x <= LIMIT)
    {
        Console.WriteLine(x);
        x++;
    }

    // Using a for loop to display 1 through 10
    for (x = 1; x <= LIMIT; x++)
    {
        Console.WriteLine(x);
    }
```
