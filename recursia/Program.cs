// вычисляем факториал введенного числа

double Factorial (int n)
{
    //1! = 1;
    //0! = 1;
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(3));//1*2*3 = 6
//функция факториал быстро растущая, вызывает переполнение
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");//для решения переполнения меняем тип с int на double
}