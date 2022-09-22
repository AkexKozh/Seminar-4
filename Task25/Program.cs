Console.WriteLine();

int number = 5;
int exponent = 2;
int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

Console.WriteLine($"{number} ^ {exponent} = {result}");
Console.WriteLine();
