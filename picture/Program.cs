// как представить черно-белое изображение?
int[,] pic = new int[,]
//0-закрашенный пиксель
//1-незакрашенный пиксель
{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0},
{0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
{0,0,0,0,1,0,0,0,1,1,0,0,0,1,1,0,0,0,1,0,0,0,0,0,0},
{0,0,0,1,0,0,0,0,1,1,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0},
{0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,1,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,1,0,0,0,0,1,1,1,0,0,0,0,1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};
// int[,] pic = new int[23,25];
void PrintImage(int[,] image)// метод печати массива
{
    for (int i = 0; i < image.GetLength(0); i++)// вместо 3 ставим GetLenght(0)
    {
        for (int j = 0; j < image.GetLength(1); j++)//вместо 4 ставим GetLenght(1)
        {
            //Console.Write($"{image[i,j]} ");
            if (image[i,j] == 0)
            Console.Write($" ");
            else Console.Write($"+");

            

            
        }
        Console.WriteLine();//принудительный переход на новую строку
    }
}

void FillImage(int row, int col)//в качестве аргумента используется позиция строки и пикселя, с которого начинаем закраску
{
    if (pic[row, col]==0)
    {
        pic[row, col]=1;//закрышиваем 1
        FillImage(row-1, col);//сначала идем вверх ПРИМЕР РЕКУРСИИ - функция вызызвает сама себя
        FillImage(row, col-1);//затем идем влево
        FillImage(row+1, col);//идем вниз
        FillImage(row, col+1);//идем вправо


    }

}

PrintImage(pic);// если скопировать код из лекции, в терминале будет палец
FillImage(13,13); //координаты случайной точки
PrintImage(pic);