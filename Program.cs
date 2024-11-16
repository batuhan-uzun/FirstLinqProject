// Generate a list of 10 random numbers
Random random = new Random();
List<int> numbers = Enumerable.Range(1, 10).Select(_ => random.Next(-50, 50)).ToList();

// Display the original list
Console.WriteLine("Original List:");
numbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine("\n");

// 1. Even numbers
var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
Console.WriteLine("Even Numbers:");
evenNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine("\n");

// 2. Odd numbers
var oddNumbers = numbers.Where(num => num % 2 != 0).ToList();
Console.WriteLine("Odd Numbers:");
oddNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine("\n");

// 3. Negative numbers
var negativeNumbers = numbers.Where(num => num < 0).ToList();
Console.WriteLine("Negative Numbers:");
negativeNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine("\n");

// 4. Positive numbers
var positiveNumbers = numbers.Where(num => num > 0).ToList();
Console.WriteLine("Positive Numbers:");
positiveNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine("\n");

// 5. Numbers greater than 15 and less than 22
var rangeNumbers = numbers.Where(num => num > 15 && num < 22).ToList();
Console.WriteLine("Numbers Between 15 and 22:");
rangeNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine("\n");

// 6. Squares of each number
var squaredNumbers = numbers.Select(num => num * num).ToList();
Console.WriteLine("Squares of Numbers:");
squaredNumbers.ForEach(num => Console.Write(num + " "));
Console.WriteLine();