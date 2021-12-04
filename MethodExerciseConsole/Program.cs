

{
    Console.WriteLine("Hello, what is your name?");
    string userName = Console.ReadLine();

    Console.WriteLine("What is your favorite color?");
    string userColor = Console.ReadLine();


    Console.WriteLine("What is your favorite animal?");
    string userAnimal = Console.ReadLine();


    Console.WriteLine("What is your favorite band?");
    string userBand = Console.ReadLine();

    Console.WriteLine($"As {userName} put down his {userColor} mug and drifted away to sleep");
    Console.WriteLine($"He dreamt of attending a concert featuring {userBand} with his trustee little {userAnimal}");

    Console.WriteLine("Give me a number to add, subtract, multiple, divide, and find the remainder");
    int num1= int.Parse(Console.ReadLine());

    Console.WriteLine("Give me a number to complete the calculations");
    int num2 = int.Parse(Console.ReadLine());

    int sum = Addition(num1, num2);   
    Console.WriteLine($"The sum is {sum}");

    int difference = Subtract(num1, num2);
    Console.WriteLine($"The difference is {difference}");

    int product = Multiply(num1, num2);
    Console.WriteLine($"The product is {product}");

    int quotient = Divide(num1, num2);
    Console.WriteLine($"The quotient is {quotient}");

    int remainder = Modulo(num1, num2);
    Console.WriteLine($"The remainder is {remainder}");


}

static int Addition(int num1, int num2)
{
    int sum = num1 + num2;

    return sum;
}

static int Multiply(int x, int y)
{ 
    return x * y;
}

static int Subtract(int num1, int num2)
{
    return num1 - num2;
}

static int Divide(int num1, int num2)
{
    return  num1 / num2;
}

static int Modulo(int num1, int num2)
{
    return num1 % num2;
}
