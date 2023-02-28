//exemple1

// string[,] table = new string[2,5];//задали многомерный массив из 2 строчек и 5 столбцов
// table[1,2] = "слово"; // обращение к нужному нам элементу
// //индексы меняются от 0
// // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]   обращение к элементам столбцов 
// // table[0,0] table[1,0] обращение элементам строк
// //строки инициализируются String.Empty, т.е. пустые, ничего не содержащие
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");


//     }

// }

// Exemple2



void PrintArray(int[,] matr)// метод печати массива
{
    for (int i = 0; i < matr.GetLength(0); i++)// вместо 3 ставим GetLenght(0)
    {
        for (int j = 0; j < matr.GetLength(1); j++)//вместо 4 ставим GetLenght(1)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();//принудительный переход на новую строку
    }
}
int[,] matrix = new int[3,4];


void FillArray(int[,] matr)//метод заполнения массива случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);// [1,10)]

        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();//добавили отступ между массивами
PrintArray(matrix);