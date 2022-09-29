void TestWork() {
    Console.WriteLine("Контрольная работа: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа");
    Console.WriteLine("Массив какого размера вы хотите задать? (введите число не больше 5)");

    int size = Convert.ToInt32(Console.ReadLine());
    while (size > 5) {
        Console.WriteLine("Ошибка! Введите число не больше 5!");
        size = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Формируем исходный массив");
    string[] array = CreateArray(size);
    Console.WriteLine("Выводим исходный массив");
    PrintArray(array);
    FinalArray(array);
}

string[] CreateArray(int size) {
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++) {
        Console.WriteLine($"Введите элемент массива №{i + 1}");
        array[i] = Convert.ToString(Console.ReadLine());
        while (array[i].Length > 10) {
            Console.WriteLine("Ошибка! Введите не более 10 символов!");
            array[i] = Convert.ToString(Console.ReadLine());
        }
    }
    return array;
}

void FinalArray(string[] array) {
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            counter++;
        }
    }

    if (counter == 0) {
        Console.WriteLine("В исходном массиве нет ни одного элемента, удовлетворяющего условиям задачи");
    } else {
        string[] FinalArray = new string[counter];
        counter = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i].Length <= 3) {
                FinalArray[counter] = array[i];
                counter++;
            }
        }
        Console.WriteLine("Выводим обработанный массив:");
        PrintArray(FinalArray);
    }
}

void PrintArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();    
}

TestWork();