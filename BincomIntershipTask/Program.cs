// Task 1: A string variable named name with the value "John Doe"
string name = "Joe Doe";
Console.WriteLine(name);

// Task 2: An integar variable named age with the value
int age = 25;
Console.WriteLine(age);

// Task1 A boolean variable named isAdmin with the value true.
bool isAdmin = true;
Console.WriteLine(isAdmin);

//use an if-else statement to determine whether the number is even or odd
int number = 10;

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even");
}
else
{
    Console.WriteLine($"{number} is odd");
}


//Write a program that prints out the number 1 to 10 using a for loop.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Task 4: Declare and Initialize an integar array with the value 2, 4, 6, 8, 10.
int[] numbers = { 2, 4, 6, 8, 10 };

foreach (int numb in numbers)
{
    Console.WriteLine(numb);
}

// Task 5: Writing a method named Greet that takes a string parameter name and prints out
// a personalized greeting message.
void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
Greet("Alice");



