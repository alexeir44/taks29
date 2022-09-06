string? UserNumber;
int result = 0;

// Проверка ввода
string CorrectInput()
{
    string? UserInput;
    int number = 0;
    bool check = false;
    UserInput = Console.ReadLine();
    while (check == false)
    {
        if (int.TryParse(UserInput, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
            UserInput = Console.ReadLine();
        }
    }
    return (UserInput ?? "");
}

// Код программы
Console.Write("Введите целое число: ");
UserNumber = CorrectInput();
for (byte i=0; i<UserNumber.Length; i++)
    result += (int)char.GetNumericValue(UserNumber[i]);

Console.Write($"Сумма поразрядных значений введенного числа = {result}");