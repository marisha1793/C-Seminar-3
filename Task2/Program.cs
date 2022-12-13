// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки (X1, Y1, Z1): ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (X2, Y2, Z2): ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());

double FirstX = GetCalculateTheDistanceBetweenPoints(X1, Y1, Z1, X2, Y2, Z2);

Console.Write("Расстояние между двумя точками ");
Console.WriteLine(FirstX);

double GetCalculateTheDistanceBetweenPoints(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    int calculations = (X1 - X2)*(X1 - X2) + (Y1 - Y2)*(Y1 - Y2) + (Z1 - Z2)*(Z1 - Z2);
    double result = Math.Sqrt((double)calculations);
    return result;
}
