//Задача: Имеется одномерный массив array из n элементов, требуется
//найти элемент массива, равный find.
// Алгоритм:
//- Задать массив
//- ввести переменную размера массива
//- ввести переменную find
//- установить счетчик индекса в позицию 0
//- если array[index] = find, алгоритм завершил работу успешно.
//- увеличить index на 1
//- если index < n, перейти к шагу 2. В противном
//случае алгоритм завершил работу безуспешно.

// 

//Теперь перепишем код с использованием 
//генератора случайных чисел и методов!

// void FillArray(int[] collection) // один из методов, 
// //который ничего не возвращает при этом в коде не 
// //используется оператор "return"!!! 
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10];

// FillArray(array); // - метод заполнения массива
// PrintArray(array); // - метод печати его на экран

// !!Теперь решим задачу с использованием метода!!

void FillArray(int[] collection)  
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // один из методов Integer который использует вывод
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
         if (collection[index] == find)
         {
            position = index; // - без break выведется последнее вхождение, 
            break;            // - чтобы вывести первое вхождение!
         }
         index++;
    }   
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4; // - добавим принудительно несколько четверок для проверки
array[6] = 4; 

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3); // - !!! если ввести число которого не существует, то выведется 0
//чтобы понять, что введено число не находящееся в массиве, существует искуственный прием
//присвоить int position = -1, тогда будет выводится -1, что понимают как 
//введенного числа нет в массиве!!!
Console.WriteLine(pos);
