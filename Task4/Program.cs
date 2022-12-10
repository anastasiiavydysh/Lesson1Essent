//using System.Drawing;

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити класи Point та Figure. Клас Point повинен містити два цілих поля і одне рядкове поле. 
//    Створити три властивості одним методом доступу get. Створити власний конструктор, 
//    у тілі якого проініціалізуйте поля значеннями аргументів. Клас Figure повинен містити конструктори, 
//    які приймають від 3 до 5 аргументів типу Point. Створити два методи: double LengthSide(Point A, Point B), 
//    що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що розраховує периметр багатокутника. 
//    Написати програму, яка виводить на екран назву та периметр багатокутника.

using System.Drawing;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(2, 3);
            Point c = new Point(3, 4);
            Figure figure = new Figure(a, b, c);
            figure.PerimeterCalculator();
        }
    }
}