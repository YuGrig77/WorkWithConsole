int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int a1 = 112125;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23111;
// int c3 = 313; Определяем массив для этого кусочка кода:

//              0    1   2  3    4   5   6   7   8 
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
//array[0] = 12;// переприсваивание нового значения
//Console.WriteLine(array[4]);// при выводе получим 12

int result = Max (
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(result);


// int max = Max(
//     Max(a1, b1, c1),
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));

//if (b1 > max) max = b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3; вместо данного модуля будем
//использовать метод Max (в начале) для переменных а, в, с. Для 
//этого удалим блок и введем переменную 
//int max1, 2, 3 = Max(a1, b1, c1) ... (19). И затем
//попросим Max савнить их int max = Max(max1, max2, max3)

//Console.WriteLine(max);

//Все это можно записать через массивы, см Example009_IntroArray

