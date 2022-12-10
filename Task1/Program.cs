//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

//Потрібно: Створити клас із ім'ям Rectangle. 
//    У тілі класу створити два поля, що описують довжини сторін double side1, side2. 
//    Створити власний конструктор Rectangle(double side1, double side2), 
//    у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів. 
//    Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() 
//    та периметр прямокутника - double PerimeterCalculator(). Створити дві властивості double Area 
//    та double Perimeter з одним методом доступу get. Написати програму, 
//    яка приймає від користувача довжини двох сторін прямокутника і виводить на екран периметр та площу. 

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side1 -> ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side2 -> ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Area = " + rectangle.AreaCalculator());
            Console.WriteLine("Perimetr = " + rectangle.PerimeterCalculator());
        }
    }
}