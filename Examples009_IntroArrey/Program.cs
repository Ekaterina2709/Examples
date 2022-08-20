/*                                  // Ищем индекс числа 18
int [] array = {18, 21, 31, 41, 15, 61, 17, 18, 19 };
int n = array.Length;               // указываем размер массива
int find = 18;                      // вводим искомое число
int index = 0;                      // счетчик индекса

while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
       // break; для того чтобы прервать цикл после нахождения первого значения индекса числа
    }
    index++;
}
*/


void FilArray(int[]collection)  //Заполняем массив числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // метод использования рандомных чисел в диапазоне (1-10)
        index++;
    }
}
void PrintArray(int[]col)      // выводим каждую позицию массива на печать
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
       Console.WriteLine(col[position]); 
       position++;
    }
}
int IndexOf(int[]collection, int find)    // переменная для массива и переменная для искомого числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1;   // искуственно вводим значение не совпадающее с индексом для указания отсут. числа
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // для остановки после нахождения первого совпадения
        }
        index++;
    }
    return position; //завершает выполнение функции и возвращает управление вызывающей функции.
}
int [] array = new int [10]; // создали  массив 
FilArray(array); // вызвали метод для заполнения массива числами от 1 до 10
PrintArray(array); // вызвали метод для вывода массива на печать
Console.WriteLine(); // Добавим пустую строчку для разграничения вывода массива и ответа

int pos = IndexOf(array,4); // ищем индекс числа 4 в созданном массиве
Console.WriteLine(pos); // печатаем найденый индекс