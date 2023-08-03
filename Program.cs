int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
string Reverse(string text)
{
    char[] array = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = array.Length - 1; i > -1; i--)
    {
        reverse += array[i];
    }
    return reverse;
}

//19
int num = Prompt("Введите пятизначное число: ");
string new_num = Reverse(Convert.ToString(num));

if (Convert.ToString(num) == new_num)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}

//21
int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int z1 = Prompt("Введите координату Z1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");
int z2 = Prompt("Введите координату Z2: ");

Console.WriteLine(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)));

//23
int n = Prompt("Введите читсло N: ");
string res = $"{n} ->";

for (int i = 1; i < n+1; i++)
{
    res = res + $" {i*i*i}";
}

Console.WriteLine(res);