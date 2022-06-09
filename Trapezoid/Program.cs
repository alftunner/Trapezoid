/*
 * Класс Равнобочная трапеция, члены класса: координаты 4-х точек. Предусмотреть в классе конструктор и методы: проверка,
 * является ли фигура равнобочной трапецией; вычисления и вывода сведений о фигуре: длины сторон, периметр, площадь.
 * В функции main продемонстрировать работу с классом: дано N трапеций, найти количество трапеций, у которых площадь больше средней площади.
 */

using Trapezoid;

TrapezoidClass[] trapezoids =
{
   new TrapezoidClass(),
   new TrapezoidClass(),
   new TrapezoidClass()
};

double averageSquare = TrapezoidClass.calcAverageSquare(trapezoids);

int counter = 0;

foreach (TrapezoidClass trapezoid in trapezoids)
{
    if (trapezoid.compareOfSquare(averageSquare))
    {
        counter++;
    }
}

Console.Write($"Количество трапеций у которых площадь больше средней - {counter}");
 