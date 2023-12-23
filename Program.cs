// Basic. Takrorlash

// 1 - masala
int n = 1;
int sum = 0;
while (n < 1000)
{
    sum += n;
    n += 2;
}
Console.WriteLine(sum);

// 2 - masala
int[] numbers = { 4, 2, 5, 7, 8 };

for (int i = 0; i < numbers.Length; i++)
{
    int temp = 0;
    for (int j = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            temp = numbers[j + 1];
            numbers[j + 1] = numbers[j];
            numbers[j] = temp;
        }
    }
}
Console.WriteLine(numbers[0] * numbers[numbers.Length - 1]);

//3-masala
Console.Write("Son kiriting: ");
string inputValue = Console.ReadLine();
int x = Convert.ToInt32(inputValue);
int result = 1;
while (x > 0)
{
    result *= x;
    x--;
}
Console.WriteLine(result);