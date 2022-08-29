// Сортировка массива
int []arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array) // Выводим заданный массив на экран
{
    int count = array.Length; // присваиваем нулевое значение счетчику элементов
    for (int i = 0; i < count; i++) //открываем цикл прохода по всем элементам массива
    {
        Console.Write($"{array[i]}"); //показываем на экране
    }
    Console.WriteLine(); //разделительная строка
}


void SelectionSort (int[] array) // метод который упорядочивает заданный массив
{
    for (int i = 0; i < array.Length -1; i++) // обращение к длине массива
    {
       int minPositions = i; // определяем позицию где находимся
       for (int j = i+1; j < array.Length; j++) //цикл для прехода на следующию позицию 
       {
        if (array[j]< array[minPositions]) minPositions =j; // сравниваем текущую позицию с мин и присваиваем нов
       }

       int temporary = array[i];           // сохраняем значение позиции в которой находимся
       array[i] = array [minPositions];  // В i позицию кладем найденый элемент
       array [minPositions] = temporary; // в позицию найденого кладем i элемент
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
