# Objectives

## Using the do loop

1. do loop

-   Checks at the "bottom" of the loop after one repetition has occured
-   Convenient when you know you want to perform some task at least one time

Example of do loop:

```
do {
    Console.WriteLine("Bank balance is {0}", bankBal.ToString("C"));
    bankBal = bankBal + (bankBal * INT_RATE);
    Console.Write("Do you want to see next year's balance? Y or N ...");
    inputString = Console.ReadLineGetChar();
    response = Convert.ToChar(inputString);
   } while (response == 'Y'); // with the do loop, the loop control variable is tested after the loop body has executed one time
```
