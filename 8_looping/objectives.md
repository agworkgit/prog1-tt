## Looping

-   Loop
    A strucutre that allows repeated execution of a block of statements

-   Loop body
    A block of statements within a looping structure

-   C# types of loops:
    while loop
    for loop
    do loop (or do...while loop)

## Using the while loop

-   While loop
    Used to execute a body of statements continuously as long as some condition continues to be true

-   Infinite loop
    A loop that never ends

-   Making a while loop end correctly
    Initialise the loop control variable
    Test the control variable in the while expression
    Alter the value of the control variable in the code block

-   Example of while loop

    ```
    using System;
    class FourHellos
    {
        static void Main()
        {
            int number = 1;
            const int LIMIT = 5;
            while (number < LIMIT)
            {
                Console.WriteLine("Hello");
                number = number + 1;
            }
        }
    }
    ```

This program contains a while loop whose body executes four times
