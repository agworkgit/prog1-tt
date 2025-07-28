# Assignment 4

1. Dice Rolling App. Write an app to simulate the rolling of two dice and displaying how many time each result was rolled (8 Marks: Functionality).
   a. The app should use an object of class Random once to roll the first die and again to roll the second die (2 Marks: Functionality).
   b. The sum of the two values should then be calculated (1 Mark: Functionality).
   c. Each die can show an integer value from 1 to 6, so the sum of the values will vary from 2 to 12, with 7 being the most frequent sum and 2 and 12 the least frequent sums. The figure below shows the 36 possible combinations of the two dice. Your app should roll the dice 36,000 times (1 Mark: Functionality)
   d. Use a one-dimensional array to tally the number of times each possible sum appears (2 Marks: Functionality).
   e. Display the results in tabular format to the console showing how many times each number was rolled

2. Airline Reservations System. A small airline has just purchased a computer for its new automated reservations system. You have been asked to develop the new system. You're to write an app to assign seats on each flight of the airline's only plane (capacity: 10 seats) (12
   Marks: Functionality).
   a. Display the following alternatives in a menu: 1 for First Class, 2 for Economy, 3 for Exit.
   You must use a switch statement and a while loop (3 Marks: Functionality)
   b. If the user types 1, your app should assign a seat in the first-class section (seats 1-5). If the user types 2, your app should assign a seat in the economy section (seats 6-10). Use a one-dimensional array of type bool to represent the seating chart of the plane (2
   Marks: Functionality).
   c. Initialize all the elements of the array to false to indicate that all the seats are empty. (2
   Marks: Functionality).
   d. As each seat is assigned, set the corresponding element of the array to true to indicate that the seat is no longer available (1 Mark: Functionality).
   e. Your app should never assign a seat that has already been assigned. When the economy section is full, your app should ask the person if it's acceptable to be placed in the first-class section (and vice versa). If yes, make the appropriate seat assignment. If no, display the message "Next flight leaves in 3 hours." (4 Marks: Functionality)
