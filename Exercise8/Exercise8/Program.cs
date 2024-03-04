// See https://aka.ms/new-console-template for more information


//This will prompt you to type a number and parse that number into a variable.
Console.WriteLine("Please type a number.");
int number = int.Parse(Console.ReadLine());

//The for loop will add 2 to itself to list each even number in the range you selected.
for (int j = 0; j <= number; j+=2)
{
    Console.WriteLine(j);
}

//This also parses the number that you typed into the console.
Console.WriteLine("How many asterisks do you want?");
int asteriskNumber = int.Parse(Console.ReadLine());

//This will then repeat the number of times that you prompted.
for (int i = 1; i <= asteriskNumber; i++)
{
    Console.Write("*");
}