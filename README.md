# LINQ Practice - Random Number List Operations

This is a C# Console Application designed to demonstrate the use of LINQ queries to perform various operations on a list of random numbers. The program generates a list of 10 random numbers and executes multiple LINQ queries to filter and transform the data.

## Features

1. **Random Number Generation**:
   - A list of 10 random numbers between -50 and 50 is generated.

2. **LINQ Operations**:
   - **Even Numbers**: Filters the list to include only even numbers.
   - **Odd Numbers**: Filters the list to include only odd numbers.
   - **Negative Numbers**: Filters the list to include only negative numbers.
   - **Positive Numbers**: Filters the list to include only positive numbers.
   - **Numbers Between 15 and 22**: Filters the list to include numbers greater than 15 and less than 22.
   - **Squares of Numbers**: Creates a new list where each number is replaced by its square.

3. **Console Output**:
   - The results of each LINQ operation are displayed in the console for easy visualization.

## How to Run

1. Clone or download the repository.
2. Open the project in an IDE (e.g., Visual Studio, Visual Studio Code).
3. Build and run the project.

## Example Output

Original List: -12 23 -8 0 34 18 -25 7 20 -3

Even Numbers: -12 -8 0 34 18 20

Odd Numbers: 23 -25 7 -3

Negative Numbers: -12 -8 -25 -3

Positive Numbers: 23 34 18 20 7

Numbers Between 15 and 22: 18 20

Squares of Numbers: 144 529 64 0 1156 324 625 49 400 9


## Project Structure

Program.cs // Contains the main logic of the application


## Concepts Demonstrated

1. **LINQ**:
   - Demonstrates filtering (`Where`), transformation (`Select`), and sorting operations in LINQ.
   
2. **Random Number Generation**:
   - Utilizes `Random` and `Enumerable.Range` to create a list of random integers.

3. **Data Manipulation**:
   - Showcases how to handle and manipulate lists using LINQ for real-world scenarios.

## Contribution

Feel free to fork the repository, make improvements, and submit a pull request. Contributions are always welcome!

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Author

Created by Batuhan Uzun.
