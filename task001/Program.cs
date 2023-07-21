// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PositiveNumber(List<int> array)
{  
    int count = 0;
    for (int i = 0; i < array.Count; i++)
    {
        if (array[i] > 0) count++;          
    }
    Console.WriteLine($"Количество чисел > 0 в массиве - {count} !!");
}

List<int> GetDynamicArray()
{
    List<int> dArray = new List<int>();
    int number;
    bool isValidNumber = false;
    Console.WriteLine("Введите целые числа (любой другой символ окончание ввода):");    
    do
    {
        Console.Write("Следующее число: ");
        string input = Console.ReadLine();
        isValidNumber = int.TryParse(input, out number);               
        if (isValidNumber) dArray.Add(number);             
    }
    while(isValidNumber);
    Console.WriteLine($"Сгенерирован массив - [{String.Join(", ", dArray)}]");
    return dArray;
}

PositiveNumber(GetDynamicArray());